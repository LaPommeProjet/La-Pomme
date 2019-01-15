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
    public partial class Form_Win : Form
    {
        string victoryName = "";
        string victoryPoints = "";
        string victoryCards = "";

        public Form_Win()
        {
            InitializeComponent();
        }        

        public string VictoryName
        {
            get
            {
                return victoryName;
            }
            set
            {
                victoryName = value;
            }
        }

        public string VictoryPoints
        {
            get
            {
                return victoryPoints;
            }
            set
            {
                victoryPoints = value;
            }
        }

        public string VictoryCards
        {
            get
            {
                return victoryCards;
            }
            set
            {
                victoryCards = value;
            }
        }

        private void Form_Win_Load(object sender, EventArgs e)
        {
            lblWin.Text = victoryName + " a gagné avec un total de " + victoryPoints + " points et " + victoryCards + " cartes gagnées !";
            ptbTrophee.ImageLocation = @"trophee.jpg";
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
