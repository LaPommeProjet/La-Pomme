using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Pomme
{
    class Card : PictureBox
    {
        private int id;
        private string type;
        private string name;
        private int valueWithAsset;
        private int valueWithoutAsset;
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
        public Card(int id, string type, string name, int valueWithoutAsset, int valueWithAsset, int pointsWithoutAsset, int pointsWithAsset, string image)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.valueWithoutAsset = valueWithoutAsset;
            this.valueWithAsset = valueWithAsset;
            this.pointsWithoutAsset = pointsWithoutAsset;
            this.pointsWithAsset = pointsWithAsset;
            this.image = image;
        }  

        /// <summary>
        /// Gets the id of the card
        /// </summary>
        /// <returns></returns>
        public int GetId()
        {
            return id;
        }

        /// <summary>
        /// Gets the value without asset of the card
        /// </summary>
        /// <returns></returns>
        public int GetCardValueWithoutAsset()
        {
            return valueWithoutAsset;
        }

        /// <summary>
        /// Gets the value with asset of the card
        /// </summary>
        /// <returns></returns>
        public int GetCardValueWithAsset()
        {
            return valueWithAsset;
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

        public int GetPointsWithoutAsset()
        {
            return pointsWithoutAsset;
        }

        public int GetPointsWithAsset()
        {
            return pointsWithAsset;
        }
    }
}
