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

namespace Test
{
    public partial class GraphTemplate : Form
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
        TestNum Respiratory_Rate = new TestNum("Respiratory Rate", "VitalsInformation", 4);
        TestNum Oxygen_Saturation = new TestNum("Oxygen Saturation", "VitalsInformation", 5);
        TestNum Patient_Height = new TestNum("Height", "VitalsInformation", 7);//Renamed from height since a inherited variable is named height.
        TestNum Weight = new TestNum("Weight", "VitalsInformation", 8);
        TestNum Temperature = new TestNum("Temperature", "VitalsInformation", 9);
        string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
        MySqlConnection connection;

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
            public TestNum(string name, string type,  int num)
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
        public GraphTemplate()
        {
            InitializeComponent();
            removeInitalSeries();
            chart1.Series.Add(graphName);//This command can only be called with the same name once.
            testSelectBox.Text = "(Select Test)";
            cbSubTest.Text = "(Select Value)";
            connection = new MySqlConnection(connectionString);
            lvSearch.FullRowSelect = true;
        }

        public GraphTemplate(String uniqueID)
        {
            /*This Constructor changes the seires name to the string variable given.
             * This should be helpful when the chart is modeling a specific patient and their patientID should be given.
             * (ie calling GraphTemplate("1") will create a chart with 'John' as the series name.  
             * */
            InitializeComponent();
            removeInitalSeries();
            graphName = uniqueID;//NO
            chart1.Series.Add(graphName);//NO
            testSelectBox.Text = "(Select Test)";
            cbSubTest.Text = "(Select Value)";
            connection = new MySqlConnection(connectionString);
            lvSearch.FullRowSelect = true;
            search(uniqueID);

        }

        private void removeInitalSeries()//Only call after initalizing the chart. This removes the "Series1" series from the chart
        {
                System.Windows.Forms.DataVisualization.Charting.Series[] initialSeries = chart1.Series.ToArray();
                chart1.Series.Remove(initialSeries[0]);
            
        }
        private void removeAllDataPoints()
        {
            chart1.Series[graphName].Points.Clear();
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Remove later
        {
            
            chart1.Series[graphName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            chart1.Series[graphName].Points.AddY(20);
            chart1.Series[graphName].Points.AddY(10);
            chart1.Series[graphName].Points.AddY(0);
            chart1.Series[graphName].Points.AddY(3);
            chart1.Series[graphName].Points.AddY(30);
            chart1.Series[graphName].Points.AddY(75);
            chart1.Series[graphName].ChartArea = "ChartArea1";
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeAllDataPoints();
            if (lvSearch.SelectedItems.Count == 1)
            {
                 id = lvSearch.SelectedItems[0].SubItems[3].Text;
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchButton.Text != "")
            {
                lvSearch.Items.Clear();
                string searchInput = searchBar.Text;

                connection.Open();
                string searchResults = "SELECT * FROM Demographics WHERE CONCAT(PatientID, ' ', FirstName, ' ', LastName, ' ', DOB) LIKE '%" + searchInput + "%'";
                MySqlCommand cmd = new MySqlCommand(searchResults, connection);
                MySqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    string[] row = { reader.GetString(1), reader.GetString(2), reader.GetString(8), reader.GetString(0) };
                    var listViewItem = new ListViewItem(row);
                    lvSearch.Items.Add(listViewItem);
                    
                }

                reader.Close();
                connection.Close();
            }
        }

        /*
         * This function should be called from the named contructor, where you know the patient's information.
         * Paramater: uniqueID, this needs to correspond to the patient's patientID from the Demongraphics table.
         * */
        private void search(string uniqueID)
        {
            string searchInput = uniqueID;//search on the given info
            id = uniqueID;
            connection.Open();
            string searchResults = "SELECT * FROM Demographics WHERE PatientID =" + searchInput+";";
            MySqlCommand cmd = new MySqlCommand(searchResults, connection);
            MySqlDataReader reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                string[] row = { reader.GetString(1), reader.GetString(2), reader.GetString(8), reader.GetString(0) };
                var listViewItem = new ListViewItem(row);
                lvSearch.Items.Add(listViewItem);
            }
            try {
                testSelectBox.SelectedIndex = 1;
            }
            catch (ArgumentOutOfRangeException)
            {
                System.Windows.Forms.MessageBox.Show("This Patient does not appear to be in our database!");
            }
            testSelectBox.SelectedIndex = 1;
            reader.Close();
            connection.Close();
        }

