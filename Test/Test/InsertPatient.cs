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
        /// <summary>
        /// Checks if each field is filled, if complete inserts data into database.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insertButton_Click_1(object sender, EventArgs e)
        {
            if (dvtb.Text == "" || fnTb.Text == "" || lnTB.Text == "" || gtb.Text == "" || ptb.Text == "" || stb.Text == "" || sttb.Text == "" || ctb.Text == "" || ztb.Text == "" || dbtb.Text == "" || pitb.Text == "" || sitb.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            string rowsInserted = InsertFunctions.InsertIntoDemographics(fnTb.Text, lnTB.Text, gtb.Text, dvtb.Text, stb.Text, ctb.Text, sttb.Text, ztb.Text, dbtb.Text, ptb.Text, pitb.Text, sitb.Text, ntb.Text);
            MessageBox.Show(rowsInserted);
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
    

