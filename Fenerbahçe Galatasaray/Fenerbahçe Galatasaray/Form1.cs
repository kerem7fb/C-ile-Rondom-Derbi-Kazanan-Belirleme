using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fenerbahçe_Galatasaray
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random rast = new Random();
        private void button1_Click(object sender, EventArgs e)
        {
            int fb, gs;
            fb = rast.Next(0, 7);
            gs = rast.Next(0, 7);
            label1.Text = fb.ToString();
            label2.Text = gs.ToString();
        }
    }
}
