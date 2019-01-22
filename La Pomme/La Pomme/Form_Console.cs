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
        private const int HEIGHT = 80;
        private const int WIDTH = 56;      

        public Form_Console()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Set the labels with the names
        /// </summary>
        /// <param name="names"></param>
        public void SetNames(string[] names)
        {
            lblPlayer1.Text = names[0];
            lblPlayer2.Text = names[1];
        }

        /// <summary>
        /// Shows the played card
        /// </summary>
        /// <param name="player"></param>
        /// <param name="card"></param>
        public void ShowCard(int player, string card)
        {
            PictureBox pictureBox = new PictureBox();
            pictureBox.ImageLocation = card;
            pictureBox.Height = HEIGHT;
            pictureBox.Width = WIDTH;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            if (player == 1)
            {
                flpPlayer1.Controls.Add(pictureBox);
            }
            else
            {
                flpPlayer2.Controls.Add(pictureBox);
            }
        }       

        /// <summary>
        /// Shows which card won
        /// </summary>
        /// <param name="player"></param>
        public void ShowWinCard(int player)
        {
            PictureBox win = new PictureBox();
            PictureBox lose = new PictureBox();

            win.ImageLocation = @"vu.png";
            win.Height = HEIGHT;
            win.Width = WIDTH;
            win.SizeMode = PictureBoxSizeMode.StretchImage;

            lose.ImageLocation = @"croix.png";
            lose.Height = HEIGHT;
            lose.Width = WIDTH;
            lose.SizeMode = PictureBoxSizeMode.StretchImage;

            if (player == 1)
            {
                flpP1Result.Controls.Add(win);
                flpP2Result.Controls.Add(lose);     
            }
            else
            {
                flpP1Result.Controls.Add(lose);
                flpP2Result.Controls.Add(win);
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
    }
}
