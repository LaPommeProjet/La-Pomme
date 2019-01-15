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
        string victorySentence = "";

        public Form_Win()
        {
            InitializeComponent();
        }        

        /// <summary>
        /// Stores the name of the player that won the game
        /// </summary>
        public string Sentence
        {
            get
            {
                return victorySentence;
            }
            set
            {
                victorySentence = value;
            }
        }

        private void Form_Win_Load(object sender, EventArgs e)
        {
            ptbTrophee.ImageLocation = @"trophee.png";
            ptbTrophee.SizeMode = PictureBoxSizeMode.StretchImage;

            lblWin.Text = victorySentence;
        }

        private void cmdOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
