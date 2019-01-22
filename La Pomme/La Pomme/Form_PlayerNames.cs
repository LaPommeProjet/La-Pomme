using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace La_Pomme
{
    public partial class Form_PlayerNames : Form
    {
        string[] playerNames = new string[2];

        public Form_PlayerNames()
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
            if(txtPlayer1.Text == txtPlayer2.Text || txtPlayer1.Text == String.Empty || txtPlayer2.Text == String.Empty)
            {
                MessageBox.Show("Les noms ne peuvent être vides ou identiques.");
            }
            else
            {
                playerNames[0] = txtPlayer1.Text;
                playerNames[1] = txtPlayer2.Text;
                
                Close();
            }
        }

        /// <summary>
        /// Get the names of the players
        /// </summary>
        /// <returns>Array of strings with 2 player names</returns>
        public string[] GetPlayerNames()
        {
            return playerNames;
        }
    }
}
