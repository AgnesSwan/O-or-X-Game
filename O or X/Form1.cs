using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace O_or_X
{
    public partial class Form1 : Form
    {
        bool ruch = false;
        public Form1()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            Button przycisk = (Button)sender;
            if (ruch)
            {
                przycisk.Text = "X";
                przycisk.ForeColor = Color.Maroon;
                komunikat.Text = "Kolej O";
                komunikat.ForeColor = Color.Green;
            }
            else
            {
                przycisk.Text = "O";
                przycisk.ForeColor = Color.Green;
                komunikat.Text = "Kolej X";
                komunikat.ForeColor = Color.Maroon;
            }
            ruch = !ruch;

            Wynik();
        }
        private void Wynik()
        {
            bool find_winner = false;
            //poziom
            if ((btn11.Text == btn12.Text) && (btn12.Text == btn13.Text) && btn11.Text != "")
                find_winner = true;
            else if ((btn21.Text == btn22.Text) && (btn22.Text == btn23.Text) && btn21.Text != "")
                find_winner = true;
            else if ((btn31.Text == btn32.Text) && (btn32.Text == btn33.Text) && btn31.Text != "")
                find_winner = true;
            //pion
            else if ((btn11.Text == btn21.Text) && (btn21.Text == btn31.Text) && btn21.Text != "")
                find_winner = true;
            else if ((btn12.Text == btn22.Text) && (btn22.Text == btn32.Text) && btn22.Text != "")
                find_winner = true;
            else if ((btn13.Text == btn23.Text) && (btn23.Text == btn33.Text) && btn23.Text != "")
                find_winner = true;
            //skos
            else if ((btn11.Text == btn22.Text) && (btn22.Text == btn33.Text) && btn11.Text != "")
                find_winner = true;
            else if ((btn13.Text == btn22.Text) && (btn22.Text == btn31.Text) && btn22.Text != "")
                find_winner = true;

            if (find_winner)
            {
                string winner = "";
                if (ruch)

                    winner = "O";
                else
                    winner = "X"; 
                komunikat.Text = "Zwycięzcą jest: " + winner;
                komunikat.ForeColor = Color.Red;
               
            }
        }

       
    }

}
