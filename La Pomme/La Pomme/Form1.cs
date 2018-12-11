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
        private string[] playerNames; // Contains the player 1 name (index 0) and the player 2 name (index 1)
        form2 form2 = new form2(); // Instanciate the second form to set the player names
        List<Card> cards = new List<Card>(); // Instanciate the cards list
        List<Card> player1Deck = new List<Card>(); // Instanciate the deck of the player 1
        List<Card> player2Deck = new List<Card>(); // Instanciate the deck of the player 2
        private Random random;
        private int playerTurn = 1; // Used to store the player turn
        private int nbPlayedCards = 0; // Used to store the number of the played cards

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

            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(';');
                Card card = new Card(int.Parse(line[0]), line[1], line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), line[6]); // Création de la carte
                card.MouseClick += new MouseEventHandler(CardClickEvent); // Add a clic event on the card

                cards.Add(card);
            }

            Shuffle(cards); // Call the shuffle function
            
            ptbAtout.ImageLocation = cards[0].GetImage(); // Set the asset card for the rest of the game
            cards.RemoveAt(0); // Remove the card from the main deck

            // Insert 9 cards to the player 1 deck
            for (int i = 0; i <= 8; i++)
            {
                cards[i].Name = cards[i].GetId().ToString();
                cards[i].ImageLocation = @cards[i].GetImage();
                cards[i].Size = new Size(75, 99);
                cards[i].SetPlayerCard(1);

                player1Deck.Add(cards[i]);
                flpPlayer1Deck.Controls.Add(cards[i]);
            }

            // Remove the cards from the main deck
            for(int i = 8; i >= 0; i--)
            {
                cards.RemoveAt(i);
            }

            // Insert 9 cards to the player 2 deck
            for (int i = 9; i <= 17; i++)
            {
                cards[i].Name = cards[i].GetId().ToString();
                cards[i].ImageLocation = @cards[i].GetImage();
                cards[i].Size = new Size(75, 99);
                cards[i].SetPlayerCard(2);

                player2Deck.Add(cards[i]);
                flpPlayer2Deck.Controls.Add(cards[i]);
            }

            // Remove the cards from the main deck
            for (int i = 17; i >= 9; i--)
            {
                cards.RemoveAt(i);
            }

            lblPlayer1.ForeColor = Color.Crimson;
            flpPlayer2Deck.Enabled = false; // Disable the player 2 deck because it's the player's 1 turn 
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

        /// <summary>
        /// Play the selected card
        /// </summary>
        /// <param name="player"></param>
        /// <param name="cardId"></param>
        public void PlayCard(int player, int cardId)
        {           
            if (playerTurn == 2)
            {
                foreach(Card card in player2Deck)
                {
                    if(card.GetId() == cardId)
                    {
                        flpJ2PlayedCard.Controls.Add(card);
                        flpPlayer2Deck.Controls.Remove(card);  
                    }
                }               
            }
            else
            {
                foreach(Card card in player1Deck)
                {
                    if(card.GetId() == cardId)
                    {
                        flpJ1PlayedCard.Controls.Add(card);
                        flpPlayer1Deck.Controls.Remove(card);
                    }
                }
            }

            nbPlayedCards++;
            SetPlayerTurn();

            // When the 2 players have played a card
            if (nbPlayedCards == 2)
            {
                CardBattle(); // Calls the card battle function when the second player played
                nbPlayedCards = 0;
            }
        }

        /// <summary>
        /// Card click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClickEvent(object sender, MouseEventArgs e)
        {
            PictureBox card = sender as PictureBox;
            int cardId = int.Parse(card.Name);
            PlayCard(playerTurn, cardId);
        }

        /// <summary>
        /// Shows to the players who can play and who can't
        /// </summary>
        public void SetPlayerTurn()
        {
            if (playerTurn == 1)
            {
                playerTurn = 2;
                
                flpPlayer1Deck.Enabled = false;
                flpPlayer2Deck.Enabled = true;

                lblPlayer1.ForeColor = Color.White;
                lblPlayer2.ForeColor = Color.Crimson;
            }
            else
            {
                playerTurn = 1;

                flpPlayer2Deck.Enabled = false;
                flpPlayer1Deck.Enabled = true;

                lblPlayer1.ForeColor = Color.Crimson;
                lblPlayer2.ForeColor = Color.White;
            } 
        }

        /// <summary>
        /// Test which card is the best and gives points to the player
        /// </summary>
        private void CardBattle()
        {
            
        }
    }
}
