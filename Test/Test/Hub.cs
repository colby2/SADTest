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
    public partial class Hub : Form
    {
        public Hub()
        {
            InitializeComponent();
        }

        private void bGraphs_Click(object sender, EventArgs e)
        {
            GraphTemplate graph = new GraphTemplate();
            graph.ShowDialog();
        }

        private void Hub_Load(object sender, EventArgs e)
        {

        }
    }
}
