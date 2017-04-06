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
            if (medicationTb.Text == "" || amountTb.Text == "" || frequencyTb.Text == "" || routeTb.Text == "" || dateTimePicker1.Text == "") ;
        }
    }
}
