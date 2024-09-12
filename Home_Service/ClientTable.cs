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
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 145;
                dataGridView1.Columns[2].Width = 145;
                dataGridView1.Columns[3].Width = 150;
                dataGridView1.Columns[4].Width = 150;
                dataGridView1.Columns[5].Width = 145;
                dataGridView1.AllowUserToAddRows = false;
                connection.Close();
            }
        }

        private void button3_Click(object sender, EventArgs e)//Добавить пользователя
        {
            if (textBox6.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            { MessageBox.Show("Ошибка! Заполните все поля!", "", MessageBoxButtons.OK); }
            else
            {
                string company = textBox6.Text.ToString();
                string owner = textBox1.Text.ToString();
                string phone = textBox2.Text.ToString();
                string address = textBox3.Text.ToString();
                string acc_numb = textBox4.Text.ToString();

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
                MessageBox.Show("Запись успешно добавлена", "Успех!", MessageBoxButtons.OK);
                textBox6.Text = "";
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
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
                dataGridView1.DataSource = dt;
            }          
        }

        private void button4_Click(object sender, EventArgs e)//Редактировать плательщика
        {
            string ID = dataGridView1.SelectedCells[0].Value.ToString();
            if (textBox6.Text == "" || textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == "")
            {
                MessageBox.Show("Ошибка! Заполните все поля!", "", MessageBoxButtons.OK);
            }
            else
            {
                using (var connection = new SqliteConnection("Data Source=HS.db"))
                {
                    connection.Open();
                    SqliteCommand sql = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "UPDATE Clients SET account_number='" + textBox4.Text + "', company='" + textBox6.Text + "', full_name='" + textBox1.Text
                        + "', phone_number='" + textBox2.Text + "', address='" + textBox3.Text + "' WHERE id_client="
                        + Convert.ToInt32(ID) + ";"
                    };                    
                    sql.ExecuteNonQuery();
                    connection.Close();
                }
                
                UpdateGridView();
                MessageBox.Show("Запись успешно изменена", "Успех!", MessageBoxButtons.OK);
                textBox6.Text = "";
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
            }
        }

        private void button5_Click(object sender, EventArgs e)//Удаление пользователя
        {
            string ID = dataGridView1.SelectedCells[0].Value.ToString();
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
            textBox6.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)//Поиск по лицевому счёту
        {
            if (textBox5.Text == "")
            { MessageBox.Show("Ошибка! Заполните поле 'Лицевой счет'", "Ошибка :(", MessageBoxButtons.OK); }
            else
            {
                using (var connection = new SqliteConnection("Data Source=HS.db")) {
                    connection.Open();
                    SqliteCommand sql = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "SELECT * FROM Clients WHERE account_number=" + Convert.ToInt32(textBox5.Text) + ";"
                    };
                    SqliteDataReader dr = sql.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(dr);
                    dt.Columns["company"].ColumnName = "Управляющая компания";
                    dt.Columns["account_number"].ColumnName = "Лицевой счет";
                    dt.Columns["full_name"].ColumnName = "ФИО";
                    dt.Columns["phone_number"].ColumnName = "Телефон";
                    dt.Columns["address"].ColumnName = "Адрес";
                    dataGridView1.DataSource = dt;
                    dataGridView1.Columns[0].Width = 130;
                    dataGridView1.Columns[1].Width = 140;
                    dataGridView1.Columns[2].Width = 240;
                    dataGridView1.Columns[3].Width = 140;
                    dataGridView1.Columns[4].Width = 110;
                    connection.Close();
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)//Кнопка меню
        {
            MainPage mainPage = new MainPage();
            this.Visible = false;
            mainPage.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)//Подгрузка данныъ в элементы на форме
        {
            string ID = dataGridView1.SelectedCells[0].Value.ToString();
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
                textBox6.Text = dt.Rows[0].ItemArray.GetValue(5).ToString();//Управляющая компания
                textBox1.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();//ФИО
                textBox2.Text = dt.Rows[0].ItemArray.GetValue(3).ToString();//телефон
                textBox3.Text = dt.Rows[0].ItemArray.GetValue(4).ToString();//адрес
                connection.Close();
            }
        }
    }
}