using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test
{
    public partial class GraphTemplate : Form
    {
        public GraphTemplate()
        {
            InitializeComponent();
            chart1.Series.Add("Series2");
            chart1.Series["Series2"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            chart1.Series["Series2"].Points.AddY(20);
            chart1.Series["Series2"].Points.AddY(10);
            chart1.Series["Series2"].Points.AddY(0);
            chart1.Series["Series2"].Points.AddY(3);
            chart1.Series["Series2"].Points.AddY(30);
            chart1.Series["Series2"].Points.AddY(75);
            chart1.Series["Series2"].ChartArea = "ChartArea1";
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
