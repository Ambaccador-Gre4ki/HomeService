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
            try {
                //Путь к БД - С:\Users\Maxim\Document\HomeService\Home_Service\bin\Debug\HS.db
                using (var connection = new SqliteConnection("Data Source=HS.db"))//строка подключения
                {
                    connection.Open();
                    //Загрузка тарифов
                    SqliteCommand sql = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "SELECT service, price FROM Services;"
                    };
                    SqliteDataReader dr = sql.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    serviceDataGrid_MainPage.DataSource = dt;
                    dt.Columns["service"].ColumnName = "Услуга";
                    dt.Columns["price"].ColumnName = "Цена";
                    serviceDataGrid_MainPage.Columns[0].Width = 180;
                    serviceDataGrid_MainPage.Columns[1].Width = 130;
                    serviceDataGrid_MainPage.AllowUserToAddRows = false;
                    //Загрузка новостей
                    SqliteCommand sql_news = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "SELECT Text FROM News;"
                    };
                    SqliteDataReader reader = sql_news.ExecuteReader();
                    while (reader.Read()) {
                        news_text.Text = reader.GetString(0);
                    }
                    connection.Close();
                }            
            }
            catch 
            {
                MessageBox.Show("Не удалось подключиться к базе данных!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SignIn_Click(object sender, EventArgs e)
        {
            //обработка авторизации
            try
            {
                string login = this.login.Text;
                string password = this.password.Text;
                if (String.IsNullOrWhiteSpace(login) || String.IsNullOrWhiteSpace(password))
                {
                    MessageBox.Show("Ошибка! Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }                
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
            catch (Exception ex)
            {
                _ = ex.Message;
                MessageBox.Show("Неверный логин или пароль", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}