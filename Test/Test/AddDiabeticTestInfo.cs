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
    public partial class AddDiabeticTestInfo : Form
    {
        public AddDiabeticTestInfo()
        {
            InitializeComponent();
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
    }
}
