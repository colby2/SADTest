using MySql.Data.MySqlClient;
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

namespace Test
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        Thread[] allThreads = new Thread[100];
        int threadCount = 0;

        public static void graphThreadStart()
        {
            GraphTemplate graph = new GraphTemplate();
            graph.ShowDialog();
        }

        public static void patientThreadStart()
        {

            Patient patient = new Patient();
            patient.ShowDialog();
        }
        
       /* public static void patientThreadStart(string criteria)
        {
            Patient patient = new Patient(criteria);
            patient.ShowDialog();
        }//Thread Starter for patient with non-blank search*/

        public static void patientThreadStart(object data)
        {
            Patient patient = new Patient(data.ToString());
            patient.ShowDialog();
        }

         public static void loginThreadStart()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public static void insertPatientThreadStart()
        {
            InsertPatient insert = new InsertPatient();
            insert.ShowDialog();
        }

        private void bGraphs_Click(object sender, EventArgs e)
        {
           
           ThreadStart graphRef = new ThreadStart(graphThreadStart);
            allThreads[threadCount] = new Thread(graphRef);
            allThreads[threadCount].IsBackground = true;
            allThreads[threadCount].Start();
            threadCount++;
            //Thread graphThread = new Thread(graphRef);
            //graphThread.IsBackground = true;
            //graphThread.Start();
           
        }

        private void Hub_Load(object sender, EventArgs e)
        {

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            lvSearchList.Items.Clear();
            if (tbSearch.Text != "")
            {
                string searchInput = tbSearch.Text;

                string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
                MySqlConnection connection = new MySqlConnection(connectionString);

                
                connection.Open();
                string searchResults = "";
                if (cbFirstName.Checked == true && cbLastName.Checked == true && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName, ' ', LastName, ' ', DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == true && cbLastName.Checked == true && cbDOB.Checked == false)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName, ' ', LastName) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == true && cbLastName.Checked == false && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName, ' ', DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == true && cbLastName.Checked == false && cbDOB.Checked == false)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == true && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(LastName, ' ', DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == true && cbDOB.Checked == false)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(LastName) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == false && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == false && cbDOB.Checked == false) { goto End; /*redirects to End tag below*/ }


                MySqlCommand cmd = new MySqlCommand(searchResults, connection);
                MySqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    string[] row = {reader.GetString(1), reader.GetString(2), reader.GetString(8), reader.GetString(0)};
                    var listViewItem = new ListViewItem(row);
                    lvSearchList.Items.Add(listViewItem);
                }

                reader.Close();
                End:
                connection.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            //Will be redirected to a different form.
            ThreadStart patientRef = new ThreadStart(insertPatientThreadStart);
            allThreads[threadCount] = new Thread(patientRef);//Thread patientThread = new Thread(patientRef);
            allThreads[threadCount].IsBackground = true;//patientThread.IsBackground = true;
            allThreads[threadCount].Start(); //patientThread.Start();
            threadCount++;
        }


        private void bLogout_Click(object sender, EventArgs e)
        {
            ThreadStart loginRef = new ThreadStart(loginThreadStart);
            Thread loginThread = new Thread(loginRef);
            loginThread.Start();
            for(int i = 0; i< threadCount; i++)
            {
                allThreads[i].Abort();
            }
            this.Close();
        }


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSearchList.SelectedItems.Count == 1)
            {
                //Thread patientThread = new Thread(patientThreadStart);
                // patientThreadStart(lvSearchList.SelectedItems[0].SubItems[3].Text);
                ParameterizedThreadStart pat = new ParameterizedThreadStart(patientThreadStart);
                allThreads[threadCount] = new Thread(pat);
                allThreads[threadCount].IsBackground = true;
                allThreads[threadCount].Start(lvSearchList.SelectedItems[0].SubItems[3].Text);
                threadCount++;

            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
