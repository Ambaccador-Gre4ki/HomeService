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
                ClientDB.Visible = false;//то редактирование базы
                AddServiceToClient.Visible = false;//недоступно
                ServiceDB.Visible = false;//может только подать данные                                       
            }
            else
            {
                SendParameters.Visible = false;//оператор не может передавать данные счётчика
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
                pricesDataGrid.DataSource = dt;
                dt.Columns["service"].ColumnName = "Услуга";
                dt.Columns["price"].ColumnName = "Цена";                
                pricesDataGrid.Columns[0].Width = 180;
                pricesDataGrid.Columns[1].Width = 130;
                pricesDataGrid.AllowUserToAddRows = false;
                connection.Close();
            }

        }
        
        private void ClientDB_Click(object sender, EventArgs e)//База потребителей
        {
            ClientTable clientTable = new ClientTable();
            this.Visible = false;
            clientTable.ShowDialog();
        }       

        private void SendParameters_Click(object sender, EventArgs e)//Передать показания
        {
            SendParams sendParams = new SendParams();
            this.Visible = false;
            sendParams.ShowDialog();
        }

        private void AddServiceToClient_Click(object sender, EventArgs e)//Добавление услуг потребителю
        {
            ClientServiceEdit clientServiceEdit = new ClientServiceEdit();
            this.Visible = false;
            clientServiceEdit.ShowDialog();
        }

        private void ServiceDB_Click(object sender, EventArgs e)//База жилищно-коммунальных услуг
        {
            Service service = new Service();
            this.Visible = false;
            service.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)//Вызод из приложения
        {
            Application.Exit();
        }

        private void News_Click(object sender, EventArgs e)
        {

        }
    }
}