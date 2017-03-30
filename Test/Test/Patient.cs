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
using DiabeticHealthDB;
namespace Test
{
    public partial class Patient : Form
    {

        string PatientId;//patientid will be passed to update function 
        string currentDate = DateTime.Now.ToString("dd/MM/yyyy");//holds full current date
        string monthName = "";//will hold the actual name of the month
        private string completeCurrentDate;//will hold complete current date 
        string selectedID;
        string connectionString;
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
             selectedID = new String(criteria.TakeWhile(Char.IsDigit).ToArray());

            connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();

            string searchResults = "SELECT * FROM Demographics WHERE PatientID='" + selectedID + "'";

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
                tbNotes.Text = reader.GetString(12);
            }
            reader.Close();
            connection.Close(); // close database connection




      /****************************************************************************************
        * Function call to populate lvAllergyList
        * **************************************************************************************/
           InsertIntoAllergylv();

       /****************************************************************************************
        * lvMedicationList
        * **************************************************************************************/
           InsertIntoMedicationlv();

      /****************************************************************************************
        * lvVitalsList
        * **************************************************************************************/
          InsertIntoVitalslv();

      /****************************************************************************************
        * populates lvDiabeticMedsList
        * **************************************************************************************/
          InsertIntoDiabeticMedslv();

      /****************************************************************************************
        * populates lvDiabetictests list
        * **************************************************************************************/
          InsertIntoDiabeticTestslv();

       /****************************************************************************************
         * populates lvLipidTestList
         * **************************************************************************************/
          InsertIntoLipidTestslv();

