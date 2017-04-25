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
    public partial class AddDiabetesMedicaitonInfo : Form
    {
        int PatientID;

        bool editing = false;

        string medName;
        string dateTaken;
        string amount;
        string frequency;
        string route;

        public AddDiabetesMedicaitonInfo()
        {
            InitializeComponent();
        }

        public AddDiabetesMedicaitonInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM dd, yyyy";
        }

        public AddDiabetesMedicaitonInfo(int PatientID, string medName, string dateTaken, string amount,string frequency, string route)
        {
            this.editing = true;

            this.PatientID = PatientID;
            this.medName = medName;
            this.dateTaken = dateTaken;
            this.amount = amount;
            this.frequency = frequency;
            this.route = route;

            InitializeComponent();

            dateTaken = DateTime.ParseExact(dateTaken, "MMM dd, yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string[] yearMonthDay = dateTaken.Split('-');
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM dd, yyyy";
            dateTimePicker1.Value = new DateTime(int.Parse(yearMonthDay[0]), int.Parse(yearMonthDay[1]), int.Parse(yearMonthDay[2]));

            medicationTb.Text = medName;
            amountTb.Text = amount;
            frequencyTb.Text = frequency;
            routeTb.Text = route;



        }


        private void routeTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void addInfobtn_Click(object sender, EventArgs e)
        {
            if (medicationTb.Text == "" || amountTb.Text == "" || frequencyTb.Text == "" || routeTb.Text == "" || dateTimePicker1.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            else if(editing == false)
            {
                string inserted = InsertFunctions.InsertIntoDiabetesMedication(medicationTb.Text, dateTimePicker1.Text, amountTb.Text, frequencyTb.Text, routeTb.Text, PatientID);
                MessageBox.Show(inserted);
                this.Close();
            }
            else if(editing == true)
            {
                UpdateFunctions.UpdateDiabetesMedicationInfo(PatientID, medicationTb.Text, dateTimePicker1.Text, amountTb.Text, frequencyTb.Text, routeTb.Text, medName, dateTaken, amount, frequency ,route);
                this.Close();
            }
        }

        private void AddDiabetesMedicaitonInfo_Load(object sender, EventArgs e)
        {

        }

        private void amountTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
