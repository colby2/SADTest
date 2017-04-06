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
using MySql.Data.MySqlClient;

namespace Test
{
    public partial class AddAllergyInfo : Form
    {
        public int PatientID;
        public string editAllergicTo = "";
        public string editReaction = "";

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

        /*******************************************************************************************
         * Consctructor that accepts PatientID, as well as selected AllergicTo and Reaction
         */
         public AddAllergyInfo(int PatientID, string editAllergicTo, string editReaction)
        {
            this.PatientID = PatientID;
            this.editAllergicTo = editAllergicTo;
            this.editReaction = editReaction;

            InitializeComponent();

            AllergicTo.Text = editAllergicTo;
            Reaction.Text = editReaction;
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
                if (AllergicTo.Text == "" || Reaction.Text == "")
                {
                    MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                    return;
                }
            if (editAllergicTo == "" && editReaction == "")
            {
                int insertedRows = InsertFunctions.InsertIntoAllergyInfo(PatientID, AllergicTo.Text, Reaction.Text);
                AllergicTo.Clear();
                Reaction.Clear();
            }
            else if(editAllergicTo != "" && editReaction != "")
            {
                UpdateFunctions.UpdateAllergyInfo(PatientID, AllergicTo.Text, Reaction.Text, editAllergicTo, editReaction);
                AllergicTo.Clear();
                Reaction.Clear();
                this.Close();
            }
            
        }

        private void AllergicTo_TextChanged(object sender, EventArgs e)
        {

        }




    }
}
