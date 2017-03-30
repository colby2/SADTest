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
    public partial class InsertPatient : Form
    {
        public InsertPatient()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click(object sender, EventArgs e)
        {

        }

        private void insertButton_Click_1(object sender, EventArgs e)
        {
            if (dvtb.Text == "" || dvtb.Text == null)
            {
                MessageBox.Show("Something must be entered for Date of Last Visit. If patient is not applicable enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            int rowsInserted = InsertFunctions.InsertIntoDemographics(fnTb.Text, lnTB.Text, dvtb.Text, stb.Text, ctb.Text, sttb.Text, ztb.Text, dbtb.Text, ptb.Text, pitb.Text, sitb.Text, ntb.Text);
            this.Close();
        } 

 

        private void textbox_TextChanged(object sender, EventArgs e)
        {
            insertButton.Enabled = areControlsValid(this.Controls);
        }
        private void InsertPatient_Load(object sender, EventArgs e)
        {

        }

        private bool areControlsValid(Control.ControlCollection controls)
        {
            foreach (Control c in controls)
            {
                if (c is TextBox)
                {
                    if (string.IsNullOrEmpty(((TextBox)c).Text))
                        return false;
                }
                if (c.HasChildren)
                {
                    areControlsValid(c.Controls);
                }
            }
            return true;
        }
    }
}
