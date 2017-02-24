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
            //Pull patient that matches the criteria from the Search bar on the Hub


            //Use information to populate text boxes

        }

        public Patient(string criteria)
        {
            InitializeComponent();
            tbName.Text = criteria;//replace with search function, or a search textbox.
        }

        public Patient(int PatientID)
        {
            InitializeComponent();
            //retreive information based on PatientID Here. TO DO.
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
                tbAge.ReadOnly = false;
                tbPhone.ReadOnly = false;
                tbPrimaryInsurance.ReadOnly = false;
                tbSecondaryInsurance.ReadOnly = false;
                tbInsuranceInfoId.ReadOnly = false;

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
                tbAge.ReadOnly = true;
                tbPhone.ReadOnly = true;
                tbPrimaryInsurance.ReadOnly = true;
                tbSecondaryInsurance.ReadOnly = true;
                tbInsuranceInfoId.ReadOnly = true;

                //TODO: Pull information from text boxes here and update database.

                bEdit.Text = "Edit";
            }


        }

        private void tpDemographics_Click(object sender, EventArgs e)
        {

        }
    }
}
