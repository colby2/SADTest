using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    }
                }
            }
        }
    }
}
