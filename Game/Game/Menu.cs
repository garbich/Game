using Game;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Myspace
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            int choose = Int32.Parse(textBox1.Text);

            Program.choose = choose;

            int choose2 = Int32.Parse(textBox2.Text);

            Program.choose2 = choose2;

            int location = Int32.Parse(textBox3.Text);

            Program.location = location;

            int weather = Int32.Parse(textBox4.Text);

            Program.weather = weather;



            Form form = new Battle();

            form.StartPosition = FormStartPosition.Manual;
            form.Height = this.Height;
            form.Width = this.Width;
            form.Location = this.Location;
            form.Show();
            this.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           

        }
    }
}
