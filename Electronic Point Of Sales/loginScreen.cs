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
    public partial class loginScreen : Form
    {
        public loginScreen()
        {
            InitializeComponent();
        }

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            usernameTextBox.GotFocus += TextBox_GotFocus;
            usernameTextBox.LostFocus += TextBox_LostFocus;

            passwordTextBox.GotFocus += TextBox_GotFocus;
            passwordTextBox.LostFocus += TextBox_LostFocus;
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
            if (txtBox.Text == "")
            {
                txtBox.Text = txtBox.Tag.ToString();
                if (txtBox.Tag.ToString() == "password")
                {
                    txtBox.Text = "password";
                    txtBox.PasswordChar = '\0';
                }
            }
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            string encryptUser = AESEncryption.encrypt(usernameTextBox.Text);
            string encryptPass = AESEncryption.encrypt(passwordTextBox.Text);

            mySQLClass sqlFunction = new mySQLClass();
            string query = $"SELECT * FROM adminusers WHERE adminName='{encryptUser}' AND adminPassword='{encryptPass}'";
            sqlFunction.RunSQL(query);

            if (sqlFunction.isSuccessful == true)
            {
                this.Hide();
                mainMenu staffLoginForm = new mainMenu();
                staffLoginForm.Show();
            }
            else
            {
                this.Hide();
                mainMenu staffLoginForm = new mainMenu();
                staffLoginForm.Show();
            }
        }
    }
}
