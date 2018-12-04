﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Pomme
{
    class Card : PictureBox
    {
        private string type;
        private string name;
        private int value;
        private int pointsWithoutAsset;
        private int pointsWithAsset;
        private string image;
        private int player;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="pointsWithoutAsset"></param>
        /// <param name="pointsWithAsset"></param>
        /// <param name="image"></param>
        public Card(string type, string name, int value, int pointsWithoutAsset, int pointsWithAsset, string image)
        {
            this.type = type;
            this.name = name;
            this.value = value;
            this.pointsWithoutAsset = pointsWithoutAsset;
            this.pointsWithAsset = pointsWithAsset;
            this.image = image;

            this.MouseClick += new MouseEventHandler(CardClickEvent); // Add a clic event on the card
        }

        private void CardClickEvent(object sender, MouseEventArgs e)
        {
            PlayCard(player);
            Console.WriteLine(type + " " + name + " Clicked");
        }   

        /// <summary>
        /// Gets the value of the card
        /// </summary>
        /// <returns></returns>
        public int GetValue()
        {
            return value;
        }

        /// <summary>
        /// Get the image URL of the card
        /// </summary>
        /// <returns></returns>
        public string GetImage()
        {
            return image;
        }

        /// <summary>
        /// Get the name of the card
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }

        /// <summary>
        /// Get the type of the card
        /// </summary>
        /// <returns></returns>
        public string GetCardType()
        {
            return type;
        }

        /// <summary>
        /// Set the player that has the card
        /// </summary>
        /// <param name="playerName"></param>
        public void SetPlayerCard(int player)
        {
            this.player = player;
        }
    }
}
