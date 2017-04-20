using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DiabeticHealthDB;
using MySql.Data.Types;


namespace Test
{
    public partial class Hub : Form
    {
        
        public Hub()
        {
            InitializeComponent();
        }

        Thread[] allThreads = new Thread[100];
        int threadCount = 0;
        int tabCount = 1;

        public static void graphThreadStart()
        {
            GraphTemplate graph = new GraphTemplate();
            graph.ShowDialog();
        }

        public static void patientThreadStart()
        {

            Patient patient = new Patient();
            patient.ShowDialog();
        }
        
       /* public static void patientThreadStart(string criteria)
        {
            Patient patient = new Patient(criteria);
            patient.ShowDialog();
        }//Thread Starter for patient with non-blank search*/

        public void patientThreadStart(object data)
        {
            Patient patient = new Patient(data.ToString(),this);
            patient.ShowDialog();
        }

         public static void loginThreadStart()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        public static void insertPatientThreadStart()
        {
            InsertPatient insert = new InsertPatient();
            insert.ShowDialog();
        }

        private void bGraphs_Click(object sender, EventArgs e)
        {

            //ThreadStart graphRef = new ThreadStart(graphThreadStart);
            // allThreads[threadCount] = new Thread(graphRef);
            // allThreads[threadCount].IsBackground = true;
            // allThreads[threadCount].Start();
            // threadCount++;
            // //Thread graphThread = new Thread(graphRef);
            // //graphThread.IsBackground = true;
            // //graphThread.Start();
            tabControl1.TabPages.Add(new TabPage("Graph"+tabCount.ToString()));
            Form frm = new GraphTemplate();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl1.TabPages[tabCount].Controls.Add(frm);
            this.tabControl1.SelectedIndex = tabCount;
            tabCount++;

        }

        const int LEADING_SPACE = 12;
        const int CLOSE_SPACE = 15;
        const int CLOSE_AREA = 15;

        private void Hub_Load(object sender, EventArgs e)
        {
            int tabLength = tabControl1.ItemSize.Width;

            // measure the text in each tab and make adjustment to the size
            for (int i = 0; i < this.tabControl1.TabPages.Count; i++)
            {
                TabPage currentPage = tabControl1.TabPages[i];

                int currentTabLength = TextRenderer.MeasureText(currentPage.Text, tabControl1.Font).Width;
                // adjust the length for what text is written
                currentTabLength += LEADING_SPACE + CLOSE_SPACE + CLOSE_AREA;

                if (currentTabLength > tabLength)
                {
                    tabLength = currentTabLength;
                }
            }

            // create the new size
            Size newTabSize = new Size(tabLength, tabControl1.ItemSize.Height);
            tabControl1.ItemSize = newTabSize;
        
    }

 

        private void bSearch_Click(object sender, EventArgs e)
        {
            lvSearchList.Items.Clear();
            if (tbSearch.Text != "")
            {
                string searchInput = tbSearch.Text;

                
                MySqlConnection connection = DatabaseConnection.GetConnection();


                connection.Open();
                string searchResults = "";
                if (cbFirstName.Checked == true && cbLastName.Checked == true && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName, ' ', LastName, ' ', DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == true && cbLastName.Checked == true && cbDOB.Checked == false)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName, ' ', LastName) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == true && cbLastName.Checked == false && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName, ' ', DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == true && cbLastName.Checked == false && cbDOB.Checked == false)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(FirstName) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == true && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(LastName, ' ', DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == true && cbDOB.Checked == false)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(LastName) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == false && cbDOB.Checked == true)
                    searchResults = "SELECT * FROM Demographics WHERE CONCAT(DOB) LIKE '%" + searchInput + "%'";
                else if (cbFirstName.Checked == false && cbLastName.Checked == false && cbDOB.Checked == false) { goto End; /*redirects to End tag below*/ }


                MySqlCommand cmd = new MySqlCommand(searchResults, connection);
                MySqlDataReader reader = cmd.ExecuteReader();



                while (reader.Read())
                {
                    string[] row = {reader.GetString(1), reader.GetString(2), reader.GetString(9), reader.GetString(0)};
                    var listViewItem = new ListViewItem(row);
                    lvSearchList.Items.Add(listViewItem);
                }

