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

            IEnumerable <string> Users = File.ReadLines(fileUsers);
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
                
            }
            else if (String.IsNullOrEmpty(textBox2.Text))
            {

            }
            else if (isUserExists)
            {
                
            }
            else if (textBox2.Text == textBox3.Text)
            {
                File.AppendAllText(fileUsers, textBox1.Text + "\n");
                File.AppendAllText(filePasswords, textBox2.Text + "\n");
                this.Close();
            }
            else
            {
                
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
