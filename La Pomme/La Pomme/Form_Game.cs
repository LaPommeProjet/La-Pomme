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
        Form_PlayerNames form_PlayerNames = new Form_PlayerNames(); // Instanciate the second form to set the player names

        private string[] playerNames; // Contains the player 1 name (index 0) and the player 2 name (index 1)

        private List<Card> cards = new List<Card>(); // Instanciate the cards list

        private int firstPlayer = 2; // Used to store which player is starting
        private int playerTurn = 2; // Used to store the player turn
        private int nbPlayedCards = 0; // Used to store the number of the played cards
        private int nbJ1WonCards = 0; // Used to store the number of the player 1 won cards
        private int nbJ2WonCards = 0; // Used to store the number of the player 2 won cards
        private int j1Score = 0; // Used to store the score of the player 1
        private int j2Score = 0; // Used to store the score of the player 2

        private Random random;
                
        public frmLaPomme()
        {
            InitializeComponent();
            random = new Random(); // Instanciate the random class
        }

        private void frmLaPomme_Load(object sender, EventArgs e)
        {
            form_PlayerNames.ShowDialog(); // Shows the second form
            playerNames = form_PlayerNames.GetPlayerNames(); // Used to store the player names

            lblPlayer1.Text = playerNames[0]; // Player 1 name
            lblPlayer2.Text = playerNames[1]; // Player 2 name
           
            ImportCards();
            Shuffle(cards);
            SetAsset();
            SetPlayerDecks();
            SetPlayerTurn();
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
        /// Creates a list of cards from csv file
        /// </summary>
        public void ImportCards()
        {
            string filePath = @"cards.csv";
            StreamReader streamReader = new StreamReader(filePath);

            //Pour ne pas traiter l'entête
            streamReader.ReadLine();

            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(';');
                Card card = new Card(line[0], line[1], int.Parse(line[2]), int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), line[6]); // Création de la carte
                card.MouseClick += new MouseEventHandler(CardClickEvent); // Add a clic event on the card
                card.Cursor = Cursors.Hand;

                cards.Add(card);
            }
        }

        /// <summary>
        /// Set the asset card for the rest of the game
        /// </summary>
        public void SetAsset()
        {
            flpAssetCard.Controls.Add(cards[0]);
            flpAssetCard.Enabled = false;
            cards.RemoveAt(0); // Remove the card from the main deck
        }

        /// <summary>
        /// Make the player decks
        /// </summary>
        public void SetPlayerDecks()
        {
            // Insert 9 cards to the player 1 deck and remove them from the main deck
            for (int i = 8; i >= 0; i--)
            {
                flpPlayer1Deck.Controls.Add(cards[i]);
                cards.RemoveAt(i);
            }

            // Insert 9 cards to the player 2 deck and remove them from the main deck
            for (int i = 8; i >= 0; i--)
            {
                flpPlayer2Deck.Controls.Add(cards[i]);
                cards.RemoveAt(i);
            }
        }

        /// <summary>
        /// Plays the selected card
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClickEvent(object sender, MouseEventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if (playerTurn == 1)
            {
                flpJ1PlayedCard.Controls.Add(pictureBox);
                flpPlayer1Deck.Controls.Remove(pictureBox);
            }
            else
            {
                flpJ2PlayedCard.Controls.Add(pictureBox);
                flpPlayer2Deck.Controls.Remove(pictureBox);
            }

            nbPlayedCards++;
            SetPlayerTurn();

            // When the 2 players have played a card
            if (nbPlayedCards == 2)
            {
                CardBattle(); // Calls the card battle function when the second player played
                nbPlayedCards = 0;
            }
            else
            {
                CheckPlayedCard();
            }
        }

        /// <summary>
        /// Shows to the players who can play and who can't
        /// </summary>
        public void SetPlayerTurn()
        {
            if (playerTurn == 1)
            {
                flpPlayer1Deck.Enabled = false;
                flpPlayer2Deck.Enabled = true;

                lblPlayer1.ForeColor = Color.White;
                lblPlayer2.ForeColor = Color.Crimson;

                playerTurn = 2;
            }
            else
            {
                flpPlayer2Deck.Enabled = false;
                flpPlayer1Deck.Enabled = true;

                lblPlayer1.ForeColor = Color.Crimson;
                lblPlayer2.ForeColor = Color.White;

                playerTurn = 1;
            } 
        }

        /// <summary>
        /// Check the played card and only enable the same card type or asset type
        /// </summary>
        public void CheckPlayedCard()
        {
            bool deckContainsSameType = false;
            Card assetCard = flpAssetCard.Controls[0] as Card;

            if (playerTurn == 1)
            {
                foreach (PictureBox pictureBox in flpPlayer1Deck.Controls)
                {
                    Card card = pictureBox as Card;
                    Card j2PlayedCard = flpJ2PlayedCard.Controls[0] as Card;

                    if (card.CardType == j2PlayedCard.CardType)
                    {
                        deckContainsSameType = true;
                        card.Enabled = true;
                    }
                    else if(card.CardType == assetCard.CardType)
                    {
                        card.Enabled = true;
                    }  
                    else
                    {
                        card.Enabled = false;
                    }
                }

                if (deckContainsSameType == false)
                {
                    EnableJ1Deck();
                }

                foreach (PictureBox pictureBox in flpPlayer2Deck.Controls)
                {
                    pictureBox.Enabled = false;
                }
            }
            else
            {
                foreach (PictureBox pictureBox in flpPlayer2Deck.Controls)
                {
                    Card card = pictureBox as Card;
                    Card j1PlayedCard = flpJ1PlayedCard.Controls[0] as Card;

                    if (card.CardType == j1PlayedCard.CardType)
                    {
                        deckContainsSameType = true;
                        card.Enabled = true;
                    }
                    else if (card.CardType == assetCard.CardType)
                    {
                        card.Enabled = true;
                    }
                    else
                    {
                        card.Enabled = false;
                    }
                }

                if (deckContainsSameType == false)
                {
                    EnableJ2Deck();
                }

                foreach (PictureBox pictureBox in flpPlayer1Deck.Controls)
                {
                    pictureBox.Enabled = false;
                }
            }
        }

        /// <summary>
        /// Enables the whole cards of the player 1 deck
        /// </summary>
        private void EnableJ1Deck()
        {
            foreach (PictureBox pictureBox in flpPlayer1Deck.Controls)
            {
                pictureBox.Enabled = true;
            }
        }

        /// <summary>
        /// Enables the whole cards of the player 2 deck
        /// </summary>
        private void EnableJ2Deck()
        {
            foreach (PictureBox pictureBox in flpPlayer2Deck.Controls)
            {
                pictureBox.Enabled = true;
            }
        }

        /// <summary>
        /// Test which card is the best and gives points to the player
        /// </summary>
        private void CardBattle()
        {
            // Stores the pictureboxes controls as a card
            Card j1PlayedCard = flpJ1PlayedCard.Controls[0] as Card;
            Card j2PlayedCard = flpJ2PlayedCard.Controls[0] as Card;
            Card assetCard = flpAssetCard.Controls[0] as Card;

            bool isAssetJ1Card = false;
            bool isAssetJ2Card = false;           

            // Verify if the card is an asset
            if (j1PlayedCard.CardType == assetCard.CardType)
            {
                isAssetJ1Card = true;                    
            }

            if (j2PlayedCard.CardType == assetCard.CardType)
            {
                isAssetJ2Card = true;
            }

            if(isAssetJ1Card == true && isAssetJ2Card == true)
            {
                if (j1PlayedCard.ValueWithAsset > j2PlayedCard.ValueWithAsset)
                {
                    j1Score += j1PlayedCard.PointsWithAsset + j2PlayedCard.PointsWithAsset; // Stores the total of the won points
                    MakeJ1Score(j1Score); // Make the score of the player
                }
                else
                {
                    j2Score += j1PlayedCard.PointsWithAsset + j2PlayedCard.PointsWithAsset; // Stores the total of the won points
                    MakeJ2Score(j2Score); // Make the score of the player
                }
            }
            else if(isAssetJ1Card == true && isAssetJ2Card == false)
            {
                j1Score += j1PlayedCard.PointsWithAsset + j2PlayedCard.PointsWithoutAsset; // Stores the total of the won points
                MakeJ1Score(j1Score); // Make the score of the player
            }
            else if(isAssetJ1Card == false && isAssetJ2Card == true)
            {
                j2Score += j1PlayedCard.PointsWithoutAsset + j2PlayedCard.PointsWithAsset; // Stores the total of the won points
                MakeJ2Score(j2Score); // Make the score of the player
            }
            else 
            {
                if (j1PlayedCard.CardType == j2PlayedCard.CardType)
                {
                    if(j1PlayedCard.ValueWithoutAsset > j2PlayedCard.ValueWithoutAsset)
                    {
                        j1Score += j1PlayedCard.PointsWithoutAsset + j2PlayedCard.PointsWithoutAsset; // Stores the total of the won points
                        MakeJ1Score(j1Score); // Make the score of the player
                    }
                    else
                    {
                        j2Score += j1PlayedCard.PointsWithoutAsset + j2PlayedCard.PointsWithoutAsset; // Stores the total of the won points
                        MakeJ2Score(j2Score); // Make the score of the player
                    }
                }
                else
                {
                    if(firstPlayer == 1)
                    {
                        j1Score += j1PlayedCard.PointsWithoutAsset + j2PlayedCard.PointsWithoutAsset; // Stores the total of the won points
                        MakeJ1Score(j1Score); // Make the score of the player
                    }
                    else
                    {
                        j2Score += j1PlayedCard.PointsWithoutAsset + j2PlayedCard.PointsWithoutAsset; // Stores the total of the won points
                        MakeJ2Score(j2Score); // Make the score of the player
                    }
                }
            }

            CheckForIllegalCrossThreadCalls = false; // To make disapear the two cards at the same time

            Task.Delay(1).ContinueWith(t => EndCardBattle()); // Delay before clearing the table
        }

        /// <summary>
        /// Make the score of the player 1 and shows it
        /// </summary>
        /// <param name="score"></param>
        public void MakeJ1Score(int score)
        {
            nbJ1WonCards += 2;
            lblCartesGagneesJ1.Text = "Cartes gagnées : " + nbJ1WonCards.ToString(); // Shows the player 1 won cards
            lblScoreJ1.Text = "Score : " + score.ToString() + " pts"; // Shows the player 1 score

            firstPlayer = 1; // To know which player won
        }

        /// <summary>
        /// Make the score of the player 2 and shows it
        /// </summary>
        /// <param name="score"></param>
        public void MakeJ2Score(int score)
        {
            nbJ2WonCards += 2;
            lblCartesGagneesJ2.Text = "Cartes gagnées : " + nbJ2WonCards.ToString(); // Shows the player 2 won cards
            lblScoreJ2.Text = "Score : " + score.ToString() + " pts"; // Shows the player 2 score

            firstPlayer = 2; // To know which player won
        }

        /// <summary>
        /// Clear the played cards
        /// </summary>
        public void EndCardBattle()
        {
            // Clear the played cards 
            flpJ1PlayedCard.Controls.RemoveAt(0);
            flpJ2PlayedCard.Controls.RemoveAt(0);

            if(flpPlayer1Deck.Controls.Count == 0)
            {
                Form_Win form_Win = new Form_Win();
                string victorySentence;

                if(j1Score == j2Score)
                {
                    victorySentence = "Egalité des 2 joueurs avec " + j1Score.ToString() + " points et " + nbJ1WonCards.ToString() + " cartes gagnées !";
                }
                else
                {
                    if (j1Score > j2Score)
                    {
                        victorySentence = playerNames[0] + " a gagné avec un total de " + j1Score.ToString() + " points et " + nbJ1WonCards.ToString() + " cartes gagnées !";
                    }
                    else
                    {
                        victorySentence = playerNames[1] + " a gagné avec un total de " + j2Score.ToString() + " points et " + nbJ2WonCards.ToString() + " cartes gagnées !";
                    }
                }

                form_Win.Sentence = victorySentence;
                form_Win.ShowDialog();                
                
                Close();
            }
            else
            {
                // Set which player will start next turn
                if (firstPlayer == 1)
                {
                    playerTurn = 2;                   
                }
                else
                {
                    playerTurn = 1;                   
                }

                EnableJ1Deck();
                EnableJ2Deck();

                SetPlayerTurn();
            }
        }
    }
}
