using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Test
{
    public partial class LoadScreen : Form
    {


        public LoadScreen()
        {
            InitializeComponent();
        }

        public static void loginThreadStart()
        {
            Login login = new Login();
            login.ShowDialog();
        }

        private void LoadScreen_Load(object sender, EventArgs e)
        {
            timeLeft = 100;
            timer1.Start();
        }

        public int timeLeft { get; set; }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                timeLeft--;
                progressBar1.Increment(1);
            }
            else
            {
                timer1.Stop();
                ThreadStart loginRef = new ThreadStart(loginThreadStart);
                Thread loginThread = new Thread(loginRef);
                loginThread.Start();
                this.Close();
            }
        }
    }
}
