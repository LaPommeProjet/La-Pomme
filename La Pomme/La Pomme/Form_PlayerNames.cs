﻿using System;
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
    public partial class Form_PlayerNames : Form
    {
        public static string player1Name;
        public static string player2Name;

        public Form_PlayerNames()
        {
            InitializeComponent();
        }

        private void Form_PlayerNames_Load(object sender, EventArgs e)
        {
            cmdValidate.Cursor = Cursors.Hand;
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
            
            if(txtPlayer1.Text == txtPlayer2.Text)
            {
                MessageBox.Show("Les 2 noms de joueurs ne peuvent être les mêmes.");
            }
            else
            {
                Close();
            }
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
    }
}
