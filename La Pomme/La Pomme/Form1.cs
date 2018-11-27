using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace La_Pomme
{
    public partial class frmLaPomme : Form
    {
        string[] playerNames; // Contains the player 1 name (index 0) and the player 2 name (index 1)
        form2 form2 = new form2(); // Instanciate the second form to set the player names
        List<Card> cards = new List<Card>(); // Instanciate the cards list
        List<Card> player1Deck = new List<Card>(); // Instanciate the deck of the player 1
        List<Card> player2Deck = new List<Card>(); // Instanciate the deck of the player 2
        private Random random;

        public frmLaPomme()
        {
            InitializeComponent();
            random = new Random(); // Instanciate the random class
        }

        private void frmLaPomme_Load(object sender, EventArgs e)
        {
            form2.ShowDialog(); // Shows the second form
            playerNames = form2.GetPlayerNames(); // Used to store the player names

            lblPlayer1.Text = playerNames[0]; // Player 1 name
            lblPlayer2.Text = playerNames[1]; // Player 2 name

            string filePath = @"cards.csv";
            StreamReader streamReader = new StreamReader(filePath);

            //Pour ne pas traiter l'entête
            streamReader.ReadLine();

            int id = 0; // To set the card id

            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(';');
                Card card = new Card(id, line[0], line[1], int.Parse(line[2]), int.Parse(line[3]), int.Parse(line[4]), line[5]);

                cards.Add(card);
                id++;
            }

            Shuffle(cards); // Call the shuffle function

            // Insert 9 cards to the player 1 deck
            for(int i = 0; i <= 8; i++)
            {
                PictureBox picture = new PictureBox();               
                picture.ImageLocation = @cards[i].GetImage();
                picture.Size = new Size(75, 99);
                flpPlayer1Deck.Controls.Add(picture);
            }

            // Remove the cards from the main deck and put them to the player 1 deck
            for(int i = 8; i >= 0; i--)
            {
                player1Deck.Add(cards[i]);
                cards.RemoveAt(i);
            }

            // Insert 9 cards to the player 2 deck
            for (int i = 9; i <= 17; i++)
            {
                PictureBox picture = new PictureBox();
                picture.Name = cards[i].GetId().ToString();
                picture.ImageLocation = @"dos.gif"; // The player 2 deck is hided
                picture.Size = new Size(75, 99);
                flpPlayer2Deck.Controls.Add(picture);
            }

            // Remove the cards from the main deck and put them to the player 2 deck
            for (int i = 17; i >= 9; i--)
            {
                player2Deck.Add(cards[i]);
                cards.RemoveAt(i);
            }
        }

        /// <summary>
        /// Shuffle the cards list
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="list"></param>
        public void Shuffle<T>(List<T> list)
        {
            int listLength = list.Count;

            while (listLength > 1)
            {
                listLength--;
                int randomIndex = random.Next(listLength + 1);
                T value = list[randomIndex];
                list[randomIndex] = list[listLength];
                list[listLength] = value;
            }
        }
    }
}
