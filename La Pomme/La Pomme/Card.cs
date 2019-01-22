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
        private const int CARD_HEIGHT = 99;
        private const int CARD_WIDTH = 75;

        private string type;
        private string name;
        private string image;
        private int valueWithAsset;
        private int valueWithoutAsset;
        private int pointsWithoutAsset;
        private int pointsWithAsset;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="pointsWithoutAsset"></param>
        /// <param name="pointsWithAsset"></param>
        /// <param name="image"></param>
        public Card(string type, string name, int valueWithoutAsset, int valueWithAsset, int pointsWithoutAsset, int pointsWithAsset, string image)
        {
            this.type = type;
            this.name = name;
            this.valueWithoutAsset = valueWithoutAsset;
            this.valueWithAsset = valueWithAsset;
            this.pointsWithoutAsset = pointsWithoutAsset;
            this.pointsWithAsset = pointsWithAsset;
            this.image = image;
            this.ImageLocation = image;
            this.Height = CARD_HEIGHT;
            this.Width = CARD_WIDTH;
        }  

        /// <summary>
        /// Get the value without asset of the card
        /// </summary>
        /// <returns></returns>
        public int ValueWithoutAsset
        {
            get { return valueWithoutAsset; }
        }

        /// <summary>
        /// Get the value with asset of the card
        /// </summary>
        /// <returns></returns>
        public int ValueWithAsset
        {
            get { return valueWithAsset; }
        }

        /// <summary>
        /// Get the name of the card
        /// </summary>
        /// <returns></returns>
        public string CardName
        {
            get { return name; }
        }

        /// <summary>
        /// Get the type of the card
        /// </summary>
        /// <returns></returns>
        public string CardType
        {
            get { return type; }
        }

        /// <summary>
        /// Gets the points of the card
        /// </summary>
        /// <returns></returns>
        public int PointsWithoutAsset
        {
            get { return pointsWithoutAsset; }
        }

        /// <summary>
        /// Get the points of the card if it is an asset
        /// </summary>
        /// <returns></returns>
        public int PointsWithAsset
        {
            get { return pointsWithAsset; }
        }

        /// <summary>
        /// Get the image location of the card
        /// </summary>
        public string GetImage
        {
            get { return image; }
        }
    }
}
