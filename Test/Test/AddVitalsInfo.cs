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
using System.Globalization;

namespace Test
{
    public partial class AddVitalsInfo : Form
    {
        public int PatientID;

        public bool editing = false;

        public string dateTaken = "";
        public string heartRate = "";
        public string systolic = "";
        public string diastolic = "";
        public string respiratoryRate = "";
        public string O2Sat = "";
        public string airType = "";
        public string height = "";
        public string weight = "";
        public string temperature = "";



        public AddVitalsInfo()
        {
            InitializeComponent();
        }

        public AddVitalsInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM dd, yyyy";
        }

        public AddVitalsInfo(int PatientID, string dateTaken, string heartRate, string systolic , string diastolic, string respiratoryRate, string O2Sat, string airType, string height, string weight, string BMI, string temperature )
        {
            this.editing = true;

            this.PatientID = PatientID;
            this.dateTaken = dateTaken;
            this.heartRate = heartRate;
            this.systolic = systolic;
            this.diastolic = diastolic;
            this.respiratoryRate = respiratoryRate;
            this.O2Sat = O2Sat;
            this.airType = airType;
            this.height = height;
            this.weight = weight;
            this.temperature = temperature;

            InitializeComponent();

            dateTaken = DateTime.ParseExact(dateTaken, "MMM dd, yyyy", CultureInfo.InvariantCulture).ToString("yyyy-MM-dd");
            string[] yearMonthDay = dateTaken.Split('-');
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MMM dd, yyyy";
            dateTimePicker1.Value = new DateTime(int.Parse(yearMonthDay[0]), int.Parse(yearMonthDay[1]), int.Parse(yearMonthDay[2]));

            HRtb.Text = heartRate;
            systolictb.Text = systolic;
            diastolictb.Text = diastolic;
            RRtb.Text = respiratoryRate;
            o2sattb.Text = O2Sat;
            attb.Text = airType;
            htb.Text = height;
            wtb.Text = weight;
            temptb.Text = temperature;
            


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
            string str1 = wtb.Text.Trim();
            string str2 = o2sattb.Text.Trim();
            string str3 = HRtb.Text.Trim();
            string str4 = RRtb.Text.Trim();
            string str5 = temptb.Text.Trim();
            string str6 = systolictb.Text.Trim();
            string str7 = diastolictb.Text.Trim();

            int heightCheck, weightCheck, o2Check, heartRateCheck, respiratoryRateCheck, systolicCheck, diastolicCheck;
            double temperatureCheck;

            bool isHeightCheck = int.TryParse(str, out heightCheck);
            bool isWeightCheck = int.TryParse(str1, out weightCheck);
            bool isO2Check = int.TryParse(str2, out o2Check);
            bool isHeartRateCheck= int.TryParse(str3, out heartRateCheck);
            bool isRespiratoryRateCheck = int.TryParse(str4, out respiratoryRateCheck);
            bool isTemperatureCheck = double.TryParse(str5, out temperatureCheck);
            bool isSystolicCheck = int.TryParse(str6, out systolicCheck);
            bool isDiastolicCheck = int.TryParse(str7, out diastolicCheck);





            if (HRtb.Text == "" || systolictb.Text == "" || diastolictb.Text =="" || RRtb.Text == "" || o2sattb.Text == "" || attb.Text == "" || htb.Text == "" || wtb.Text == "" || temptb.Text == "")
            {
                MessageBox.Show("Something must be entered for each field. If patient is not applicable for a certain field enter 'N/A'.", "Attention", MessageBoxButtons.OK);
                return;
            }
            if (isHeightCheck && isWeightCheck && isO2Check && isHeartRateCheck && isRespiratoryRateCheck && isTemperatureCheck && editing == false)
            {
                string inserted = InsertFunctions.InsertIntoVitalsInformation(DateTime.Parse(dateTimePicker1.Text), int.Parse(HRtb.Text), Int32.Parse(systolictb.Text), Int32.Parse(RRtb.Text), Int32.Parse(diastolictb.Text), Int32.Parse(o2sattb.Text), attb.Text, Int32.Parse(htb.Text), Int32.Parse(wtb.Text), double.Parse(temptb.Text), PatientID);
                MessageBox.Show(inserted);
                this.Close();
            }
            else if (editing == true)
            {
                UpdateFunctions.UpdateVitalsInfo(PatientID, DateTime.Parse(dateTimePicker1.Text), HRtb.Text, systolictb.Text, RRtb.Text, diastolictb.Text, o2sattb.Text, attb.Text, htb.Text, wtb.Text, temptb.Text, DateTime.Parse(dateTaken), heartRate, systolic, diastolic, respiratoryRate, O2Sat, airType, height, weight, temperature  );
                this.Close();
            }
            else
            {//if you have time check each individual text box
                MessageBox.Show("Must add numerical values for: \n\n Heart Rate \n Blood Pressure Values \n Respiratory Rate \n Oxygen Saturation \n Height \n Weight \n Temperature", "Error");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Console.WriteLine(PatientID);
        }

        private void bplb_Click(object sender, EventArgs e)
        {

        }
    }
}
