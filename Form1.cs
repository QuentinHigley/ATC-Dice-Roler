using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int intD1, intD2;
            intD1 = rand.Next(1,6);
            intD2 = rand.Next(1,6);
            lblOut.Text = "Dice 1: " + intD1 + " Dice 2: " + intD2;
        }
    }
}