                reader.Close();
                End:
                connection.Close();
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            //Will be redirected to a different form.
            ThreadStart patientRef = new ThreadStart(insertPatientThreadStart);
            allThreads[threadCount] = new Thread(patientRef);//Thread patientThread = new Thread(patientRef);
            allThreads[threadCount].IsBackground = true;//patientThread.IsBackground = true;
            allThreads[threadCount].Start(); //patientThread.Start();
            threadCount++;
        }


        private void bLogout_Click(object sender, EventArgs e)
        {
            ThreadStart loginRef = new ThreadStart(loginThreadStart);
            Thread loginThread = new Thread(loginRef);
            loginThread.Start();
            for(int i = 0; i< threadCount; i++)
            {
                allThreads[i].Abort();
            }
            this.Close();
        }

        private void addPatientForm()
        {
            //DO NOT CALL
        }

        private void addPatientForm(object patientID)
        {
            Form frm = new Patient(patientID.ToString(), this);
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.tabControl1.TabPages[tabCount].Controls.Add(frm);
            tabCount++;
        }

        
        

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvSearchList.SelectedItems.Count == 1)
            {
                //Thread patientThread = new Thread(patientThreadStart);
                // patientThreadStart(lvSearchList.SelectedItems[0].SubItems[3].Text);
                //ParameterizedThreadStart pat = new ParameterizedThreadStart(patientThreadStart);
                //allThreads[threadCount] = new Thread(pat);
                //allThreads[threadCount].IsBackground = true;
                //allThreads[threadCount].Start(lvSearchList.SelectedItems[0].SubItems[3].Text);
                //threadCount++;
                //tabControl1.TabPages.Add(new TabPage("Patient" + lvSearchList.SelectedItems[0].SubItems[3].Text));
                this.backgroundWorker1.RunWorkerAsync();
                //this.NewPatientThread = new Thread(new ParameterizedThreadStart(addPatientForm));
                //this.NewPatientThread.Start(lvSearchList.SelectedItems[0].SubItems[3].Text);
                //Form frm = new Patient(lvSearchList.SelectedItems[0].SubItems[3].Text);
                //frm.TopLevel = false;
                // frm.Visible = true;
                //frm.FormBorderStyle = FormBorderStyle.None;
                //frm.Dock = DockStyle.Fill;
                //tabControl1.TabPages[tabCount].Controls.Add(frm);


            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_DrawItem(object sender, DrawItemEventArgs e)
        {
            //This code will render a "x" mark at the end of the Tab caption. 
            if (!e.Index.Equals(0))
            {
                 e.Graphics.DrawString("x", e.Font, Brushes.Black, e.Bounds.Right - 15, e.Bounds.Top + 4);
            }
                e.Graphics.DrawString(this.tabControl1.TabPages[e.Index].Text, e.Font, Brushes.Black, e.Bounds.Left + 12, e.Bounds.Top + 4);
                tabControl1.Padding = new System.Drawing.Point(21, 3);
                e.DrawFocusRectangle();
            
        }

        private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Rectangle r = tabControl1.GetTabRect(this.tabControl1.SelectedIndex);
            Rectangle closeButton = new Rectangle(r.Right - 15, r.Top + 4, 9, 7);
            if (closeButton.Contains(e.Location) && !this.tabControl1.SelectedIndex.Equals(0))
            {
                this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
                tabCount--;
            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            tabControl1.TabPages.Add(new TabPage("Patient" + lvSearchList.SelectedItems[0].SubItems[3].Text));
            Form frm = new Patient(lvSearchList.SelectedItems[0].SubItems[3].Text, this);
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            this.tabControl1.TabPages[tabCount].Controls.Add(frm);
            this.tabControl1.SelectedIndex = tabCount;
            tabCount++;
            
        }

        private void backgroundWorker2_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            this.tabControl1.TabPages.Remove(this.tabControl1.SelectedTab);
            tabCount--;
        }

        private void TrendButton_Click(object sender, EventArgs e)
        {
            tabControl1.TabPages.Add(new TabPage("Trend" + tabCount.ToString()));
            Form frm = new Trends();
            frm.TopLevel = false;
            frm.Visible = true;
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Dock = DockStyle.Fill;
            tabControl1.TabPages[tabCount].Controls.Add(frm);
            this.tabControl1.SelectedIndex = tabCount;
            tabCount++;
        }

        private void backupButton_Click(object sender, EventArgs e)
        {
            Backup newBackup = new Backup();
            newBackup.ShowDialog();
        }
    }
}
