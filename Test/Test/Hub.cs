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
        
        public static void loginThreadStart()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public static void patientThreadStart(string criteria)
        {
            Patient patient = new Patient(criteria);
            patient.ShowDialog();
        }//Thread Starter for patient with non-blank search

        private void bGraphs_Click(object sender, EventArgs e)
        {
           
            ThreadStart graphRef = new ThreadStart(graphThreadStart);
            Thread graphThread = new Thread(graphRef);
            graphThread.Start();
           
        }

        private void Hub_Load(object sender, EventArgs e)
        {

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            lbSearchList.Items.Clear();
            string searchInput = tbSearch.Text;

            string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string searchResults = "SELECT * FROM Demographics WHERE CONCAT(PatientID, ' ', FirstName, ' ', LastName, ' ', DateofLastVisit, ' ', Street, ' ', City, ' ', State, ' ', Zip, ' ', DOB, ' ', Phone, ' ', PrimaryInsuranceProvider, ' ', SecondaryInsuranceProvider) LIKE '%" + searchInput +"%'";
            MySqlCommand cmd = new MySqlCommand(searchResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();


            String[] llSearch = new String[100];
            int counter = 0;
            while (reader.Read())
            {
                llSearch[counter] = reader.GetString(0) + " " + reader.GetString(1) + " " + reader.GetString(2) + " " + reader.GetString(3) + " " + reader.GetString(4) + " " + reader.GetString(5) + " " + reader.GetString(6) + " " + reader.GetString(7) + " " + reader.GetString(8) + " " + reader.GetString(9) + " " + reader.GetString(10) + " " + reader.GetString(11);
                lbSearchList.Items.Add(llSearch[counter]);
                counter++;
            }
            lbSearchList.Show();

            reader.Close();
            connection.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {

            ThreadStart patientRef = new ThreadStart(patientThreadStart);
            Thread patientThread = new Thread(patientRef);
            patientThread.Start();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Thread patientThread = new Thread(patientThreadStart);
            patientThreadStart(lbSearchList.SelectedItem.ToString());
        }

        private void bLogout_Click(object sender, EventArgs e)
        {
            ThreadStart loginRef = new ThreadStart(loginThreadStart);
            Thread loginThread = new Thread(loginRef);
            loginThread.Start();
            this.Close();
        }
    }
}
