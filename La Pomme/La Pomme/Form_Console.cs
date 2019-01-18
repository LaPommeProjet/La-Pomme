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
    public partial class Form_Console : Form
    {
        string cardName, cardType, playerName;

        public Form_Console()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Get or set the name of the card
        /// </summary>
        public string CardName
        {
            get
            {
                return cardName;
            }
            set
            {
                cardName = value;
            }
        }

        /// <summary>
        /// Get or set the type of the card
        /// </summary>
        public string CardType
        {
            get
            {
                return cardType;
            }
            set
            {
                cardType = value;
            }
        }

        /// <summary>
        /// Leave the console
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Get or set the name of the player
        /// </summary>
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }

        /// <summary>
        /// Write who played what
        /// </summary>
        public void WriteLine()
        {
            lstText.Items.Add(playerName + " a joué : " + cardName + " de " + cardType + ".\n");
        }
    }
}
