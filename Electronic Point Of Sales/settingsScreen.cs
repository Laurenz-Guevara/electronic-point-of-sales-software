using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AES;

namespace Electronic_Point_Of_Sales
{
    public partial class settingsScreen : Form
    {
        public settingsScreen()
        {
            InitializeComponent();
        }

        private void SettingsScreen_Load(object sender, EventArgs e)
        {
            idTextBox.GotFocus += TextBox_GotFocus;
            idTextBox.LostFocus += TextBox_LostFocus;
            usernameTextBox.GotFocus += TextBox_GotFocus;
            usernameTextBox.LostFocus += TextBox_LostFocus;
            passwordTextBox.GotFocus += TextBox_GotFocus;
            passwordTextBox.LostFocus += TextBox_LostFocus;
            lastnameTextBox.GotFocus += TextBox_GotFocus;
            lastnameTextBox.LostFocus += TextBox_LostFocus;
            permissionsTextBox.GotFocus += TextBox_GotFocus;
            permissionsTextBox.LostFocus += TextBox_LostFocus;
            
            userLookUpID.GotFocus += TextBox_GotFocus;
            userLookUpID.LostFocus += TextBox_LostFocus;
            userLookUpFirstName.GotFocus += TextBox_GotFocus;
            userLookUpFirstName.LostFocus += TextBox_LostFocus;
            userLookUpLastName.GotFocus += TextBox_GotFocus;
            userLookUpLastName.LostFocus += TextBox_LostFocus;
            userLookUpClockType.GotFocus += TextBox_GotFocus;
            userLookUpClockType.LostFocus += TextBox_LostFocus;
            userLookUpPermissions.GotFocus += TextBox_GotFocus;
            userLookUpPermissions.LostFocus += TextBox_LostFocus;

        }

        private void Timer_tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            dateLabel.Text = DateTime.Now.ToString("HH:mm");
        }

