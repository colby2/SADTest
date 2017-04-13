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
    public partial class AddDiabetesBackground : Form
    {
        int PatientID;
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


        private void AddDiabetesBackground_Load(object sender, EventArgs e)
        {

        }

        private void addBackgroundInfobtn_Click(object sender, EventArgs e)
        {
            if(diabetesType.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            else
            {
                //InsertFunctions.InsertIntoDiabetesBackground(dateInfoTaken.Text, dateDiagnosed.Text, diabetesType.Text, PatientID);
            }
        }
    }
}
