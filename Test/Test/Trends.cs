using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using MySql.Data.MySqlClient;
using DiabeticHealthDB;

namespace Test
{
    public partial class Trends : Form
    {
        /***********************************************************
         * Declaration of global variables used throughout the form
         * *********************************************************/
        TestNum HgA1C = new TestNum("HgA1C", "LipidTestInformation", 2);
        TestNum Cholesterol = new TestNum("Cholesterol", "LipidTestInformation", 3);
        TestNum HDL = new TestNum("HDL", "LipidTestInformation", 4);
        TestNum LDL = new TestNum("HgA1C", "LipidTestInformation", 5);
        TestNum Triglycerides = new TestNum("Triglycerides", "LipidTestInformation", 6);
        TestNum Heart_Rate = new TestNum("Heart Rate", "VitalsInformation", 2);
        TestNum Respiratory_Rate = new TestNum("Respiratory Rate", "VitalsInformation", 5);
        TestNum Oxygen_Saturation = new TestNum("Oxygen Saturation", "VitalsInformation", 6);
        TestNum Patient_Height = new TestNum("Height", "VitalsInformation", 8);//Renamed from height since a inherited variable is named height.
        TestNum Weight = new TestNum("Weight", "VitalsInformation", 9);
        TestNum Temperature = new TestNum("Temperature", "VitalsInformation", 10);
        TestNum Systolic = new TestNum("Systolic", "VitalsInformation", 3);
        TestNum Diastolic = new TestNum("Diastolic", "VitalsInformation", 4);

        //"SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
        MySqlConnection connection = DiabeticHealthDB.DatabaseConnection.GetConnection();

        /**
         * This DataType has information corresponding to how these test's data is stored in the database.
         * Int num is the column number of the test's value
         * String name is the test's name
         * String testType is the name of the table in which the test is located.
         * */
        struct TestNum
        {
            public int num;
            public string name, testType;
            public TestNum(string name, string type, int num)
            {
                this.name = name;
                this.testType = type;
                this.num = num;
            }
            public string toString()
            {
                return name;
            }
            public int getDouble()
            {
                return num;
            }
            public string getTestType()
            {
                return testType;
            }
        }

        /* This is the default constructor, it is called from the HUB form.
         * 
         * */
        public Trends()
        {
            InitializeComponent();

        }

        public Trends(String uniqueID)
        {

            InitializeComponent();


        }


        /*
         * Takes screenshot and puts in picture folder
         * */
        private void button1_Click_1(object sender, EventArgs e)
        {

            Bitmap memoryImage;
            memoryImage = new Bitmap(1000, 900);
            Size s = new Size(memoryImage.Width, memoryImage.Height);

            Graphics memoryGraphics = Graphics.FromImage(memoryImage);

            memoryGraphics.CopyFromScreen(0, 0, 0, 0, s);


            string graphScreenShot = string.Format(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) +
                      @"\Screenshot" + "_" +
                      DateTime.Now.ToString("(dd_MMMM_hh_mm_ss_tt)") + ".png");


            memoryImage.Save(graphScreenShot);


        }

