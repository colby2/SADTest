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

namespace Test
{
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

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

        private void bGraphs_Click(object sender, EventArgs e)
        {
           
            ThreadStart graphRef = new ThreadStart(graphThreadStart);
            Thread graphThread = new Thread(graphRef);
            graphThread.Start();
           
        }

        private void Hub_Load(object sender, EventArgs e)
        {

        }

        private void bSearch_Click(object sender, EventArgs e)
        {
            ThreadStart patientRef = new ThreadStart(patientThreadStart);
            Thread patientThread = new Thread(patientRef);
            patientThread.Start();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
