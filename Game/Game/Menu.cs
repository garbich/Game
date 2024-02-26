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
            Form formChoose = new Choose("Choose 1 hero", "Mage", "Warrior", "Archer");
            formChoose.StartPosition = FormStartPosition.CenterScreen;
            formChoose.ShowDialog();

            Program.choose = Choose.Choice;

            formChoose = new Choose("Choose 2 hero", "Mage", "Warrior", "Archer");
            formChoose.StartPosition = FormStartPosition.CenterScreen;
            formChoose.ShowDialog();

            Program.choose2 = Choose.Choice;

            formChoose = new Choose("Choose location", "Field", "City", "Mountain");
            formChoose.StartPosition = FormStartPosition.CenterScreen;
            formChoose.ShowDialog();

            Program.location = Choose.Choice;                  

            Program.chooseLocation();

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

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            return;
        }
    }
}
