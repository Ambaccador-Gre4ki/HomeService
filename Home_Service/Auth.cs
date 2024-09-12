using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace Home_Service
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }
        private void Auth_Load(object sender, EventArgs e)
        {
            using (var connection = new SqliteConnection("Data Source=HS.db"))//строка подключения
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT service, price FROM Services;"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                DataTable dt = new DataTable();
                //dr.Read();
                dt.Load(dr);
                dataGridView1.DataSource = dt;
                dt.Columns["service"].ColumnName = "Услуга";
                dt.Columns["price"].ColumnName = "Цена";
                dataGridView1.Columns[0].Width = 180;
                dataGridView1.Columns[1].Width = 130;
                dataGridView1.AllowUserToAddRows = false;
                connection.Close();
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            //обработка авторизации
            try {
                string login = textBox1.Text;
                string password = textBox2.Text;
                using (var connection = new SqliteConnection("Data Source=HS.db"))//строка подключения
                {
                    connection.Open();                    
                    SqliteCommand sql = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "SELECT login, password, role, id_client FROM Users WHERE login= '" + login + "' AND password = '" + password + "';"
                    };
                    SqliteDataReader dr = sql.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);                    
                    nuls.state = Convert.ToInt32(dt.Rows[0].ItemArray.GetValue(2));
                    nuls.user_id = Convert.ToInt32(dt.Rows[0].ItemArray.GetValue(3));
                    connection.Close();
                }
                MainPage mainPage = new MainPage();
                this.Visible = false;
                mainPage.ShowDialog();
            }
            catch (Exception ex) {
                _ = ex.Message;
                MessageBox.Show("Неверный логин или пароль", "Ошибка");
            }
        }        
    }
}