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
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Width = 172;
                dataGridView1.Columns[2].Width = 173;
                connection.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)//меню
        {
            MainPage mainPage = new MainPage();
            this.Visible = false;
            mainPage.ShowDialog();
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string ID = dataGridView1.SelectedCells[0].Value.ToString();

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
                textBox1.Text = dt.Rows[0].ItemArray.GetValue(1).ToString();
                textBox2.Text = dt.Rows[0].ItemArray.GetValue(2).ToString();
                connection.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)//Добавить услугу
        {
            string name = textBox1.Text.ToString();
            string price = textBox2.Text.ToString();            
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand
                {
                    Connection= connection,
                    CommandText = "INSERT INTO Services (service, price) VALUES ('" + name + "', '" + price + "');"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Запись в базу добавлена", "", MessageBoxButtons.OK);
            UpdateGridView();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button2_Click(object sender, EventArgs e)//изменить услугу
        {
            string name = textBox1.Text.ToString();
            string price = textBox2.Text.ToString();
            string ID = dataGridView1.SelectedCells[0].Value.ToString();

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
            UpdateGridView();
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button3_Click(object sender, EventArgs e)//Удаление услуги
        {
            string name = textBox1.Text.ToString();
            string price = textBox2.Text.ToString();
            string ID = dataGridView1.SelectedCells[0].Value.ToString();

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
            UpdateGridView();
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
