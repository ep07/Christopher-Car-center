using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Christopher_s_Car_Center
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label2.Text = "Family Wagon \nImmaculate Condition $12,995";
            label2.Refresh();
                
                }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            label2.Text = "Lube, Oil, Filter $25.99";
            label2.Refresh();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label2.Text = "Complete Detail $79.95 for most cars";
            label2.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Sales Position\nContact Mr. Mann 551-2134 EXT: 475";
            label2.Refresh();
        }
    }
}
