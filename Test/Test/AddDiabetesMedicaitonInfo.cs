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
    public partial class AddDiabetesMedicaitonInfo : Form
    {
        int PatientID;
        public AddDiabetesMedicaitonInfo()
        {
            InitializeComponent();
        }

        public AddDiabetesMedicaitonInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
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
            else
            {
                InsertFunctions.InsertIntoDiabetesMedication(medicationTb.Text, dateTimePicker1.Text, amountTb.Text, frequencyTb.Text, routeTb.Text, PatientID);
                this.Close();
            }
        }
    }
}
