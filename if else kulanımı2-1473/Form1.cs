using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace if_else_kulanımı2_1473
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cbKırmızı_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbKırmızı_Click(object sender, EventArgs e)
        {
            if (cbRed.Checked)
            {
                this.BackColor = Color.Red;
            }
            else
            {
                this.BackColor = Color.Yellow;
            }

        }

        private void cbSıyah_Click(object sender, EventArgs e)
        {
            if (cbBlack.Checked)
            {
                this.BackColor= Color.Black;
            }
            else
            {
                this.BackColor =Color.Pink;
            }
        }

        private void cbMavı_Click(object sender, EventArgs e)
        {
            if (cbBule.Checked)
            {
                this.BackColor=Color.Blue;
            }
            else
            {
                this.BackColor = Color.Yellow;
            }
        }

        private void cbMor_CheckedChanged(object sender, EventArgs e)
        {
            if (cbPurple.Checked)
            {
                this.BackColor=Color.Purple;
            }
            else
            {
                this.BackColor = Color.Green;
            }
        }

        private void cbKahverengi_CheckedChanged(object sender, EventArgs e)
        {
            if ( cbBrown.Checked)
            {
                this.BackColor=Color.Brown;
            }
            else
            {
                this.BackColor=Color.DarkBlue;
            }
        }
    }
}
