using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_Pomme
{
    class Card
    {
        private int id;
        private string type;
        private string name;
        private int value;
        private int pointsWithoutAsset;
        private int pointsWithAsset;
        private string image;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="type"></param>
        /// <param name="name"></param>
        /// <param name="value"></param>
        /// <param name="pointsWithoutAsset"></param>
        /// <param name="pointsWithAsset"></param>
        /// <param name="image"></param>
        public Card(int id, string type, string name, int value, int pointsWithoutAsset, int pointsWithAsset, string image)
        {
            this.id = id;
            this.type = type;
            this.name = name;
            this.value = value;
            this.pointsWithoutAsset = pointsWithoutAsset;
            this.pointsWithAsset = pointsWithAsset;
            this.image = image;
        }

        /// <summary>
        /// Gets the value of the card
        /// </summary>
        /// <returns></returns>
        public int GetValue()
        {
            return value;
        }

        public string GetImage()
        {
            return image;
        }

        public int GetId()
        {
            return id;
        }
    }
}
