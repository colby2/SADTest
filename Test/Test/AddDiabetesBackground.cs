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
    public partial class AddDiabetesBackground : Form
    {
        bool editing = false;

        int PatientID;
        public string editDateInfoTaken;
        public string editDateDiagnosed;
        public string editDiabetesType;

        public AddDiabetesBackground()
        {
            InitializeComponent();
        }

        public AddDiabetesBackground(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
            dateDiagnosed.Format = DateTimePickerFormat.Custom;
            dateDiagnosed.CustomFormat = ("MMM dd, yyyy");
            dateInfoTaken.Format = DateTimePickerFormat.Custom;
            dateInfoTaken.CustomFormat = ("MMM dd, yyyy");
        }

        public AddDiabetesBackground(int PatientID, string dateInfoTakenString, string dateDiagnosedString, string diabetesTypeString)
        {
            this.editing = true;

            this.PatientID = PatientID;
            this.editDateInfoTaken = dateInfoTakenString;
            this.editDateDiagnosed = dateDiagnosedString;
            this.editDiabetesType = diabetesTypeString;
            
            InitializeComponent();


            dateDiagnosedString = DateTime.ParseExact(dateDiagnosedString, "MMM dd, yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string[] yearMonthDay = dateDiagnosedString.Split('-');
            dateDiagnosed.Format = DateTimePickerFormat.Custom;
            dateDiagnosed.CustomFormat = "MMM dd, yyyy";
            dateDiagnosed.Value = new DateTime(int.Parse(yearMonthDay[0]), int.Parse(yearMonthDay[1]), int.Parse(yearMonthDay[2]));

            dateInfoTakenString = DateTime.ParseExact(dateInfoTakenString, "MMM dd, yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string[] yearMonthDay2 = dateInfoTakenString.Split('-');
            dateInfoTaken.Format = DateTimePickerFormat.Custom;
            dateInfoTaken.CustomFormat = "MMM dd, yyyy";
            dateInfoTaken.Value = new DateTime(int.Parse(yearMonthDay2[0]), int.Parse(yearMonthDay2[1]), int.Parse(yearMonthDay2[2]));


            diabetesType.Text = diabetesTypeString;

        }


        private void AddDiabetesBackground_Load(object sender, EventArgs e)
        {

        }

        private void addBackgroundInfobtn_Click(object sender, EventArgs e)
        {
            if (diabetesType.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            else if (editing == false)
            {
                string inserted = InsertFunctions.InsertIntoDiabetesBackground(dateInfoTaken.Text, dateDiagnosed.Text, diabetesType.Text, PatientID);
                MessageBox.Show(inserted);
                this.Close();
            }
            else if (editing == true)
            {
                UpdateFunctions.UpdateDiabetesBackgroundInfo(PatientID, dateInfoTaken.Text, dateDiagnosed.Text, diabetesType.Text, editDateInfoTaken, editDateDiagnosed, editDiabetesType);
                this.Close();
            }
        }

        private void dateDiagnosed_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
