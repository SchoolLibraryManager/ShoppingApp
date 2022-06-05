using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace ShoppingApp
{
    public partial class FinishPurchase : Form
    {
        public FinishPurchase()
        {
            InitializeComponent();
        }
        string a;
        private void FinishPurchase_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < InternalVars.PurchaseList.Count; i++)
            {
                listBox1.Items.Add(InternalVars.PurchaseList[i]);
            }
            label1.Enabled = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            QRCodeGenerator qr = new QRCodeGenerator();
            QRCodeData data = qr.CreateQrCode(String.Join(", ",InternalVars.PurchaseList) +" ,You should " + a.ToLower(), QRCodeGenerator.ECCLevel.Q);
            QRCode code = new QRCode(data);
            pictureBox1.Image = code.GetGraphic(5);
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        { 
            if (radioButton1.Checked)
            {
                a = radioButton1.Text;
                label1.Enabled = true;
            }
            else if (!radioButton1.Checked)
            {
                a = string.Empty;
                label1.Enabled = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                a = radioButton2.Text;
                label1.Enabled = true;
            }
            else if (!radioButton2.Checked)
            {
                a = string.Empty;
                label1.Enabled = false;
            }
        }
    }
}
