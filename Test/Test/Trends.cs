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
        String graphName = "Default";
        String id;
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
        //TestNum BMI = new TestNum("BMI", "VitalsInformation", 10);
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

        private ListViewItem BMISearch(ListViewItem lv)
        {
            return lv;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            TrendLV.Items.Add(BMISearch(DiabeticSearch()));

        }
    }  
}
