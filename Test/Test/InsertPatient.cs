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
            if (dvtb.Text == "" || fnTb.Text == "" || lnTB.Text == "" || gtb.Text == "" || ptb.Text == "" || stb.Text == "" || sttb.Text == "" || ctb.Text == "" || ztb.Text == "" || dbtb.Text == "" || pitb.Text == "" || sitb.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            int rowsInserted = InsertFunctions.InsertIntoDemographics(fnTb.Text, lnTB.Text, gtb.Text, dvtb.Text, stb.Text, ctb.Text, sttb.Text, ztb.Text, dbtb.Text, ptb.Text, pitb.Text, sitb.Text, ntb.Text);
            this.Close();
            
        }

        private void currentDatebt_Click(object sender, EventArgs e)
        {
            Patient p = new Patient();
            dvtb.Text = p.getCurrentDate();
        }

        private void InsertPatient_Load(object sender, EventArgs e)
        {

        }
    }
}
    

        //private void InsertPatient_Load(object sender, EventArgs e)
        //{

        //}

        //private bool areControlsValid(Control.ControlCollection controls)
        //{
        //    foreach (Control c in controls)
        //    {
        //        if (c is TextBox)
        //        {
        //            if (string.IsNullOrEmpty(((TextBox)c).Text))
        //                return false;
        //        }
        //        if (c.HasChildren)
        //        {
        //            areControlsValid(c.Controls);
        //        }
        //    }
        //    return true;
        //}
    

