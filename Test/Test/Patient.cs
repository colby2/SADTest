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
using DiabeticHealthDB;
namespace Test
{
    public partial class Patient : Form
    {

        string PatientId;//patientid will be passed to update function 
        string currentDate = DateTime.Now.ToString("dd/MM/yyyy");//holds full current date
        string monthName = "";//will hold the actual name of the month
        private string completeCurrentDate;//will hold complete current date 

        public Patient()
        {
            InitializeComponent();
            
        }
        
        

        /****************************************************************************************************
         * Search function that will connect to DB and perform a SELECT statement on the DB bringing back all 
         * the information that matches the users search criteria
         * **************************************************************************************************/
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
                PatientId = reader.GetString(0);
                tbFirstname.Text = reader.GetString(1);
                tbLastname.Text = reader.GetString(2);
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
            reader.Close();


            /****************************************************************************************
             * populates lvAllergyList
             * **************************************************************************************/
            string AllergyResults = "SELECT * FROM AllergyInfo WHERE PatientID = " + selectedID + ";";
            cmd = new MySqlCommand(AllergyResults, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));

                lvAllergyList.Items.Add(lv);
            }
            reader.Close();

            /****************************************************************************************
             * populates lvMedicationList
             * **************************************************************************************/
            string medicationResults = "SELECT * FROM Medication WHERE PatientID = " + selectedID + ";";
            cmd = new MySqlCommand(medicationResults, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                lv.SubItems.Add(reader.GetString(5));

                lvMedicationList.Items.Add(lv);
            }
            reader.Close();

            /****************************************************************************************
             * populates lvVitalsList
             * **************************************************************************************/
            string vitalsResults = "SELECT * FROM VitalsInformation WHERE PatientID = " + selectedID + ";";
            cmd = new MySqlCommand(vitalsResults, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                lv.SubItems.Add(reader.GetString(5));
                lv.SubItems.Add(reader.GetString(6));
                lv.SubItems.Add(reader.GetString(7));
                lv.SubItems.Add(reader.GetString(8));
                lv.SubItems.Add("BMI GOES HERE");
                lv.SubItems.Add(reader.GetString(9));

                lvVitalsList.Items.Add(lv);
            }
            reader.Close();


            /****************************************************************************************
             * populates lvDiabeticMedsList
             * **************************************************************************************/
            string DiabeticMedResults = "SELECT * FROM DiabetesMedication WHERE PatientID = " + selectedID + ";";
            cmd = new MySqlCommand(DiabeticMedResults, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                lv.SubItems.Add(reader.GetString(5));

                lvDiabeticMedsList.Items.Add(lv);
            }
            reader.Close();

            /****************************************************************************************
             * populates lvDiabeticMedsList
             * **************************************************************************************/
            string DiabeticTestResults = "SELECT * FROM DiabeticTests WHERE PatientID = " + selectedID + ";";
            cmd = new MySqlCommand(DiabeticTestResults, connection);
            reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                lv.SubItems.Add(reader.GetString(5));
                lv.SubItems.Add(reader.GetString(6));

                lvDiabeticTestList.Items.Add(lv);
            }
            reader.Close();

            connection.Close(); // close database connection




            string[] dateArray = currentDate.Split('/');//holds the current date in an array separated based on month, day and year
            string monthNumber = dateArray[1].ToString();//will grab the current month in number format
            string yearNumber = dateArray[2].ToString();//Holds current year
            string dayNumber = dateArray[0].ToString();//Holds current Day of week 
           /************************************************************************************************************
            * switch statement that will take month number and (ex: 03) and turn it into the month name (ex: March)
            * **********************************************************************************************************/
            switch (monthNumber)
            {
                case "01":
                    monthName = "Jan";
                    break;
                case "02":
                    monthName = "Feb";
                    break;
                case "03":
                    monthName = "Mar";
                    break;
                case "04":
                    monthName = "April";
                    break;
                case "05":
                    monthName = "May";
                    break;
                case "06":
                    monthName = "June";
                    break;
                case "07":
                    monthName = "July";
                    break;
                case "08":
                    monthName = "Aug";
                    break;
                case "09":
                    monthName = "Sept";
                    break;
                case "10":
                    monthName = "Oct";
                    break;
                case "11":
                    monthName = "Nov";
                    break;
                case "12":
                    monthName = "Dec";
                    break;
            }
            /*must be placed here after switch. Cannot be placed in visitDateUpdate button click function*/
            completeCurrentDate = monthName + " " + dayNumber + ", " + yearNumber;//holds complete current date in user specified format




        }
        /********************************************************************************************
         * button click for updating the date of last visit
         * ******************************************************************************************/
        private void visitDateUpdate_Click(object sender, EventArgs e)
        {
            
            int DateUpdated = UpdateFunctions.UpdateDateOfLastVisit(Int32.Parse(PatientId), completeCurrentDate);
            tbDateOfLastVisit.Text = completeCurrentDate;
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        /********************************************************************************************
         * Button Click that allows user to update patient demographic information
         * ******************************************************************************************/
        private void bEdit_Click(object sender, EventArgs e)
        {


            if (bEdit.Text == "Edit")
            {
                tbFirstname.ReadOnly = false;
                tbLastname.ReadOnly = false;
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
                tbFirstname.ReadOnly = true;
                tbLastname.ReadOnly = true;
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
                //need to fix to where if nothing is updated it doesnt output the Message box that says we have updated records for this patient
                int Updated = UpdateFunctions.UpdateDemographics(Int32.Parse(PatientId), tbFirstname.Text, tbLastname.Text, tbDateOfLastVisit.Text, tbStreet.Text, tbCity.Text, tbState.Text, tbZip.Text, tbDOB.Text, tbPhone.Text, tbPrimaryInsurance.Text, tbSecondaryInsurance.Text);
                if (Updated == 1)
                    MessageBox.Show("You Have Updated the Records for This Patient");
                else
                    MessageBox.Show("No Records Updated");
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

        private void bTrends_Click(object sender, EventArgs e)
        {

        }

        private void lvAllergyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
