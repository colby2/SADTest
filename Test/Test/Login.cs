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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        public static void hubThreadStart()
        {
            Hub main = new Hub();
            main.ShowDialog();
        }

        private void bLogin_Click(object sender, EventArgs e)
        {
            ThreadStart hubRef = new ThreadStart(hubThreadStart);
            Thread hubThread = new Thread(hubRef);
            hubThread.Start();
            //add code to close login form

        }
    }
}
