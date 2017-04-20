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
using System.Globalization;

namespace Test
{
    public partial class AddMedicationInfo : Form
    {
        public int PatientID;
        public bool editing = false;
        public string editMedicationName = "";
        public string editDateStarted = "";
        public string editAmount = "";
        public string editFrequency = "";
        public string editRoute = "";

        public AddMedicationInfo()
        {
            InitializeComponent();
        }

        public AddMedicationInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM dd, yyyy";
        }

        public AddMedicationInfo(int PatientID, string editMedicationName, string editDateStarted, string editAmount, string editFrequency, string editRoute)
        {
            this.editing = true;

            this.PatientID = PatientID;
            this.editMedicationName = editMedicationName;
            this.editDateStarted = editDateStarted;
            this.editAmount = editAmount;
            this.editFrequency = editFrequency;
            this.editRoute = editRoute;

            InitializeComponent();

            editDateStarted = DateTime.ParseExact(editDateStarted, "MMM dd, yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string[] yearMonthDay = editDateStarted.Split('-');
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM dd, yyyy";
            dateTimePicker1.Value = new DateTime(int.Parse(yearMonthDay[0]), int.Parse(yearMonthDay[1]), int.Parse(yearMonthDay[2]));

            medicationTb.Text = editMedicationName;
            amounttb.Text = editAmount;
            frequencytb.Text = editFrequency;
            routeTb.Text = editRoute;

            

        }


        private void AddMedicationInfo_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (medicationTb.Text == "" || amounttb.Text == "" || frequencytb.Text == "" || routeTb.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            if (editing == false)
            {
                InsertFunctions.InsertIntoMedication(medicationTb.Text, dateTimePicker1.Text, amounttb.Text, frequencytb.Text, routeTb.Text, PatientID);
                this.Close();
            }
            else if (editing == true)
            {
                //UpdateFunctions.UpdateAllergyInfo(PatientID, AllergicTo.Text, Reaction.Text, editAllergicTo, editReaction);
                this.Close();
            }
        }

        private void amounttb_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
