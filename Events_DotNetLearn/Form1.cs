using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Events_DotNetLearn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button12_MouseHover(object sender, EventArgs e)
        {
            button12.BackColor = Color.Coral;
        }

        private void button12_MouseLeave(object sender, EventArgs e)
        {
            button12.BackColor = Color.DarkGray;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            MessageBox.Show("هههههههههههههههه.کارفرما یاد میگیری پول کم به برنامه نویسا بدی");
        }

        private void button12_MouseUp(object sender, MouseEventArgs e)
        {
            MessageBox.Show("کلیک برداشته شد");

        }
    }
}
