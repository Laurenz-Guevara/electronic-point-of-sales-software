using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AES;

namespace Electronic_Point_Of_Sales
{
    public partial class mainMenu : Form
    {
        

        public mainMenu()
        {
            InitializeComponent();
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            dateLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            timer.Start();
            string query = $"SELECT * FROM completetransactions";
            DisplayData(query);
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            idTextBox.Text = idTextBox.Text + button.Text;
        }

        private void ProcessClick(object sender, EventArgs e)
        {
            mySQLClass sqlFunction = new mySQLClass();
            string query;

            string encryptId = AESEncryption.encrypt(idTextBox.Text);

            Button button = (Button)sender;
            string b = button.Text;

            if (b == "Clear")
            {
                idTextBox.Clear();
            }

            else if (b == "Enter")
            {
                query = $"SELECT * FROM staffdata WHERE staffId='{idTextBox.Text}' AND clockType='1'";
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == true)
                {
                    this.Hide();
                    orderScreen orderScreen = new orderScreen();
                    orderScreen.Show();
                }
            }

            else if (b == "Clock In")
            {
                query = $"UPDATE staffdata SET clockType = '1' WHERE staffdata.staffId='{idTextBox.Text}'";
                sqlFunction.RunSQL(query);

            }

            else if (b == "Clock Out")
            {
                query = $"UPDATE staffdata SET clockType = '0' WHERE staffdata.staffId='{idTextBox.Text}'";
                sqlFunction.RunSQL(query);

            }
            else if (b == "Settings")
            {
                query = $"SELECT * FROM staffdata WHERE staffId='{idTextBox.Text}' AND permissionsLevel='1' AND clockType='1'";
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == true)
                {
                    this.Hide();
                    settingsScreen settingsScreen = new settingsScreen();
                    settingsScreen.Show();
                }

                else
                {
                    MessageBox.Show("Account doesn't exist, or you do not have sufficient privileges", "Access Denied", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
            }

            else if (b == "Log")
            {
                query = $"SELECT * FROM staffdata WHERE staffId='{idTextBox.Text}' AND clockType='1'";
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == true)
                {
                    this.Hide();
                    loginScreen loginScreenForm = new loginScreen();
                    loginScreenForm.Show();
                }
            }

            else if (b == "Search")
            {

                if (idTextBox.Text == "")
                {
                    query = $"SELECT * FROM completetransactions";
                    DisplayData(query);
                }
                else
                {
                    query = $"SELECT * FROM completetransactions WHERE id='{idTextBox.Text}'";
                    DisplayData(query);
                }

            }

            else if (b == "Return")
            {
                this.Hide();
                loginScreen loginScreenForm = new loginScreen();
                loginScreenForm.Show();
            }

        }
        
        private void DisplayData(string query)
        {

            MySqlConnection databaseConnection = new MySqlConnection(@"Server = laurenzguevara.co.uk;port=3306;Database=eposdatabase;User Id=eposclient;password=PKzyE7AmUfDSPLFrlAmcgB4NFWk8w9Ac");
            MySqlCommand cmd = new MySqlCommand(query, databaseConnection);

            try
            {
                databaseConnection.Open();
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                da.Fill(dt);
                
                dataDisplayTable.DataSource = dt;

                databaseConnection.Close();
            }
            catch (Exception)
            {

            }
        }
    }
}
