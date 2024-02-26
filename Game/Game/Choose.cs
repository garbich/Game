using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game
{
    public partial class Choose : Form
    {
        public static int Choice { get; set; }

        public Choose(string labelText, string button1Text, string button2Text, string button3Text)
        {
            InitializeComponent();
            label1.Text = labelText;
            button1.Text = button1Text;
            button2.Text = button2Text;
            button3.Text = button3Text;
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {

            Choice = 1;
            this.Close();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Choice = 2;
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Choice = 3;
            this.Close();
        }
    }
}