        private void Trends_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// General search that returns the average of the most recent HgA1C and HDL test for all patients.
        /// </summary>
        /// <returns>
        /// Returns a ListViewItem with the first slot being HDL and second being HgA1C.
        /// </returns>
       private ListViewItem DiabeticSearch()
        {
            connection.Open();
            string testSearch = "Select * FROM " + HgA1C.getTestType() +" where (PatientID, DateOfTest) in (select PatientID, max(DateOfTest) as date from " + HgA1C.getTestType() +" group by PatientID )";
            Console.WriteLine(testSearch);
            MySqlCommand cmd = new MySqlCommand(testSearch, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int i =0;
            double HDLCount = 0;
            double HgA1cCount = 0;
            while (reader.Read())
            {
                HDLCount += reader.GetDouble(HDL.getDouble());
                HgA1cCount += reader.GetDouble(HgA1C.getDouble());
                i++;
            }
            HDLCount /= i;
            ListViewItem lv = new ListViewItem(HDLCount.ToString());
            HgA1cCount /= i;
            lv.SubItems.Add(HgA1cCount.ToString());
            connection.Close();
            reader.Close();
            return lv;
        }
        /// <summary>
        /// Search that returns the average of the most recent HgA1C and HDL test for all male patients.
        /// </summary>
        /// <returns>
        /// Returns a ListViewItem with the first slot being HDL and second being HgA1C.
        /// </returns>
        private ListViewItem MaleDiabeticSearch()
        {
            connection.Open();
            string testSearch = "Select * FROM " + HgA1C.getTestType() + " where (PatientID, DateOfTest) in (select PatientID , max(DateOfTest) as date from " + HgA1C.getTestType() +" Where PatientID in (Select PatientID from Demographics where Gender = \"m\") group by PatientID )";

            Console.WriteLine(testSearch);
            MySqlCommand cmd = new MySqlCommand(testSearch, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            double HDLCount = 0;
            double HgA1cCount = 0;
            while (reader.Read())
            {
                HDLCount += reader.GetDouble(HDL.getDouble());
                HgA1cCount += reader.GetDouble(HgA1C.getDouble());
                i++;
            }
            HDLCount /= i;
            ListViewItem lv = new ListViewItem(HDLCount.ToString());
            HgA1cCount /= i;
            lv.SubItems.Add(HgA1cCount.ToString());
            connection.Close();
            reader.Close();
            return lv;
        }
        /// <summary>
        /// Search that returns the average of the most recent HgA1C and HDL test for all female patients.
        /// </summary>
        /// <returns>
        /// Returns a ListViewItem with the first slot being HDL and second being HgA1C.
        /// </returns>
        private ListViewItem FemaleDiabeticSearch()
        {
            connection.Open();
            string testSearch = "Select * FROM " + HgA1C.getTestType() + " where (PatientID, DateOfTest) in (select PatientID , max(DateOfTest) as date from " + HgA1C.getTestType() + " Where PatientID in (Select PatientID from Demographics where Gender = \"f\") group by PatientID )";

            Console.WriteLine(testSearch);
            MySqlCommand cmd = new MySqlCommand(testSearch, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            double HDLCount = 0;
            double HgA1cCount = 0;
            while (reader.Read())
            {
                HDLCount += reader.GetDouble(HDL.getDouble());
                HgA1cCount += reader.GetDouble(HgA1C.getDouble());
                i++;
            }
            HDLCount /= i;
            ListViewItem lv = new ListViewItem(HDLCount.ToString());
            HgA1cCount /= i;
            lv.SubItems.Add(HgA1cCount.ToString());
            connection.Close();
            reader.Close();
            return lv;
        }
        /// <summary>
        /// Search that returns the average BMI for all male patients based on the most recent height and weight measurements
        /// </summary>
        /// <param name="lv">
        /// Needs to be the ListViewItem returned by MaleDiabeticSearch()
        /// </param>
        /// <returns>
        /// Returns a ListViewItem with the thrid slot being BMI, First and Second slot should be set by earlier MaleDiabeticSearch.
        /// </returns>
        private ListViewItem MaleBMISearch(ListViewItem lv)
        {
            connection.Open();
            string testSearch = "Select* FROM " + Patient_Height.getTestType() + " where(PatientID, DateOfTest) in (select PatientID, max(DateOfTest) as date from " + Patient_Height.getTestType() +" Where PatientID in (Select PatientID from Demographics where Gender = \"m\") group by PatientID )";
            Console.WriteLine(testSearch);
            MySqlCommand cmd = new MySqlCommand(testSearch, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            List<double> w = new List<double>();
            while (reader.Read())
            {
                w.Add(reader.GetDouble(Weight.getDouble()));
                Console.WriteLine(w[i]);
                i++;
            }
            i = 0;

            testSearch = "Select * FROM " + Weight.getTestType() + " where (PatientID, DateOfTest) in (select PatientID , max(DateOfTest) as date from " + Weight.getTestType() + " Where PatientID in (Select PatientID from Demographics where Gender = \"m\") group by PatientID )";

            cmd = new MySqlCommand(testSearch, connection);
            reader.Close();
            reader = cmd.ExecuteReader();
            List<double> h = new List<double>();
            while (reader.Read())
            {
                h.Add(reader.GetDouble(Patient_Height.getDouble()));
                Console.WriteLine(h[i]);
                i++;
            }

            int k = 0;
            double totalBMI = 0;
            for (int j = 0; j < i; j++)
            {
                totalBMI += ((w[j] * .45) / ((h[j] * .025) * (h[j] * .025)));
                Console.WriteLine((w[j] * .45) + " / " + ((h[j] * .025) * (h[j] * .025)));
                Console.WriteLine(totalBMI);
                k++;
            }
            totalBMI /= k;
            lv.SubItems.Add(totalBMI.ToString());
            lv.SubItems.Add("Males");
            reader.Close();
            connection.Close();
            return lv;
        }
        /// <summary>
        /// Search that returns the average BMI for all female patients based on the most recent height and weight measurements
        /// </summary>
        /// <param name="lv">
        /// Needs to be the ListViewItem returned by FemaleDiabeticSearch()
        /// </param>
        /// <returns>
        /// Returns a ListViewItem with the thrid slot being BMI, First and Second slot should be set by earlier FemaleDiabeticSearch.
        /// </returns>
        private ListViewItem FemaleBMISearch(ListViewItem lv)
        {
            connection.Open();
            string testSearch = "Select* FROM " + Patient_Height.getTestType() + " where(PatientID, DateOfTest) in (select PatientID, max(DateOfTest) as date from " + Patient_Height.getTestType() + " Where PatientID in (Select PatientID from Demographics where Gender = \"f\") group by PatientID )";
            Console.WriteLine(testSearch);
            MySqlCommand cmd = new MySqlCommand(testSearch, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            List<double> w = new List<double>();
            while (reader.Read())
            {
                w.Add(reader.GetDouble(Weight.getDouble()));
                Console.WriteLine(w[i]);
                i++;
            }
            i = 0;

            testSearch = "Select * FROM " + Weight.getTestType() + " where (PatientID, DateOfTest) in (select PatientID , max(DateOfTest) as date from " + Weight.getTestType() + " Where PatientID in (Select PatientID from Demographics where Gender = \"f\") group by PatientID )";

            cmd = new MySqlCommand(testSearch, connection);
            reader.Close();
            reader = cmd.ExecuteReader();
            List<double> h = new List<double>();
            while (reader.Read())
            {
                h.Add(reader.GetDouble(Patient_Height.getDouble()));
                Console.WriteLine(h[i]);
                i++;
            }

            int k = 0;
            double totalBMI = 0;
            for (int j = 0; j < i; j++)
            {
                totalBMI += ((w[j] * .45) / ((h[j] * .025) * (h[j] * .025)));
                Console.WriteLine((w[j] * .45) + " / " + ((h[j] * .025) * (h[j] * .025)));
                Console.WriteLine(totalBMI);
                k++;
            }
            totalBMI /= k;
            lv.SubItems.Add(totalBMI.ToString());
            lv.SubItems.Add("Females");
            reader.Close();
            connection.Close();
            return lv;
        }
        /// <summary>
        /// Search that returns the average BMI for all patients based on the most recent height and weight measurements
        /// </summary>
        /// <param name="lv">
        /// Needs to be the ListViewItem returned by DiabeticSearch()
        /// </param>
        /// <returns>
        /// Returns a ListViewItem with the thrid slot being BMI, First and Second slot should be set by earlier DiabeticSearch.
        /// </returns>
        private ListViewItem BMISearch(ListViewItem lv)
        {
            connection.Open();
            string testSearch = "Select * FROM " + Weight.getTestType() + " where (PatientID, DateOfTest) in (select PatientID, max(DateOfTest) as date from " + Weight.getTestType() + " group by PatientID )";
            Console.WriteLine(testSearch);
            MySqlCommand cmd = new MySqlCommand(testSearch, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            int i = 0;
            List<double> w = new List<double>();
            while (reader.Read())
            {
                w.Add(reader.GetDouble(Weight.getDouble()));
                Console.WriteLine(w[i]);
                i++;
            }
            i = 0;

           testSearch = "Select * FROM " + Patient_Height.getTestType() + " where (PatientID, DateOfTest) in (select PatientID, max(DateOfTest) as date from " + Patient_Height.getTestType() + " group by PatientID )";

            cmd = new MySqlCommand(testSearch, connection);
            reader.Close();
            reader = cmd.ExecuteReader();
            List<double> h = new List<double>();
            while (reader.Read())
            {
                h.Add(reader.GetDouble(Patient_Height.getDouble()));
                Console.WriteLine(h[i]);
                i++;
            }

            int k = 0;
            double totalBMI = 0;
            for (int j = 0; j < i; j++)
            {
                totalBMI+= ((w[j] * .45) / ((h[j] * .025) * (h[j] * .025)));
                Console.WriteLine((w[j] * .45) + " / " + ((h[j] * .025) * (h[j] * .025)));
                Console.WriteLine(totalBMI);
                k++;
            }
            totalBMI /= k;
            lv.SubItems.Add(totalBMI.ToString());
            reader.Close();
            connection.Close();
            return lv;
        }
        /// <summary>
        /// Logic statements will need to be changed if more filters are added.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count.Equals(0)) {
                TrendLV.Items.Add(BMISearch(DiabeticSearch()));
            }
                
            else
            {
                TrendLV.Items.Add(MaleBMISearch(MaleDiabeticSearch()));
                TrendLV.Items.Add(FemaleBMISearch(FemaleDiabeticSearch()));
            }
                

        }

        private void TrendLV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }  
}
