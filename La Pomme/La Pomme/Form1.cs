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
    public partial class frmLaPomme : Form
    {
        string[] playerNames; // Contains the player 1 name (index 0) and the player 2 name (index 1)
        Form2 form2 = new Form2(); // Instanciate the second form to set the player names

        public frmLaPomme()
        {
            InitializeComponent();
        }

        private void frmLaPomme_Load(object sender, EventArgs e)
        {
            form2.ShowDialog(); // Shows the second form
            playerNames = form2.GetPlayerNames(); // Used to store the player names

            lblPlayer1.Text = playerNames[0]; // Player 1 name
            lblPlayer2.Text = playerNames[1]; // Player 2 name
        }
    }
}
