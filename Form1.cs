using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace barrett_app1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Launch browser to youtube...
            System.Diagnostics.Process.Start("https://www.youtube.com/watch?v=xvFZjo5PgG0");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }
    }
}
