using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Pomme
{
    public partial class form2 : Form
    {
        public static string player1Name;
        public static string player2Name;

        public form2()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the names of the players
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdValidate_Click(object sender, EventArgs e)
        {
            if(txtPlayer1.Text == String.Empty)
            {
                player1Name = "Joueur 1";             
            }
            else
            {
                player1Name = txtPlayer1.Text;               
            }

            if(txtPlayer2.Text == String.Empty)
            {
                player2Name = "Joueur 2";
            }
            else
            {
                player2Name = txtPlayer2.Text;
            }

            Close();
        }

        /// <summary>
        /// Get the names of the players
        /// </summary>
        /// <returns>Array of strings with 2 player names</returns>
        public string[] GetPlayerNames()
        {
            string[] playerNames = { player1Name, player2Name };

            return playerNames;
        }

        /// <summary>
        /// Set the default names of the players when the form is closed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            player1Name = "Joueur 1";
            player2Name = "Joueur 2";
        }
    }
}
