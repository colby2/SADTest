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
    public partial class AddVitalsInfo : Form
    {
        public int PatientID;
        public AddVitalsInfo()
        {
            InitializeComponent();
        }

        public AddVitalsInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
        }

        private void AddVitalsInfo_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str = htb.Text.Trim();
            int num;
            bool isnum = int.TryParse(str, out num);
            if(HRtb.Text == "" || BPtb.Text == "" || RRtb.Text == "" || o2sattb.Text == "" || attb.Text == "" || htb.Text == "" || wtb.Text == "" || temptb.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            InsertFunctions.InsertIntoVitalsInformation(DateTime.Parse(dateTimePicker1.Text), int.Parse(HRtb.Text), BPtb.Text, Int32.Parse(RRtb.Text), Int32.Parse(o2sattb.Text), attb.Text, Int32.Parse(htb.Text), Int32.Parse(wtb.Text), double.Parse(temptb.Text), PatientID);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(PatientID);
        }
    }
}
