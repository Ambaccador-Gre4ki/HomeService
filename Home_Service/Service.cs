using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace Home_Service
{
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }
        private void Service_Load(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        public void UpdateGridView()
        {
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Services;"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dt.Columns[1].ColumnName = "Услуга";
                dt.Columns[2].ColumnName = "Стоимость";
                serviceDataGrid.DataSource = dt;
                serviceDataGrid.Columns[0].Visible = false;
                serviceDataGrid.Columns[1].Width = 172;
                serviceDataGrid.Columns[2].Width = 173;
                connection.Close();
            }
        }

        private void Menu_Click(object sender, EventArgs e)//меню
        {
            MainPage mainPage = new MainPage();
            this.Visible = false;
            mainPage.ShowDialog();
        }

        private void serviceDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID = serviceDataGrid.SelectedCells[0].Value.ToString();

            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Services WHERE id_service='" + Convert.ToInt32(ID) + "';"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                serviceName.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                priceValue.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                connection.Close();
            }
        }
        
        private void AddService_Click(object sender, EventArgs e)//Добавить услугу
        {
            string name = serviceName.Text.ToString();
            string price = priceValue.Text.ToString();
            bool isNumb = int.TryParse(price, out _);//Проверка на то, что цена является числом            
            if (String.IsNullOrWhiteSpace(name) || String.IsNullOrWhiteSpace(price))
            {
                MessageBox.Show("Ошибка! Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isNumb == false)
            {
                MessageBox.Show("Ошибка! Тариф не является числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "INSERT INTO Services (service, price) VALUES ('" + name + "', '" + price + "');"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Запись в базу добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateGridView();
            serviceName.Clear();
            priceValue.Clear();
        }

        private void ChangeService_Click(object sender, EventArgs e)//изменить услугу
        {
            string name = serviceName.Text.ToString();
            string price = priceValue.Text.ToString();
            bool isNumb = int.TryParse(price, out _);//Проверка на то, что цена является числом

            string ID = serviceDataGrid.SelectedCells[0].Value.ToString();
            if (isNumb == false)
            {
                MessageBox.Show("Ошибка! Тариф не является числом!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "UPDATE Services SET service='" + name + "', price='" + price + "'WHERE id_service='" + Convert.ToInt32(ID) + "';"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Запись в базе изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateGridView();
            serviceName.Clear();
            priceValue.Clear();
        }

        private void DeleteService_Click(object sender, EventArgs e)//Удаление услуги
        {
            string name = serviceName.Text.ToString();
            string price = priceValue.Text.ToString();
            string ID = serviceDataGrid.SelectedCells[0].Value.ToString();

            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "DELETE FROM Services WHERE id_service='" + Convert.ToInt32(ID) + "';"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Запись в базе была удалена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            UpdateGridView();
            serviceName.Clear();
            priceValue.Clear();
        }
    }
}
