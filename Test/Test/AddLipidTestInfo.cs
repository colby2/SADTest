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
    public partial class AddLipidTestInfo : Form
    {
        int PatientID = 3;//remove
        public AddLipidTestInfo()
        {
            InitializeComponent();
        }


        public AddLipidTestInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = ("MMM dd, yyyy");
        }

        private void addLipidInfobtn_Click(object sender, EventArgs e)
        {
            string str = cholesterolTb.Text.Trim();
            string str1 = HgA1ctb.Text.Trim();
            string str2 = HDLtb.Text.Trim();
            string str3 = LDLtb.Text.Trim();
            string str4 = trigylceridesTb.Text.Trim();

            double cholesterolCheck, hgCheck, HDLCheck, LDLCheck, triglyceridesCheck;

            bool ischolesterolCheck= double.TryParse(str, out cholesterolCheck);
            bool ishgCheck = double.TryParse(str, out hgCheck);
            bool isHDLCheck = double.TryParse(str, out HDLCheck);
            bool isLDLCheck = double.TryParse(str, out LDLCheck);
            bool isTRICheck = double.TryParse(str, out triglyceridesCheck);


            if (HgA1ctb.Text == "" || cholesterolTb.Text == "" || HDLtb.Text == "" || LDLtb.Text == "" || trigylceridesTb.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            if (ischolesterolCheck && ishgCheck && isHDLCheck && isLDLCheck && isTRICheck)
            {
                InsertFunctions.InsertIntoLipidTest(DateTime.Parse(dateTimePicker1.Text), double.Parse(HgA1ctb.Text), double.Parse(cholesterolTb.Text), double.Parse(HDLtb.Text), double.Parse(LDLtb.Text), double.Parse(trigylceridesTb.Text), PatientID);
                this.Close();
            }
            else
            {
                MessageBox.Show("Must add numerical values for: \n\n HgA1C \n Cholesterol \n HDL \n LDL \n Triglycerides \n", "Error");
            }
        }

        private void AddLipidTestInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
