using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Electronic_Point_Of_Sales
{
    public partial class orderScreen : Form
    {
        public orderScreen()
        {
            InitializeComponent();
        }

        private void Button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string b = button.Text;

            //string text;
            //text = (numberTextBox.TextLength - 1).ToString();

            numberTextBox.ForeColor = Color.FromArgb(48, 59, 75);

            if (b == "Del")
            {
            
                if (numberTextBox.TextLength > 0)
                {
                    numberTextBox.Text = numberTextBox.Text.Substring(0, (numberTextBox.TextLength - 1));
                }
                else
                {
                    numberTextBox.Text = "00.00";
                }
            }

            else if (b == "Clr")
            {
                numberTextBox.Text = "00.00";
                numberTextBox.ForeColor = Color.Silver;
            }
            else if (b == "Return")
            {
                this.Hide();
                mainMenu staffLoginForm = new mainMenu();
                staffLoginForm.Show();
            }
            else if (numberTextBox.Text == "00.00")
            {
                numberTextBox.Clear();
                numberTextBox.Text += b;
            }

            else if (numberTextBox.TextLength >= 6)
            {
                MessageBox.Show("Max payout hit!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (numberTextBox.TextLength == 1)
            {
                numberTextBox.Text += '.';
                numberTextBox.Text += b;
            }

            else if (numberTextBox.TextLength == 4)
            {
                string strPara = numberTextBox.Text;
               
                numberTextBox.Text = strPara.Replace(".", string.Empty);
                numberTextBox.Text = numberTextBox.Text.Insert(2, ".");
                numberTextBox.Text += b;
            }

            else if (numberTextBox.TextLength == 5)
            {
                string strPara = numberTextBox.Text;

                numberTextBox.Text = strPara.Replace(".", string.Empty);
                numberTextBox.Text = numberTextBox.Text.Insert(3, ".");
                numberTextBox.Text += b;
            }
            //else if (numberTextBox.TextLength == 4)
            //{
            //
            //    //string input = numberTextBox.Text;
            //    //string new_input = input.Substring(0, 1) + numberTextBox.Text + input.Substring(2, input.Length);
            //
            //    var input = numberTextBox.Text.ToCharArray();
            //    input[1] = //THE USERS BUTTON TEXT;
            //
            //    var result = new string(input);
            //    numberTextBox.Text = result;
            //}


            else
            {
                numberTextBox.Text += b;
                
            }
        }

        private void Timer_tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("HH:mm");
            dateLabel.Text = DateTime.Now.ToString("HH:mm");
        }
    }
}
