using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShoppingApp
{
    public partial class ShopPage : Form
    {
        public ShopPage()
        {
            InitializeComponent();
        }

        private void ShopPage_Load(object sender, EventArgs e)
        {

        }

        private void FinishPurchase_Click(object sender, EventArgs e)
        {
            FinishPurchase f = new FinishPurchase();
            f.Show();
            this.Hide();
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox16.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox16.Text);
            }
            else if (!checkBox16.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox16.Text);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox1.Text);
            }
            else if (!checkBox1.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox1.Text);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox2.Text);
            }
            else if (!checkBox2.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox2.Text);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox3.Text);
            }
            else if (!checkBox3.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox3.Text);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox4.Text);
            }
            else if (!checkBox4.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox4.Text);
            }
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox12.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox12.Text);
            }
            else if (!checkBox12.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox12.Text);
            }
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox11.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox11.Text);
            }
            else if (!checkBox11.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox11.Text);
            }
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox10.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox10.Text);
            }
            else if (!checkBox10.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox10.Text);
            }
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox9.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox9.Text);
            }
            else if (!checkBox9.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox9.Text);
            }
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox15.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox15.Text);
            }
            else if (!checkBox15.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox15.Text);
            }
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox14.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox14.Text);
            }
            else if (!checkBox14.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox14.Text);
            }
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox13.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox13.Text);
            }
            else if (!checkBox13.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox13.Text);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox5.Text);
            }
            else if (!checkBox5.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox5.Text);
            }
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox6.Text);
            }
            else if (!checkBox6.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox6.Text);
            }
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox7.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox7.Text);
            }
            else if (!checkBox7.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox7.Text);
            }
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox8.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox8.Text);
            }
            else if (!checkBox8.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox8.Text);
            }
        }

        private void checkBox28_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox28.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox28.Text);
            }
            else if (!checkBox28.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox28.Text);
            }
        }

        private void checkBox27_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox27.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox27.Text);
            }
            else if (!checkBox27.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox27.Text);
            }
        }

        private void checkBox26_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox26.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox26.Text);
            }
            else if (!checkBox26.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox26.Text);
            }
        }

        private void checkBox25_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox25.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox25.Text);
            }
            else if (!checkBox25.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox25.Text);
            }
        }

        private void checkBox29_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox29.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox29.Text);
            }
            else if (!checkBox29.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox29.Text);
            }
        }

        private void checkBox30_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox30.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox30.Text);
            }
            else if (!checkBox30.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox30.Text);
            }
        }

        private void checkBox31_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox31.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox31.Text);
            }
            else if (!checkBox31.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox31.Text);
            }
        }

        private void checkBox32_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox32.Checked)
            {
                InternalVars.PurchaseList.Add(this.checkBox32.Text);
            }
            else if (!checkBox32.Checked)
            {
                InternalVars.PurchaseList.Remove(this.checkBox32.Text);
            }
        }
    }
}
