using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace Home_Service
{
    public partial class ClientTable : Form
    {       
        public ClientTable()
        {
            InitializeComponent();
        }

        private void ClientTable_Load(object sender, EventArgs e)
        {       
            using (var connection = new SqliteConnection("Data Source=HS.db"))//строка подключения
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Clients;"
                };
                SqliteDataReader dr = sql.ExecuteReader();                
                dt.Load(dr);
                dt.Columns["account_number"].ColumnName = "Номер лицевого счёта";
                dt.Columns["full_name"].ColumnName = "ФИО клиента";
                dt.Columns["company"].ColumnName = "Управляющая компания";
                dt.Columns["address"].ColumnName = "Адрес клиента";
                dt.Columns["phone_number"].ColumnName = "Тел.номер клиента";
                clientsDataGrid.DataSource = dt;
                clientsDataGrid.Columns[0].Visible = false;
                clientsDataGrid.Columns[1].Width = 145;
                clientsDataGrid.Columns[2].Width = 145;
                clientsDataGrid.Columns[3].Width = 150;
                clientsDataGrid.Columns[4].Width = 150;
                clientsDataGrid.Columns[5].Width = 145;
                clientsDataGrid.AllowUserToAddRows = false;
                connection.Close();
            }
        }

        private void AddClient_Click(object sender, EventArgs e)//Добавить пользователя
        {
            string company = companyTextBox.Text.ToString();
            string owner = fullNameTextBox.Text.ToString();
            string phone = phoneNumberTextBox.Text.ToString();
            bool isPhone = int.TryParse(phone, out _);
            string address = addressTextBox.Text.ToString();
            string acc_numb = accountNumberTextBox.Text.ToString();
            bool isAccNumb = int.TryParse(acc_numb, out _);

            if (String.IsNullOrWhiteSpace(company) || String.IsNullOrWhiteSpace(owner) || String.IsNullOrWhiteSpace(phone)
                || String.IsNullOrWhiteSpace(address) || String.IsNullOrWhiteSpace(acc_numb))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (isPhone == false || isAccNumb == false)
            {
                MessageBox.Show("Телефон и/или лицевой счёт не являются числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "INSERT INTO Clients (account_number, full_name, phone_number, address, company) VALUES ('"
                    + acc_numb + "', '" + owner + "', '" + phone + "', '" + address + "', '" + company + "');"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            UpdateGridView();
            MessageBox.Show("Запись успешно добавлена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            companyTextBox.Text = "";
            fullNameTextBox.Clear();
            phoneNumberTextBox.Clear();
            addressTextBox.Clear();         
        }
        public void UpdateGridView()
        {
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Clients;"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dt.Columns["account_number"].ColumnName = "Номер лицевого счёта";
                dt.Columns["full_name"].ColumnName = "ФИО клиента";
                dt.Columns["company"].ColumnName = "Управляющая компания";
                dt.Columns["address"].ColumnName = "Адрес клиента";
                dt.Columns["phone_number"].ColumnName = "Тел.номер клиента";
                clientsDataGrid.DataSource = dt;
            }          
        }

        private void EditClient_Click(object sender, EventArgs e)//Редактировать плательщика
        {
            string ID = clientsDataGrid.SelectedCells[0].Value.ToString();            
            if (String.IsNullOrWhiteSpace(companyTextBox.Text) || String.IsNullOrWhiteSpace(fullNameTextBox.Text)
                || String.IsNullOrWhiteSpace(phoneNumberTextBox.Text) || String.IsNullOrWhiteSpace(addressTextBox.Text)
                || String.IsNullOrWhiteSpace(accountNumberTextBox.Text))
            {
                MessageBox.Show("Заполните все поля!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (int.TryParse(phoneNumberTextBox.Text, out _) == false || int.TryParse(accountNumberTextBox.Text, out _) == false)
            {
                MessageBox.Show("Телефон и/или лицевой счёт не являются числом", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "UPDATE Clients SET account_number='" + accountNumberTextBox.Text + "', company='" + companyTextBox.Text + "', full_name='" + fullNameTextBox.Text
                    + "', phone_number='" + phoneNumberTextBox.Text + "', address='" + addressTextBox.Text + "' WHERE id_client="
                    + Convert.ToInt32(ID) + ";"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            UpdateGridView();
            MessageBox.Show("Запись успешно изменена", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            companyTextBox.Text = "";
            fullNameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";                                          
        }

        private void DeleteClient_Click(object sender, EventArgs e)//Удаление пользователя
        {
            string ID = clientsDataGrid.SelectedCells[0].Value.ToString();            
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                DataTable dt = new DataTable();
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "DELETE FROM Clients WHERE id_client='" + Convert.ToInt32(ID) + "';"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }

            UpdateGridView();
            MessageBox.Show("Запись успешно удалена", "Успех!", MessageBoxButtons.OK);
            companyTextBox.Text = "";
            fullNameTextBox.Text = "";
            phoneNumberTextBox.Text = "";
            addressTextBox.Text = "";
        }

        private void Search_Click(object sender, EventArgs e)//Поиск по лицевому счёту
        {
            if (String.IsNullOrWhiteSpace(accountSearchTextBox.Text))
            { 
                MessageBox.Show("Ошибка! Поле поиска пусто", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (int.TryParse(accountNumberTextBox.Text, out _) == false)
            {
                MessageBox.Show("Ошибка! Введено не число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Clients WHERE account_number=" + Convert.ToInt32(accountSearchTextBox.Text) + ";"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                dt.Columns["company"].ColumnName = "Управляющая компания";
                dt.Columns["account_number"].ColumnName = "Лицевой счет";
                dt.Columns["full_name"].ColumnName = "ФИО";
                dt.Columns["phone_number"].ColumnName = "Телефон";
                dt.Columns["address"].ColumnName = "Адрес";
                clientsDataGrid.DataSource = dt;
                clientsDataGrid.Columns[0].Width = 130;
                clientsDataGrid.Columns[1].Width = 140;
                clientsDataGrid.Columns[2].Width = 240;
                clientsDataGrid.Columns[3].Width = 140;
                clientsDataGrid.Columns[4].Width = 110;
                connection.Close();
            }
        }

        private void MenuCT_Click(object sender, EventArgs e)//Кнопка меню
        {
            MainPage mainPage = new MainPage();
            this.Visible = false;
            mainPage.ShowDialog();
        }

        private void clientsDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//Подгрузка данныъ в элементы на форме
        {
            string ID = clientsDataGrid.SelectedCells[0].Value.ToString();
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM Clients WHERE id_client=" + Convert.ToInt32(ID) + ";"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(dr);
                companyTextBox.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();//Управляющая компания
                fullNameTextBox.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();//ФИО
                phoneNumberTextBox.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();//телефон
                addressTextBox.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();//адрес
                connection.Close();
            }
        }
    }
}