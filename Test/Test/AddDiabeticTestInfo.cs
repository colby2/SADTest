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
    public partial class AddDiabeticTestInfo : Form
    {
        int PatientID;

        bool editing = false;

        string dateOfTest;
        string microalbiumin;
        string footCheck;
        string currentYearVaccination;
        string diabeticEyeExam;
        string nutritionalCounseling;


        public AddDiabeticTestInfo()
        {
            InitializeComponent();
        }

        public AddDiabeticTestInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
            datetestTaken.Format = DateTimePickerFormat.Custom;
            datetestTaken.CustomFormat = ("MMM dd, yyyy");
        }

        public AddDiabeticTestInfo(int PatientID, string dateOfTest, string microalbiumin, string footCheck, string currentYearVaccination, string diabeticEyeExam, string nutritionalCounseling)
        {
            this.editing = true;

            this.PatientID = PatientID;
            this.dateOfTest = dateOfTest;
            this.microalbiumin = microalbiumin;
            this.footCheck = footCheck;
            this.currentYearVaccination = currentYearVaccination;
            this.diabeticEyeExam = diabeticEyeExam;
            this.nutritionalCounseling = nutritionalCounseling;

            InitializeComponent();


            dateOfTest = DateTime.ParseExact(dateOfTest, "MMM dd, yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string[] yearMonthDay = dateOfTest.Split('-');
            datetestTaken.Format = DateTimePickerFormat.Custom;
            datetestTaken.CustomFormat = "MMM dd, yyyy";
            datetestTaken.Value = new DateTime(int.Parse(yearMonthDay[0]), int.Parse(yearMonthDay[1]), int.Parse(yearMonthDay[2]));

            microalbumintb.Text = microalbiumin;
            footchecktb.Text = footCheck;
            cyvtb.Text = currentYearVaccination;
            eyeexamtb.Text = diabeticEyeExam;
            counselingtb.Text = nutritionalCounseling;


        }


        private void addDiabeticTestbtn_Click(object sender, EventArgs e)
        {
            if(microalbumintb.Text == "" || footchecktb.Text == "" || cyvtb.Text == "" || eyeexamtb.Text == "" || counselingtb.Text == "" || datetestTaken.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }

            else
            {
                //InsertFunctions.InsertIntoDiabeticTests(datetestTaken.Text, microalbumintb.Text, footchecktb.Text, cyvtb.Text, eyeexamtb.Text, counselingtb.Text, PatientID);
            }
        }

        private void AddDiabeticTestInfo_Load(object sender, EventArgs e)
        {

        }

        private void datetestTaken_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
