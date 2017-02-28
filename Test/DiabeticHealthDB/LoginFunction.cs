using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MysqlClient

namespace DiabeticHealthDB
{
    public static class LoginFunction
    {
        public static int LoginCheck(string LoginID, string Password)
        {

            string checkUsername = "Select count(*) FROM Login WHERE LoginID ='" + LoginID + "'";
            MySqlConnection connection = DatabaseConnection.GetConnection();

            try
            {
                connection.Open();
                MySqlCommand cmd = new MySqlCommand(checkUsername, connection);
                int userNameCount = Convert.ToInt32(cmd.ExecuteScalar().ToString());

                if (userNameCount == 1)
                {
                    string checkPassword = "select Password from Login where LoginID='" + LoginID + "'";
                    MySqlCommand passwordCmd = new MySqlCommand(checkPassword, connection);
                    string userPassword = passwordCmd.ExecuteScalar().ToString().Replace(" ", "");
                    if (userPassword == Password)
                    {
                        return 1;
                    }
                    else
                    {
                        //MessageBox.Show("Username or Password Incorrect");
                        connection.Close();
                        return 2;
                    }
                }
                else
                {
                    //MessageBox.Show("Username or Password Incorrect");
                    connection.Close();
                    return 3;
                }

            }
            catch (Exception ex)
            {
                /*add out parameter to send info back to main for message box*/
                //MessageBox.Show("ERROR: " + ex.Message.ToString());
                connection.Close();
                //throw ex;
                return 4;

            }
        }
        }
    }
