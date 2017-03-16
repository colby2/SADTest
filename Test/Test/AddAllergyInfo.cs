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
    public partial class AddAllergyInfo : Form
    {
        public int PatientID;
        public AddAllergyInfo()
        {
            InitializeComponent();
        }
        public AddAllergyInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
        }

        private void AddAllergyInfo_Load(object sender, EventArgs e)
        {

        }

        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void updateAllergyButton_Click(object sender, EventArgs e)
        {
            int insertedRows = InsertFunctions.InsertIntoAllergyInfo(PatientID, AllergicTo.Text, Reaction.Text);
            this.Close();
        }
    }
}
