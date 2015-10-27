using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace streamin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Center_Text();
        }

        /* Thanks for 'Ank_ush', from codeProject for the above method. */
        private void Center_Text()
        {
            Graphics g = this.CreateGraphics();
            Double startingPoint = (this.Width / 2) - (g.MeasureString(this.Text.Trim(), this.Font).Width / 2);
            Double widthOfASpace = g.MeasureString(" ", this.Font).Width;
            String tmp = " ";
            Double tmpWidth = 0;
            while ((tmpWidth + widthOfASpace) < startingPoint)
            {
                tmp += " ";
                tmpWidth += widthOfASpace;
            }
            this.Text = tmp + this.Text.Trim();
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            Center_Text();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Process x = new Process();
            x.StartInfo.FileName = "https://github.com/mrdaltro/streamin";
            x.Start();
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                this.Text = "streamin [Testing Build]";
            }
        }

        
    }
}