        private void searchBar_TextChanged(object sender, EventArgs e)
        {

        }

        private void testSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSubTest.Items.Clear();
            if (testSelectBox.SelectedIndex==0)
            {
                cbSubTest.Items.Add("HgA1C");
                cbSubTest.Items.Add("Cholesterol");
                cbSubTest.Items.Add("HDL");
                cbSubTest.Items.Add("LDL");
                cbSubTest.Items.Add("Triglycerides");
            }
            else if (testSelectBox.SelectedIndex == 1)
            {
                cbSubTest.Items.Add("Heart Rate");
                //cbSubTest.Items.Add("Blood Pressure");
                cbSubTest.Items.Add("Respiratory Rate");
                cbSubTest.Items.Add("Oxygen Saturation");
                cbSubTest.Items.Add("Height");
                cbSubTest.Items.Add("Weight");
                //cbSubTest.Items.Add("BMI");
                cbSubTest.Items.Add("Temperature");
            }
        }

        /*
         * Searches the database based on which test is selected in the drop down boxes
         * Parameter Test: this should be one of the predefined test types, (I.E. 'HgA1C')
         * */
        void databaseSearch(TestNum test)
        {
            if(id != null)
            {
                //graphName = test.toString();
                //chart1.Series.Add(graphName);//not working, cannot add a same series twice
                connection.Open();
                string testSearch = "Select * FROM " + test.getTestType() + " Where PatientID =" + id +" ORDER BY DateOfTest;";
                Console.WriteLine(testSearch);
                MySqlCommand cmd = new MySqlCommand(testSearch, connection);
                MySqlDataReader reader = cmd.ExecuteReader();
                chart1.Series[graphName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                while (reader.Read())
                {
                    chart1.Series[graphName].Points.AddY(reader.GetDouble(test.getDouble()));
                }
                chart1.Series[graphName].ChartArea = "ChartArea1";
                reader.Close();
                connection.Close();
            }
        }

        private void bGraph_Click(object sender, EventArgs e)
        {
            removeAllDataPoints();
            //Console.WriteLine(cbSubTest.SelectedItem.ToString());
            try
            {
                if (cbSubTest.SelectedItem.ToString() == "HgA1C")
                {
                    databaseSearch(HgA1C);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Cholesterol")
                {
                    databaseSearch(Cholesterol);
                }

                else if (cbSubTest.SelectedItem.ToString() == "HDL")
                {
                    databaseSearch(HDL);
                }
                else if (cbSubTest.SelectedItem.ToString() == "LDL")
                {
                    databaseSearch(LDL);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Triglycerides")
                {
                    databaseSearch(Triglycerides);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Heart Rate")
                {
                    databaseSearch(Heart_Rate);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Respiratory Rate")
                {
                    databaseSearch(Respiratory_Rate);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Oxygen Saturation")
                {
                    databaseSearch(Oxygen_Saturation);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Height")
                {
                    databaseSearch(Patient_Height);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Weight")
                {
                    databaseSearch(Weight);
                }
                else if (cbSubTest.SelectedItem.ToString() == "Temperature")
                {
                    databaseSearch(Temperature);
                }
            }
           catch(System.NullReferenceException)
            {
                System.Windows.Forms.MessageBox.Show("This Information is not available from this test.");
            }//End Try
        }
    }
}
