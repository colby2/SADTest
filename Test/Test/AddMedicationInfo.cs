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
    public partial class AddMedicationInfo : Form
    {
        public int PatientID;
        public AddMedicationInfo()
        {
            InitializeComponent();
        }

        public AddMedicationInfo(int PatientID)
        {
            this.PatientID = PatientID;
            InitializeComponent();
        }

        private void AddMedicationInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
