using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace Home_Service
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();            
        }
        private void MainPage_Load(object sender, EventArgs e)
        {            
            if (nuls.state == 0)//если обычный пользователь
            {
                button1.Visible = false;//то редактирование базы
                button2.Visible = false;//недоступно
                button3.Visible = false;//может только подать данные                                       
            }
            else
            {
                button5.Visible = false;//оператор не может передавать данные счётчика
            }
            //ПОКАЗЫВАЕМ ЦЕНУ УСЛУГ
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
        private void button1_Click(object sender, EventArgs e)//База потребителей
        {
            ClientTable clientTable = new ClientTable();
            this.Visible = false;
            clientTable.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)//Передать показания
        {
            SendParams sendParams = new SendParams();
            this.Visible = false;
            sendParams.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)//Добавление услуг потребителю
        {
            ClientServiceEdit clientServiceEdit = new ClientServiceEdit();
            this.Visible = false;
            clientServiceEdit.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)//База жилищно-коммунальных услуг
        {
            Service service = new Service();
            this.Visible = false;
            service.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
