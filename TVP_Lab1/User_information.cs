using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TVP_Lab1
{
    public partial class User_information : Form
    {
        string[] Users;
        string[] Names;
        string[] SecondNames;
        string[] Emails;
        int curUser;
        Form form1;

        public User_information(Form form, int User)
        {
            curUser = User;
            form1 = form;
            form1.Hide();

            InitializeComponent();

            Users = File.ReadAllLines("Accounts\\Users.txt");
            Names = File.ReadAllLines("Accounts\\Names.txt");
            SecondNames = File.ReadAllLines("Accounts\\SecondNames.txt");
            Emails = File.ReadAllLines("Accounts\\Emails.txt");

            groupBox1.Text = "Information on " + Users[curUser];
            textBox1.Text = Names[curUser];
            textBox2.Text = SecondNames[curUser];
            textBox3.Text = Emails[curUser];
        }

        private void User_information_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ReadOnly = !checkBox1.Checked;
            if (!checkBox1.Checked)
            {
                Names[curUser] = textBox1.Text;
                File.WriteAllLines("Accounts\\Names.txt", Names);
            }            
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            textBox2.ReadOnly = !checkBox2.Checked;
            if (!checkBox2.Checked)
            {
                SecondNames[curUser] = textBox2.Text;
                File.WriteAllLines("Accounts\\SecondNames.txt", SecondNames);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            textBox3.ReadOnly = !checkBox3.Checked;
            if (!checkBox3.Checked)
            {
                Emails[curUser] = textBox3.Text;
                File.WriteAllLines("Accounts\\Emails.txt", Emails);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            form1.Show();
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            form1.Close();
            this.Close();
        }
    }
}
