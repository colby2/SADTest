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
            int rowsInserted = InsertFunctions.InsertIntoDemographics(fnTb.Text, lnTB.Text, dvtb.Text, stb.Text, ctb.Text, sttb.Text, ztb.Text, dbtb.Text, ptb.Text, pitb.Text, sitb.Text);
            this.Close();
        }
    }
}
