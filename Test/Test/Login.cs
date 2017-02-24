using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static void hubThreadStart()
        {
            Hub main = new Hub();
            main.ShowDialog();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {

            //Connects to the Database
            string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
            MySqlConnection connection = new MySqlConnection(connectionString);

            string checkUsername = "Select count(*) FROM Login WHERE LoginID ='" + tbUsername.Text + "'";

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(checkUsername, connection);
                int temp = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                if (temp == 1)
                {
                    string checkPassword = "select Password from Login where LoginID='" + tbUsername.Text + "'";
                    MySqlCommand passwordCmd = new MySqlCommand(checkPassword, connection);
                    string password = passwordCmd.ExecuteScalar().ToString().Replace(" ", "");
                    if(password == tbPassword.Text)
                    {
                        ThreadStart hubRef = new ThreadStart(hubThreadStart);
                        Thread hubThread = new Thread(hubRef);
                        hubThread.Start();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password Incorrect");
                    }
                }
                else
                {
                    MessageBox.Show("Username or Password Incorrect");
                }
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message.ToString());
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
