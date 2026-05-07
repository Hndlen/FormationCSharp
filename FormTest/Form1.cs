using Serie4;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            char[,] grille =
            {
                { '_','_','_' },
                { '_','_','_' },
                { '_','_','_' }
            };
            InitializeComponent();
        }
        private void buttonCheck(string coord)
        {
            //grille = Morpion.PlayForm(grille, 'X', coord);
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void buttonA1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonJouer_Click(object sender, EventArgs e)
        {
            buttonJouer.Enabled = false;
            panel1.Visible = true;
            string Joueur1 = textBoxJoueur1.Text;
            string Joueur2 = textBoxJoueur2.Text;
            textBoxJoueur1.Enabled = false;
            textBoxJoueur2.Enabled = false;
            richTextBoxConsole.Text = $"La partie de morpion entre \n {Joueur1} et {Joueur2} \n peut commencer";

            
            int tour = 0, winner = 0;
            bool enJeu = true;


            // richTextBoxConsole.
        }
    }
}
