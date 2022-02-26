
namespace TVP_Lab1
{
    public partial class Authorization : Form
    {
        string[] Users;
        string[] Passwords;
        string fileUsers = "Accounts\\Users.txt";
        string filePasswords = "Accounts\\Passwords.txt";


        public Authorization()
        {
            InitializeComponent();
            
            Users = File.ReadAllLines(fileUsers);
            Passwords = File.ReadAllLines(filePasswords);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //this.Close();
            New_user new_User = new New_user();
            DialogResult res = new_User.ShowDialog();
            if (res == DialogResult.OK)
            {
                Users = File.ReadAllLines(fileUsers);
                Passwords = File.ReadAllLines(filePasswords);
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool isUserExist = false;
            if (String.IsNullOrEmpty(textBoxUser.Text) || String.IsNullOrEmpty(textBoxPassword.Text))
            {
                toolStripStatusLabel1.Text = "Input your password and name";
                statusStrip1.Show();
            }
            else
            { 
                for (int i = 0; i < Users.Length; i++)
                {
                    if (Users[i] == textBoxUser.Text)
                    {
                        isUserExist = true;
                        if (Passwords[i] == textBoxPassword.Text)
                        {
                            statusStrip1.Hide();
                            User_information user_Information = new User_information(this, i);
                            user_Information.Show();
                        }
                        else
                        {
                            toolStripStatusLabel1.Text = "Wrong username or password";
                            statusStrip1.Show();
                        }
                        break;
                    }
                }

                if (!isUserExist)
                {
                    toolStripStatusLabel1.Text = "The user doesn't exist";
                    statusStrip1.Show();
                }
            }
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBoxPassword.PasswordChar = (char)0;
                checkBox1.Text = "Hide";
            }
            else
            {
                textBoxPassword.PasswordChar = '*';
                checkBox1.Text = "Show";

            }
        }
    }
}