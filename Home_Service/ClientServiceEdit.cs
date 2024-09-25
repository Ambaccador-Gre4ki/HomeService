using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace Home_Service
{
    public partial class ClientServiceEdit : Form
    {
        public ClientServiceEdit()
        {
            InitializeComponent();
        }

        private void ClientServiceEdit_Load(object sender, EventArgs e)
        {
            serviceComboBox.DropDownStyle = ComboBoxStyle.DropDownList;//услуга
            clientComboBox.DropDownStyle = ComboBoxStyle.DropDownList;//клиент
            fill();
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                //Загрузка услуг
                SqliteCommand sqliteCommand = new SqliteCommand("SELECT * FROM Services;",
                    connection);
                SqliteDataReader sql = sqliteCommand.ExecuteReader();
                while (sql.Read())
                {
                    serviceComboBox.Items.Add(sql.GetValue(1).ToString());
                }
                //Загрузка плательщика
                SqliteCommand sqliteCommand_1 = new SqliteCommand("SELECT * FROM Clients;", 
                    connection);
                SqliteDataReader sqliteDataReader = sqliteCommand_1.ExecuteReader();
                while (sqliteDataReader.Read())
                {
                    clientComboBox.Items.Add(sqliteDataReader.GetValue(2).ToString());
                }        
                connection.Close();
            }
            UpdateGridView();
        }

        private void Menu_Click(object sender, EventArgs e)//Кнопка меню
        {
            MainPage mainPage = new MainPage();
            this.Visible = false;
            mainPage.ShowDialog();
        }

        private void AddClientService_Click(object sender, EventArgs e)//Добавление услуги
        {
            if (serviceComboBox.Text == "" || clientComboBox.Text == "")
            {
                MessageBox.Show("Выберите счет и услугу", "Ошибка :(");
            }
            else
            {
                using (var connection = new SqliteConnection("Data Source=HS.db"))
                {
                    DataTable dt = new DataTable();
                    DataTable dt2 = new DataTable();
                    connection.Open();
                    //ID сервиса
                    SqliteCommand sql = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "SELECT id_service FROM Services WHERE service='" + serviceComboBox.Text + "';"
                    };
                    SqliteDataReader dr = sql.ExecuteReader();
                    dt.Load(dr);
                    int id_service = Convert.ToInt32(dt.Rows[0].ItemArray.GetValue(0));

                    //ID клиента
                    SqliteCommand sql2 = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "SELECT id_client FROM Clients WHERE full_name='" + clientComboBox.Text + "';"
                    };
                    SqliteDataReader dr2 = sql2.ExecuteReader();
                    dt2.Load(dr2);
                    int id_client = Convert.ToInt32(dt2.Rows[0].ItemArray.GetValue(0));

                    //Вставка в таблицу
                    SqliteCommand sqliteCommand = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "INSERT INTO Clients_Services (id_client, id_service) VALUES ('"
                        + id_client + "', '" + id_service + "');"
                    };

                    sqliteCommand.ExecuteNonQuery();
                    connection.Close();
                }
                UpdateGridView();
                MessageBox.Show("Изменения внесены в базу", "", MessageBoxButtons.OK);
            }
        }

        public void UpdateGridView()//Обновление dataGrid
        {
            using (var connection = new SqliteConnection("Data Source = HS.db"))
            {
                connection.Open();
                DataTable dt = new DataTable();
                dt.Constraints.Clear();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT cs.id_cs, c.account_number, c.full_name, s.service, s.price FROM Clients c LEFT JOIN Clients_Services cs ON c.id_client=cs.id_client LEFT JOIN Services s ON cs.id_service=s.id_service"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                dt.Load(dr);
                dt.Columns["account_number"].ColumnName = "Номер лицевого счёта";
                dt.Columns["full_name"].ColumnName = "ФИО";
                dt.Columns["service"].ColumnName = "Услуга";
                dt.Columns["price"].ColumnName = "Цена";
                client_serviceDataGrid.DataSource = dt;
                client_serviceDataGrid.Columns[0].Visible = false;
                client_serviceDataGrid.Columns[1].Width = 180;
                client_serviceDataGrid.Columns[2].Width = 180;
                client_serviceDataGrid.Columns[3].Width = 180;
                client_serviceDataGrid.Columns[4].Width = 180;
                connection.Close();
            }
        }

        public void fill()//Заполнение таблицы
        {
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                DataTable dt = new DataTable();
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Clients_Services"
                };
                sql.ExecuteReader();
                connection.Close();
            }
        }

        private void DeleteClientService_Click(object sender, EventArgs e)//Удаление услуги
        {
            string ID = client_serviceDataGrid.SelectedCells[0].Value.ToString();
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "DELETE FROM Clients_Services WHERE id_cs=" + Convert.ToInt32(ID) + ";"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            UpdateGridView();
        }
    }
}