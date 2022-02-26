using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace TVP_Lab1
{
    public partial class New_user : Form
    {
        public New_user()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isUserExists = false;
            string fileUsers = "Accounts\\Users.txt";
            string filePasswords = "Accounts\\Passwords.txt";
            string fileNames = "Accounts\\Names.txt";
            string fileSecondNames = "Accounts\\SecondNames.txt";
            string fileEmails = "Accounts\\Emails.txt";

            string[] Users = File.ReadAllLines(fileUsers);
            foreach (string User in Users)
            {
                if (User == textBox1.Text)
                {
                    isUserExists = true;
                    break;
                }
            }
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                toolStripStatusLabel1.Text = "Input username";
                statusStrip1.Show();
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {
                toolStripStatusLabel1.Text = "Input password";
                statusStrip1.Show();
            }
            else if (isUserExists)
            {
                toolStripStatusLabel1.Text = "A user with this name already exists";
                statusStrip1.Show();
            }
            else if (textBox2.Text == textBox3.Text)
            {
                File.AppendAllText(fileUsers, textBox1.Text + "\n");
                File.AppendAllText(filePasswords, textBox2.Text + "\n");
                File.AppendAllText (fileNames, "InputName\n");
                File.AppendAllText(fileSecondNames, "InputSecondName\n");
                File.AppendAllText(fileEmails, "InputEmail\n");
                DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                toolStripStatusLabel1.Text = "Passwords don't match";
                statusStrip1.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox2.PasswordChar = (char)0;
                textBox3.PasswordChar = (char)0;
                checkBox1.Text = "Hide";
            }
            else
            {
                textBox2.PasswordChar = '*';
                textBox3.PasswordChar = '*';
                checkBox1.Text = "Show";

            }
        }
    }
}
