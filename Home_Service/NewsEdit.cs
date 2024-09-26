using Microsoft.Data.Sqlite;
using System;
using System.IO;
using System.Windows.Forms;

namespace Home_Service
{
    public partial class NewsEdit : Form
    {
        public NewsEdit()
        {
            InitializeComponent();
        }

        private void NewsEdit_Load(object sender, EventArgs e)
        {            
            using (var connection = new SqliteConnection("Data Source=HS.db"))
            {
                connection.Open();                
                SqliteCommand sql = new SqliteCommand
                {
                    Connection = connection,
                    CommandText = "SELECT * FROM News"
                };
                SqliteDataReader reader = sql.ExecuteReader();
                while (reader.Read()) {
                    newsEditTextBox.Text = reader.GetString(0);
                }
                reader.Close();
                connection.Close();
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new SqliteConnection("Data Source=HS.db"))
                {
                    connection.Open();
                    SqliteCommand sql = new SqliteCommand
                    {
                        Connection = connection,
                        CommandText = "UPDATE News SET Text='" + newsEditTextBox.Text + "';"
                    };
                    sql.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Раздел новостей был обновлён", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainPage mainPage = new MainPage();
                this.Visible = false;
                mainPage.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка: " + ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            this.Close();
            MainPage mainPage = new MainPage();
            mainPage.ShowDialog();
        }
    }
}
