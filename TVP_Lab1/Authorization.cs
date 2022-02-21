namespace TVP_Lab1
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
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
            new_User.ShowDialog();
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
            bool isUserExists = false;
            string fileUsers = "Accounts\\Users.txt";
            string filePasswords = "Accounts\\Passwords.txt";
            int idUser = -1, i = 0;

            IEnumerable<string> Users = File.ReadLines(fileUsers);
            IEnumerable<string> Passwords = File.ReadLines(filePasswords);  

            foreach(string User in Users)
            {
                if (User == textBoxUser.Text)
                {
                    idUser = i;
                    break;
                }
                i++;
            }
            if (idUser == -1)
            {

            }
            else
            {
                i = 0;
                foreach (string Password in Passwords)
                {
                    if (i == idUser)
                    {
                        if (Password == textBoxPassword.Text)
                        {
                            User_information user_Information = new User_information();
                            user_Information.ShowDialog();
                        }
                        else
                        {

                        }
                        break;
                    }
                }
            }
        }
    }
}