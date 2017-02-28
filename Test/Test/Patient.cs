using MySql.Data.MySqlClient;
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
    public partial class Patient : Form
    {
        public Patient()
        {
            InitializeComponent();
        }

        public Patient(string criteria)
        {
            InitializeComponent();
            string selectedID = new String(criteria.TakeWhile(Char.IsDigit).ToArray());

            string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string searchResults = "SELECT * FROM Demographics WHERE PatientID='"+ selectedID+ "'";

            MySqlCommand cmd = new MySqlCommand(searchResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                tbPatientId.Text = reader.GetString(0);
                tbName.Text = reader.GetString(1) + reader.GetString(2);
                tbDateOfLastVisit.Text = reader.GetString(3);
                tbStreet.Text = reader.GetString(4);
                tbCity.Text = reader.GetString(5);
                tbState.Text = reader.GetString(6);
                tbZip.Text = reader.GetString(7);
                tbDOB.Text = reader.GetString(8);
                tbPhone.Text = reader.GetString(9);
                tbPrimaryInsurance.Text = reader.GetString(10);
                tbSecondaryInsurance.Text = reader.GetString(11);
            }
            connection.Close();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bEdit_Click(object sender, EventArgs e)
        {


            if (bEdit.Text == "Edit")
            {
                tbPatientId.ReadOnly = false;
                tbName.ReadOnly = false;
                tbDateOfLastVisit.ReadOnly = false;
                tbStreet.ReadOnly = false;
                tbCity.ReadOnly = false;
                tbState.ReadOnly = false;
                tbZip.ReadOnly = false;
                tbDOB.ReadOnly = false;
                tbPhone.ReadOnly = false;
                tbPrimaryInsurance.ReadOnly = false;
                tbSecondaryInsurance.ReadOnly = false;

                bEdit.Text = "Submit Changes";
            }
            else if (bEdit.Text == "Submit Changes")
            {
                tbPatientId.ReadOnly = true;
                tbName.ReadOnly = true;
                tbDateOfLastVisit.ReadOnly = true;
                tbStreet.ReadOnly = true;
                tbCity.ReadOnly = true;
                tbState.ReadOnly = true;
                tbZip.ReadOnly = true;
                tbDOB.ReadOnly = true;
                tbPhone.ReadOnly = true;
                tbPrimaryInsurance.ReadOnly = true;
                tbSecondaryInsurance.ReadOnly = true;

                //TODO: Pull information from text boxes here and update database.

                bEdit.Text = "Edit";
            }


        }

        private void tpDemographics_Click(object sender, EventArgs e)
        {

        }

        private void tbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbAge_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