       /****************************************************************************************
         * populates lvDiabeticBackground
         * **************************************************************************************/
          InsertIntoDiabeticBackgroundlv();








           


    }
        /********************************************************************************************
         * button click for updating the date of last visit
         * ******************************************************************************************/
        private void visitDateUpdate_Click(object sender, EventArgs e)
        {
            
            int DateUpdated = UpdateFunctions.UpdateDateOfLastVisit(Int32.Parse(PatientId), getCurrentDate());
            tbDateOfLastVisit.Text = getCurrentDate();
        }

        private void label8_Click(object sender, EventArgs e)
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

        Thread[] allThreads = new Thread[100];
        int threadCount = 0;
        //todo: add link to graphs
        private void bTrends_Click(object sender, EventArgs e)
        {
            ParameterizedThreadStart pat = new ParameterizedThreadStart(graphThreadStart);
            allThreads[threadCount] = new Thread(pat);
            allThreads[threadCount].IsBackground = true;
            allThreads[threadCount].Start(selectedID);
        }

        private void Patient_FormClosing(Object Sender, FormClosedEventHandler e)
        {
            for (int i = 0; i < threadCount; i++)
            {
                allThreads[i].Abort();
            }
            this.Close();
        }

        public static void graphThreadStart(object uniqueID)
        {
            GraphTemplate graph = new GraphTemplate(uniqueID.ToString());
            graph.ShowDialog();
        }

        private void lvAllergyList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Patient_Load(object sender, EventArgs e)
        {

        }

        /********************************************************************************************
       * Button Click that opens notes tab on Patient form
       * ******************************************************************************************/
        private void button1_Click(object sender, EventArgs e)
        {
            tcPatient.SelectTab("tpNotes");
            string searchResults = "SELECT * FROM Demographics WHERE PatientID='" + selectedID + "'";
            
        }

        /********************************************************************************************
       * Button Click that opens new form for user to insert notes for the current patient
       * ******************************************************************************************/
        private void button2_Click(object sender, EventArgs e)
        {
            if (addNotes.Text.Contains("Edit"))
            {
                tbNotes.ReadOnly = false;

                addNotes.Text = "Submit Addition";
            }
            else if(addNotes.Text.Contains("Submit"))
            {
                tbNotes.ReadOnly = true;
                UpdateFunctions.UpdateNotes(Int32.Parse(PatientId), tbNotes.Text);
                addNotes.Text = "Edit Notes for This Patient";
            }
            
           
            
        }

        /********************************************************************************************
       * Button Click that allows user to delete a user from the database. Calls the delete funciton
       * for demographics and asks for confirmation before deleteing. 
       * ******************************************************************************************/
        private void bDelete_Click(object sender, EventArgs e)
        {
            DialogResult confirmation = new DialogResult();
            confirmation = MessageBox.Show("WARNING: You are about to delete Patient Information. Click OK to continue", "ATTENTION: PLEASE READ", MessageBoxButtons.OKCancel);
            if (confirmation == DialogResult.OK)
            {
                int deletedRows = DeleteFunctions.DeletePatient(Int32.Parse(PatientId));
                MessageBox.Show("Patient Information Deleted");
                this.Close();

            }
            else if (confirmation == DialogResult.Cancel)
            {
                MessageBox.Show("Patient NOT Deleted", "", MessageBoxButtons.OK);

            }
        }

        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        /********************************************************************************************
       * Button Click that opens new form from which user can add Allergy Info for the current patient
       * ******************************************************************************************/
        private void addAllergyButton_Click(object sender, EventArgs e)
        {
            AddAllergyInfo addAllergyForm = new AddAllergyInfo(Int32.Parse(PatientId));
            addAllergyForm.ShowDialog();
            
        }
        /********************************************************************************************
      * Button Click that refreshes
      * ******************************************************************************************/
        private void refreshButtonAllergy_Click_1(object sender, EventArgs e)
        {
            RefreshListViews();
        }

        /*****************************************************************************************
         * Function that refreshed all list views
         * ***************************************************************************************/
        public void RefreshListViews()
        {
            if (tcPatient.SelectedTab == tcPatient.TabPages["tpAllergies"])
            {
                lvAllergyList.Items.Clear();
                InsertIntoAllergylv();
                lvAllergyList.Refresh();
            }
            else if (tcPatient.SelectedTab == tcPatient.TabPages["tpMedication"])
            {
                lvMedicationList.Items.Clear();
                InsertIntoMedicationlv();
                lvMedicationList.Refresh();
            }
            else if (tcPatient.SelectedTab == tcPatient.TabPages["tpVitals"])
            {
                lvVitalsList.Items.Clear();
                InsertIntoVitalslv();
                lvVitalsList.Refresh();
            }
            else if (tcPatient.SelectedTab == tcPatient.TabPages["tpDiabeticMeds"])
            {
                lvDiabeticMedsList.Items.Clear();
                InsertIntoDiabeticMedslv();
                lvDiabeticMedsList.Refresh();

            }
            else if (tcPatient.SelectedTab == tcPatient.TabPages["tpDiabeticTest"])
            {
                lvDiabeticTestList.Items.Clear();
                InsertIntoDiabeticTestslv();
                lvDiabeticMedsList.Refresh();
            }
            else if (tcPatient.SelectedTab == tcPatient.TabPages["tpLipidTest"])
            {
                lvLipidTestList.Items.Clear();
                InsertIntoLipidTestslv();
                lvLipidTestList.Refresh();
            }
            else if (tcPatient.SelectedTab == tcPatient.TabPages["tpDiabeticBackground"])
            {
                lvDiabeticBackgroundList.Items.Clear();
                InsertIntoDiabeticBackgroundlv();
                lvDiabeticBackgroundList.Refresh();
            }
        }

        /****************************************************************************************
      * Function that populates the allergy list view
      * **************************************************************************************/
        public void InsertIntoAllergylv()
        {
         
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string AllergyResults = "SELECT * FROM AllergyInfo WHERE PatientID = " + selectedID + ";";
            MySqlCommand cmd = new MySqlCommand(AllergyResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));

                lvAllergyList.Items.Add(lv);

            }
            reader.Close();

        }
        /****************************************************************************************
        * Function that populates the medication list view
        * **************************************************************************************/
        public void InsertIntoMedicationlv()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string medicationResults = "SELECT * FROM Medication WHERE PatientID = " + selectedID + ";";
            MySqlCommand cmd = new MySqlCommand(medicationResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

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
        }
        /****************************************************************************************
        * Function that populates the vitals list view
        * **************************************************************************************/
        public void InsertIntoVitalslv()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string vitalsResults = "SELECT * FROM VitalsInformation WHERE PatientID = " + selectedID + ";";
            MySqlCommand cmd = new MySqlCommand(vitalsResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToDateTime(reader.GetString(1)).ToString("MMM dd, yyyy"));
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
        }

        /****************************************************************************************
       * Function that populates the Diabetic Meds list view
       * **************************************************************************************/
       public void InsertIntoDiabeticMedslv()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string DiabeticMedResults = "SELECT * FROM DiabetesMedication WHERE PatientID = " + selectedID + ";";
            MySqlCommand cmd = new MySqlCommand(DiabeticMedResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

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

        }

        /****************************************************************************************
     * Function that populates the Diabetic Tests list view
     * **************************************************************************************/
        public void InsertIntoDiabeticTestslv()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string DiabeticTestResults = "SELECT * FROM DiabeticTests WHERE PatientID = " + selectedID + ";";
            MySqlCommand cmd = new MySqlCommand(DiabeticTestResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

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
        }

        /****************************************************************************************
      * Function that populates the Lipid Tests list view
      * **************************************************************************************/
        public void InsertIntoLipidTestslv()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string LipidTestResults = "SELECT * FROM LipidTestInformation WHERE PatientID = " + selectedID + ";";
            MySqlCommand cmd = new MySqlCommand(LipidTestResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToDateTime(reader.GetString(1)).ToString("MMM dd, yyyy"));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));
                lv.SubItems.Add(reader.GetString(4));
                lv.SubItems.Add(reader.GetString(5));
                lv.SubItems.Add(reader.GetString(6));
                lv.SubItems.Add("ADD THIS LATER!");

                lvLipidTestList.Items.Add(lv);
            }
            reader.Close();
        }

       /****************************************************************************************
      * Function that populates the Lipid Tests list view
      * **************************************************************************************/
        public void InsertIntoDiabeticBackgroundlv()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);

            connection.Open();
            string DiabeticBackgroundResults = "SELECT * FROM DiabetesBackground WHERE PatientID = " + selectedID + ";";
            MySqlCommand cmd = new MySqlCommand(DiabeticBackgroundResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                ListViewItem lv = new ListViewItem(reader.GetString(1));
                lv.SubItems.Add(reader.GetString(2));
                lv.SubItems.Add(reader.GetString(3));

                lvDiabeticBackgroundList.Items.Add(lv);
            }
            reader.Close();
        }

        public string getCurrentDate()
        {
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
            return completeCurrentDate;
        }

        private void deleteSelectedRow_Click(object sender, EventArgs e)
        {
            if (lvAllergyList.SelectedItems.Count == 1) {
                string allergicTo = lvAllergyList.SelectedItems[0].SubItems[0].Text;
                string reaction = lvAllergyList.SelectedItems[0].SubItems[1].Text;

                connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
                MySqlConnection connection = new MySqlConnection(connectionString);

                connection.Open();
                string deleteRow = "DELETE FROM AllergyInfo WHERE PatientID = " + selectedID + " AND AllergicTo = '" + allergicTo +"' AND Reaction = '"+ reaction +"';";
                MySqlCommand cmd = new MySqlCommand(deleteRow, connection);
                cmd.ExecuteNonQuery();
                connection.Close();

                RefreshListViews();

            }
        }
    }
}

