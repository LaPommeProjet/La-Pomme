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

        /// <summary>
        /// Leave the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdLeave_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Play again
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmdPlayAgain_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
}
