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

        /********************************************************************************************
       * Constructor that accepts PatientID from the Patient form and allows us to use it here
       * ******************************************************************************************/
        public AddAllergyInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
        }

        private void AddAllergyInfo_Load(object sender, EventArgs e)
        {

        }
        /********************************************************************************************
       * Button Click that closes the current form and returns to the Patient form
       * ******************************************************************************************/
        private void closeForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /********************************************************************************************
       * Button Click that calls the insert function for allergies and adds new rows to the database
       * based upon the current patient. It then closes this form.
       * ******************************************************************************************/
        private void updateAllergyButton_Click(object sender, EventArgs e)
        {
            int insertedRows = InsertFunctions.InsertIntoAllergyInfo(PatientID, AllergicTo.Text, Reaction.Text);
            AllergicTo.Clear();
            Reaction.Clear();
            
        }
    }
}
