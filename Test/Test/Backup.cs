using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using DiabeticHealthDB;

namespace Test
{
    public partial class Backup : Form
    {
        public Backup()
        {
            InitializeComponent();
        }

        private void backupBtn_Click(object sender, EventArgs e)
        {
            
            string fileName = "C:\\DBBackup\\PatientDatabase.sql";
            if (!Directory.Exists("C:\\DBBackup")) {
                Directory.CreateDirectory("C:\\DBBackup");
            }

            if (File.Exists(fileName))
            {
                DialogResult confirmation = new DialogResult();
                confirmation = MessageBox.Show("A backup file already exists. Overwrite?", "ATTENTION", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {
                    using (MySqlConnection connection = DatabaseConnection.GetConnection())
                    {
                        using (MySqlCommand cmd = new MySqlCommand())
                        {
                            using (MySqlBackup backup = new MySqlBackup(cmd))
                            {
                                cmd.Connection = connection;
                                connection.Open();
                                backup.ExportToFile(fileName);
                                connection.Close();
                                Console.WriteLine("Got HERE!");
                            }
                        }
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = new DialogResult();
            confirmation = MessageBox.Show("Information may be lost if you have not recently backed up your database. Are you sure you wish to proceed?", "ATTENTION", MessageBoxButtons.YesNo);
            if (confirmation == DialogResult.Yes)
            {
                string fileName = "C:\\DBBackup\\PatientDatabase.sql";
                using (MySqlConnection connection = DatabaseConnection.GetConnection())
                {
                    using (MySqlCommand cmd = new MySqlCommand())
                    {
                        using (MySqlBackup restoreDB = new MySqlBackup(cmd))
                        {
                            cmd.Connection = connection;
                            connection.Open();
                            restoreDB.ImportFromFile(fileName);
                            connection.Close();
                        }
                    }
                }
            }
        }
    }
}
