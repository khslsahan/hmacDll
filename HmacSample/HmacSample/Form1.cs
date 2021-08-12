using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HmacGenValid;

namespace HmacSample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonloadClick(object sender, EventArgs e)
        {
            OpenFileDialog opd = new OpenFileDialog();
            if (opd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                String strfilepath = opd.FileName;
                string readText = File.ReadAllText(strfilepath);
                richtxtFile.Text = readText;
            }


        }
        private void bunGenerateHmacClick(object sender, EventArgs e)
        {


            String hexKey = txtHexKey.Text.Trim();
            string message = richtxtFile.Text.Trim();
            if (hexKey == "" && message == "")
            {
                MessageBox.Show("Pleace Check The Inputs ", "Input Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                String hmac = HmacGenValid.HmacGenValid.hmacGenaration(hexKey, message);
                txtGeneratedHmac.Text = hmac;
            }
        }

        private void buttonValidateHmacClick(object sender, EventArgs e)
        {
           string genhmac = txtGeneratedHmac.Text;
            string hardcodehmac = "b436e3e86cb3800b3864aeecc8d06c126f005e7645803461717a8e4b2de3a905";
            Boolean valid = HmacGenValid.HmacGenValid.hmacValidation(hardcodehmac, genhmac);

            if (valid)
            {
                MessageBox.Show("The Validation Success ", "The Hmac validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("The Validation Fail ", "The Hmac validation", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }
    }
}
