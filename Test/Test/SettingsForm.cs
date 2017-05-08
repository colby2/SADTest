using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Test
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        string passPhrase = "Pas5pr@se";        // can be any string
        string saltValue = "s@1tValue";        // can be any string
        string hashAlgorithm = "SHA1";             // can be "MD5"
        int passwordIterations = 2;                // can be any number
        string initVector = "@1B2c3D4e5F6g7H8"; // must be 16 bytes
        int keySize = 256;                // can be 192 or 128

        private void updatePass_Click(object sender, EventArgs e)
        {
            string newPass = passBox.Text;
            string fileName = "C:\\DBBackup\\stored.dat";
            if (!Directory.Exists("C:\\DBBackup"))
            {
                Directory.CreateDirectory("C:\\DBBackup");
            }

            if (File.Exists(fileName))
            {
                DialogResult confirmation = new DialogResult();
                confirmation = MessageBox.Show("A backup file already exists. Overwrite?", "ATTENTION", MessageBoxButtons.YesNo);
                if (confirmation == DialogResult.Yes)
                {

                    string wholeFile = RijndaelSimple.Encrypt(passBox.Text, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
                    File.WriteAllText(fileName, wholeFile);
                }
            }



            else
            {

                string wholeFile = RijndaelSimple.Encrypt(passBox.Text, passPhrase, saltValue, hashAlgorithm, passwordIterations, initVector, keySize);
                File.WriteAllText(fileName, wholeFile);
            }
        }
    }
}

    

