using Microsoft.Data.Sqlite;
using System;
using System.Data;
using System.Windows.Forms;

namespace Home_Service
{
    public partial class SendParams : Form
    {
        public SendParams()
        {
            InitializeComponent();
        }

        private void SendParams_Load(object sender, EventArgs e)
        {
            UpdateGridView();
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                SqliteCommand sql = new SqliteCommand//загрузка услуг в comboBox
                {
                    Connection = connection,
                    CommandText = "SELECT service FROM Services s " +
                    "INNER JOIN Clients_Services cs ON s.id_service=cs.id_service " +
                    "INNER JOIN Clients c ON c.id_client=cs.id_client " +
                    "WHERE cs.id_client=" + nuls.user_id + ";"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1.Items.Add((string)dr["service"]);
                }
                connection.Close();
            }
        }
        public void UpdateGridView()
        {
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();
                DataTable dt = new DataTable();
                SqliteCommand sql = new SqliteCommand//получение таблицы с историей платежей
                {
                    Connection = connection,
                    CommandText = "SELECT cs.id_cs, s.service, s.price, cs.data, cs.value_prev, cs.value_curr, ((cs.value_curr - cs.value_prev)*s.price) AS [К оплате] FROM Clients c " +
                    "LEFT JOIN Clients_Services cs ON c.id_client=cs.id_client " +
                    "LEFT JOIN Services s ON cs.id_service=s.id_service WHERE cs.id_client='" + nuls.user_id + "';"
                };
                SqliteDataReader dr = sql.ExecuteReader();
                dt.Load(dr);
                dt.Columns["service"].ColumnName = "Услуга";
                dt.Columns["price"].ColumnName = "Цена за ед.";
                dt.Columns["data"].ColumnName = "Дата передачи прошлого показания";
                dt.Columns["value_prev"].ColumnName = "Прошлое значение";
                dt.Columns["value_curr"].ColumnName = "Текущее значение";

                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.AllowUserToAddRows = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)//Меню
        {
            MainPage mainPage = new MainPage();
            this.Visible = false;
            mainPage.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)//Передача показателей
        {
            string service = comboBox1.Text.ToString();
            string data = dateTimePicker1.Text.ToString();
            string curr_value = textBox1.Text.ToString();

            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {

                connection.Open();
                SqliteCommand sql = new SqliteCommand 
                { 
                    Connection = connection,
                    CommandText = "UPDATE Clients_Services SET id_client=" + nuls.user_id + 
                    ", id_service=(SELECT id_service FROM Services WHERE service='" + service + "'), data='" + data + "', value_prev=value_curr, "
                    + "value_curr=" + curr_value + " WHERE id_client=" + nuls.user_id + " AND id_service=(SELECT id_service FROM Services WHERE service='" + service + "');"
                };
                sql.ExecuteNonQuery();
                connection.Close();
            }
            UpdateGridView();
        }

    }
}