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
        String graphName = "Default";
        String id;
        public GraphTemplate()
        {
            InitializeComponent();
            removeInitalSeries();
            chart1.Series.Add(graphName);//This command can only be called with the same name once.
            testSelectBox.Text = "(Select Test)";
            cbSubTest.Text = "(Select Value)";
        }

        public GraphTemplate(String type)
        {
            /*This Constructor changes the seires name to the string variable given.
             * This should be helpful when the chart is modeling a specific value and its name should be given.
             * (ie calling GraphTemplate("a1c") will create a chart with a1c as the series name.  
             * */
            InitializeComponent();
            removeInitalSeries();
            graphName = type;
            chart1.Series.Add(graphName);

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

        private void button1_Click(object sender, EventArgs e)//Currently using test data, replace with real data.
        {
            
            chart1.Series[graphName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;//May not be needed
            chart1.Series[graphName].Points.AddY(20);
            chart1.Series[graphName].Points.AddY(10);
            chart1.Series[graphName].Points.AddY(0);
            chart1.Series[graphName].Points.AddY(3);
            chart1.Series[graphName].Points.AddY(30);
            chart1.Series[graphName].Points.AddY(75);
            chart1.Series[graphName].ChartArea = "ChartArea1";//may not be needed
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            removeAllDataPoints();
            if (lvSearch.SelectedItems.Count == 1)
            {
            //    //So here a person's name is selected in the search list.
            //    //Now we need to determine which tests are available for this person.
            //    string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
            //    MySqlConnection connection = new MySqlConnection(connectionString);
            //    connection.Open();
                 id = lvSearch.SelectedItems[0].SubItems[3].Text;
                
            //    string testSearch = "Select * FROM LipidTestInformation WHERE PatientID =" + id + ";";
            //    MySqlCommand cmd = new MySqlCommand(testSearch, connection);
            //    MySqlDataReader reader = cmd.ExecuteReader();

            //    chart1.Series[graphName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            //    while (reader.Read())
            //    {
                    
            //        chart1.Series[graphName].Points.AddY(reader.GetDouble(2));
            //        chart1.Series[graphName].Points.AddY(0);
            //    }
            //    chart1.Series[graphName].ChartArea = "ChartArea1";//may not be needed
            //    reader.Close();
            //    connection.Close();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchButton.Text != "")
            {
                lvSearch.Items.Clear();
                string searchInput = searchBar.Text;

                string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
                MySqlConnection connection = new MySqlConnection(connectionString);

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
                cbSubTest.Items.Add("Blood Pressure");
                cbSubTest.Items.Add("Respiratory Rate");
                cbSubTest.Items.Add("Oxygen Saturation");
                cbSubTest.Items.Add("Height");
                cbSubTest.Items.Add("Weight");
                cbSubTest.Items.Add("BMI");
                cbSubTest.Items.Add("Temperature");
            }
        }

        private void bGraph_Click(object sender, EventArgs e)
        {
            removeAllDataPoints();
            Console.WriteLine(cbSubTest.SelectedItem.ToString());
            if (cbSubTest.SelectedItem.ToString() == "HDL")
            {
                Console.WriteLine("got here");
                if (id != null)
                {
                    //So here a person's name is selected in the search list.
                    //Now we need to determine which tests are available for this person.
                    string connectionString = "SERVER=sql9.freemysqlhosting.net; DATABASE=sql9160618; USERNAME=sql9160618; Password=uyRtRHT7yM";
                    MySqlConnection connection = new MySqlConnection(connectionString);
                    connection.Open();
                    //int id = Int32.Parse(lvSearch.SelectedItems[0].SubItems[3].Text);

                    string testSearch = "Select * FROM LipidTestInformation WHERE PatientID =" + id + ";";
                    MySqlCommand cmd = new MySqlCommand(testSearch, connection);
                    MySqlDataReader reader = cmd.ExecuteReader();

                    chart1.Series[graphName].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
                    while (reader.Read())
                    {

                        chart1.Series[graphName].Points.AddY(reader.GetDouble(2));
                        chart1.Series[graphName].Points.AddY(0);
                    }
                    chart1.Series[graphName].ChartArea = "ChartArea1";//may not be needed
                    reader.Close();
                    connection.Close();
                }
            }
        }
    }
}
