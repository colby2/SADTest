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
    public partial class AddMedicationInfo : Form
    {
        public int PatientID;
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
            else
            {
                InsertFunctions.InsertIntoMedication(medicationTb.Text, dateTimePicker1.Text, amounttb.Text, frequencytb.Text, routeTb.Text, PatientID);
                this.Close();
            }
        }
    }
}