        private void TextBox_GotFocus(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            txtBox.Clear();

            if (txtBox.Tag.ToString() == "password")
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void TextBox_LostFocus(object sender, EventArgs e)
        {
            TextBox txtBox = (TextBox)sender;
            if (txtBox.Text == ""){
                txtBox.Text = txtBox.Tag.ToString();
                if (txtBox.Tag.ToString() == "password")
                {
                    txtBox.Text = "password";
                    txtBox.PasswordChar = '\0';
                }
            }
        }

        private void ProcessClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string b = button.Text;

            mySQLClass sqlFunction = new mySQLClass();
            string query;

            string encryptUser = AESEncryption.encrypt(usernameTextBox.Text);
            string encryptLast = AESEncryption.encrypt(lastnameTextBox.Text);
            string encryptPass = AESEncryption.encrypt(passwordTextBox.Text);


            if (b == "Delete" && showNextForm.Text == "Show Admin Form") //If button clicked was "Delete" and the switch form button is "Show Admin Form"
            {
                query = $"SELECT * FROM staffdata WHERE staffId='{idTextBox.Text}'"; //Ask database if the ID exists
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == false) //ID doesn't exist
                {
                    MessageBox.Show("Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (MessageBox.Show("Warning this will delete any data about the user.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) //If they hit the Ok button then execute below
                {
                    query = $"DELETE FROM staffdata WHERE staffId='{idTextBox.Text}'"; //Ask database to delete the ID the user entered
                    sqlFunction.RunSQL(query);
                    MessageBox.Show("Entry successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }

            }

            else if (b == "Register" && showNextForm.Text == "Show Admin Form") //If button clicked was "Register" and the switch form button is "Show Admin Form"

            {
                if (passwordTextBox.Text.Length < 1) //Check that password length is bigger than one
                {
                    MessageBox.Show("Please have a minimum of 1 character", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); //Return message if not
                }
                else if (passwordTextBox.Text.Length >= 1) //Checks if password is longer than or equal to 1
                {
                    query = $"SELECT * FROM staffdata WHERE staffId='{idTextBox.Text}'"; //Checks if entry already exists
                    sqlFunction.RunSQL(query);
                    if (sqlFunction.isSuccessful == true)
                    {
                        MessageBox.Show("Id Is in current use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    }
                    else if (sqlFunction.isSuccessful == false) //If ID doesn't exist
                    {

                        query = $"INSERT INTO staffdata (staffId, staffFirstName, staffLastName, staffPassword, clockType, permissionsLevel) VALUES ('{idTextBox.Text}', '{encryptUser}', '{encryptLast}', '{encryptPass}', '0', '{permissionsTextBox.Text}')";
                        sqlFunction.RunSQL(query);

                        query = $"SELECT * FROM staffdata WHERE staffId='{idTextBox.Text}'"; //Checks if entry went through
                        sqlFunction.RunSQL(query);

                        if (sqlFunction.isSuccessful == true)
                        {
                            MessageBox.Show("Entry successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }

                }
            }

            else if (b == "Edit Staff Account" && showNextForm.Text == "Show Admin Form")
            {
                query = $"SELECT * FROM staffdata WHERE staffId='{idTextBox.Text}'";
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == true)
                {

                    query = $"UPDATE staffdata SET staffFirstName = '{encryptUser}',staffLastName = '{encryptLast}',staffPassword = '{encryptPass}',clockType = '0',permissionsLevel = '{permissionsTextBox.Text}' WHERE staffdata.staffId = {idTextBox.Text}";
                    sqlFunction.RunSQL(query);
                    MessageBox.Show("Data was updated!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else if (b == "Delete" && showNextForm.Text == "Show Staff Form")
            {
                query = $"SELECT * FROM adminusers WHERE adminId='{idTextBox.Text}'";
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == false)
                {
                    MessageBox.Show("Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                else if (MessageBox.Show("Warning this will delete any data about the user.", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                {
                    query = $"DELETE FROM adminusers WHERE adminId='{idTextBox.Text}'";
                    sqlFunction.RunSQL(query);
                    MessageBox.Show("Entry successfully deleted", "Success", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }

            else if (b == "Register" && showNextForm.Text == "Show Staff Form")
            {
                query = $"SELECT * FROM adminusers WHERE adminId='{idTextBox.Text}'";
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == true)
                {
                    MessageBox.Show("Id Is in current use.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                {
                    query = $"INSERT INTO adminusers (adminId, adminName, adminPassword) VALUES ('{idTextBox.Text}', '{encryptUser}', '{encryptPass}')";
                    sqlFunction.RunSQL(query);

                    query = $"SELECT * FROM adminusers WHERE adminId='{idTextBox.Text}'"; //Checks if entry went through
                    sqlFunction.RunSQL(query);

                    if (sqlFunction.isSuccessful == true)
                    {
                        MessageBox.Show("Entry successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }

            else if (b == "Show Admin Form")
            {

                lastnameTextBox.Hide();
                permissionsTextBox.Hide();

                deleteButton.Location = new Point(12, 243);
                registerButton.Location = new Point(156, 243);
                editStaffButton.Location = new Point(12, 296);
                showNextForm.Location = new Point(12, 349);

                showNextForm.Text = "Show Staff Form";
            }
            else if (b == "Show Staff Form")
            {

                lastnameTextBox.Show();
                permissionsTextBox.Show();

                deleteButton.Location = new Point(12, 313);
                registerButton.Location = new Point(156, 313);
                editStaffButton.Location = new Point(12, 366);
                showNextForm.Location = new Point(12, 419);
                showNextForm.Text = "Show Admin Form";
            }

            else if (b == "Lookup Account")
            {
                query = $"SELECT * FROM staffdata WHERE staffId='{userLookUpID.Text}'";
                sqlFunction.LookupUser(query);

                if (sqlFunction.isSuccessful == true)
                {
                    query = $"SELECT * FROM staffdata WHERE staffId='{userLookUpID.Text}'";

                    string decryptUser = AESEncryption.decrypt(sqlFunction.firstName);
                    string decryptLast = AESEncryption.decrypt(sqlFunction.lastName);

                    userLookUpFirstName.Text = decryptUser;
                    userLookUpLastName.Text = decryptLast;

                    if (sqlFunction.clockType == "1")
                    {
                        userLookUpClockType.Text = "Clocked In";
                    }
                    else
                    {
                        userLookUpClockType.Text = "Clocked Out";
                    }

                    userLookUpPermissions.Text = sqlFunction.permissionsLevel;

                }

                else
                {
                    MessageBox.Show("Id does not exist!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else if (b == "Clockout All Users")
            {
                query = $"UPDATE staffdata SET clockType = '0'";
                sqlFunction.RunSQL(query);

                query = $"SELECT * FROM staffdata WHERE clockType='1'"; //Checks if entry went through
                sqlFunction.RunSQL(query);

                if (sqlFunction.isSuccessful == false)
                {
                    MessageBox.Show("All users clocked out!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Request did not go through.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }

            else if (b == "Return To Previous Form")
            {
                this.Hide();
                mainMenu staffLoginForm = new mainMenu();
                staffLoginForm.Show();
            }
        }

        private void TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char character = e.KeyChar;

            if (!Char.IsDigit(character) && character != 8)
            {
                e.Handled = true;
                MessageBox.Show("Please only enter numbers!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
