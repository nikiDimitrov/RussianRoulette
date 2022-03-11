using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Russian_Roulette
{
    public partial class Menu : Form
    {
        private int bulletNum;
        private Game game;
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem == null)
            {
                MessageBox.Show("You HAVE to put bullets in the gun to play.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(comboBox1.SelectedItem.ToString() != "Just fucking kill me")
            {
                bulletNum = int.Parse(comboBox1.SelectedItem.ToString());
                game = new Game(bulletNum);
                foreach (Form f in Application.OpenForms)
                {
                    f.Hide();
                }
                game.Show();
               
            }
            else
            {
                game = new Game(6);
                foreach (Form f in Application.OpenForms)
                {
                    f.Hide();
                }
                game.Show();
            }
        }
    }
}
