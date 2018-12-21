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

        private int firstPlayer = 1; // Used to store which player is starting
        private int playerTurn = 1; // Used to store the player turn
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
            

            flpJ1PlayedCard.Enabled = false; // The played card can't be touched
            flpJ2PlayedCard.Enabled = false; // The played card can't be touched

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

                    if (card.GetCardType() == j2PlayedCard.GetCardType())
                    {
                        deckContainsSameType = true;
                        card.Enabled = true;
                    }
                    else if(card.GetCardType() == assetCard.GetCardType())
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
            }
            else
            {
                foreach (PictureBox pictureBox in flpPlayer2Deck.Controls)
                {
                    Card card = pictureBox as Card;
                    Card j1PlayedCard = flpJ1PlayedCard.Controls[0] as Card;

                    if (card.GetCardType() == j1PlayedCard.GetCardType())
                    {
                        deckContainsSameType = true;
                        card.Enabled = true;
                    }
                    else if (card.GetCardType() == assetCard.GetCardType())
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
            // Locks the decks
            flpPlayer1Deck.Enabled = false;
            flpPlayer2Deck.Enabled = false;

            // Stores the pictureboxs controls as a card
            Card j1PlayedCard = flpJ1PlayedCard.Controls[0] as Card; 
            Card j2PlayedCard = flpJ2PlayedCard.Controls[0] as Card;
            Card assetCard = flpAssetCard.Controls[0] as Card;

            bool isAssetJ1Card = false;
            bool isAssetJ2Card = false;           

            if (j1PlayedCard.GetCardType() == assetCard.GetCardType())
            {
                isAssetJ1Card = true;                    
            }

            if (j2PlayedCard.GetCardType() == assetCard.GetCardType())
            {
                isAssetJ2Card = true;
            }

            if(isAssetJ1Card == true && isAssetJ2Card == true)
            {
                if (j1PlayedCard.GetCardValueWithAsset() > j2PlayedCard.GetCardValueWithAsset())
                {
                    j1Score += j1PlayedCard.GetPointsWithAsset() + j2PlayedCard.GetPointsWithAsset(); // Stores the total of the won points
                    MakeJ1Score(j1Score); // Make the score of the player
                }
                else
                {
                    j2Score += j1PlayedCard.GetPointsWithAsset() + j2PlayedCard.GetPointsWithAsset(); // Stores the total of the won points
                    MakeJ2Score(j2Score); // Make the score of the player
                }
            }
            else if(isAssetJ1Card == true && isAssetJ2Card == false)
            {
                j1Score += j1PlayedCard.GetPointsWithAsset() + j2PlayedCard.GetPointsWithoutAsset(); // Stores the total of the won points
                MakeJ1Score(j1Score); // Make the score of the player
            }
            else if(isAssetJ1Card == false && isAssetJ2Card == true)
            {
                j2Score += j1PlayedCard.GetPointsWithoutAsset() + j2PlayedCard.GetPointsWithAsset(); // Stores the total of the won points
                MakeJ2Score(j2Score); // Make the score of the player
            }
            else 
            {
                if (j1PlayedCard.GetCardType() == j2PlayedCard.GetCardType())
                {
                    if(j1PlayedCard.GetCardValueWithoutAsset() > j2PlayedCard.GetCardValueWithoutAsset())
                    {
                        j1Score += j1PlayedCard.GetPointsWithoutAsset() + j2PlayedCard.GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ1Score(j1Score); // Make the score of the player
                    }
                    else
                    {
                        j2Score += j1PlayedCard.GetPointsWithoutAsset() + j2PlayedCard.GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ2Score(j2Score); // Make the score of the player
                    }
                }
                else
                {
                    if(firstPlayer == 1)
                    {
                        j1Score += j1PlayedCard.GetPointsWithoutAsset() + j2PlayedCard.GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ1Score(j1Score); // Make the score of the player
                    }
                    else
                    {
                        j2Score += j1PlayedCard.GetPointsWithoutAsset() + j2PlayedCard.GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ2Score(j2Score); // Make the score of the player
                    }
                }
            }

            CheckForIllegalCrossThreadCalls = false; // To make disapear the two cards at the same time

            Task.Delay(1).ContinueWith(t => EndCardBattle()); // Delay before clearing the table
        }

        public void MakeJ1Score(int score)
        {
            nbJ1WonCards += 2;
            lblCartesGagneesJ1.Text = "Cartes gagnées : " + nbJ1WonCards.ToString(); // Shows the player 1 won cards
            lblScoreJ1.Text = "Score : " + score.ToString() + " pts"; // Shows the player 1 score

            firstPlayer = 1; // To know which player won
        }

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
            flpJ1PlayedCard.Controls.Clear();
            flpJ2PlayedCard.Controls.Clear();

            if(flpPlayer1Deck.Controls.Count == 0)
            {
                string victoryName = "";
                string victoryPoints = "";
                string victoryCards = "";

                if(j1Score > j2Score)
                {
                    victoryName = playerNames[0];
                    victoryPoints = j1Score.ToString();
                    victoryCards = nbJ1WonCards.ToString();
                }
                else
                {
                    victoryName = playerNames[1];
                    victoryPoints = j2Score.ToString();
                    victoryCards = nbJ2WonCards.ToString();
                }

                MessageBox.Show("Victoire de " + victoryName + " qui a fait " + victoryPoints + " points en collectant " + victoryCards + " cartes!");

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
