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

            ListViewItem testeItem = new ListViewItem();
            testeItem.Text = "teste";
            testeItem.ForeColor = SystemColors.WindowFrame;
            listView1.Items.Add(testeItem);

            foreach(Control x in this.Controls) {
                Control j = x;
           
                if (x is TableLayoutPanel)
                {
                    try
                    {
                        Control[] y = new Control[1];
                        y[0] = x.Controls.
                        j = y[0];
                    }

                    catch
                    {
                        throw;
                    }
                }

                if(!(j is TextBox)) {
                    j.MouseDown += new MouseEventHandler(CaptureMouse);
                }
            }
        }

        private void CaptureMouse(object sender, MouseEventArgs e)
        {
            label1.Text = e.Location.X.ToString() + ", " + e.Location.Y.ToString();
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

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (textBox1.Text == "search bar")
            {
                textBox1.Text = null;
            }
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            double phase = 0.0;
            PictureBox hover = new PictureBox();

            hover.ImageLocation = Application.StartupPath + "\\resources\\line2hover.png";
            hover.Location = pictureBox2.Location;
            hover.Height = pictureBox2.Height;
            hover.SizeMode = pictureBox2.SizeMode;
            
        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
            {
                e.Item.Selected = false;

                panel2.Controls.Remove(listView1);
                panel2.Refresh();
                panel2.Controls.Add(listView1);

                /*ListView clone = new ListView();

                for (int i = 0; i < listView1.Items.Count - 1; i++)
                {
                    ListViewItem x = new ListViewItem();
                    
                }

                //clone.Items.AddRange(listView1.Items);
                clone.Location = listView1.Location;
                clone.Size = listView1.Size;
                clone.Font = listView1.Font;
                clone.ForeColor = listView1.ForeColor;
                clone.BackColor = listView1.BackColor;
                clone.Dock = listView1.Dock;
                clone.View = listView1.View;
                clone.BorderStyle = listView1.BorderStyle;

                listView1.Hide();*/
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Rectangle algo = new Rectangle();
            algo.Height = textBox1.Height;
            algo.Width = textBox1.Width;
            algo.X = textBox1.Bounds.X;
            algo.Y = textBox1.Bounds.Y;


            //label1.Text = algo.X.ToString() + "," + algo.Y.ToString();
        }

        private void tableLayoutPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
