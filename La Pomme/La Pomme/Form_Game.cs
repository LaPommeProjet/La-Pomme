﻿using System;
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
        private List<Card> player1Deck = new List<Card>(); // Instanciate the deck of the player 1
        private List<Card> player2Deck = new List<Card>(); // Instanciate the deck of the player 2
        private List<Card> j1PlayedCard = new List<Card>(); // Used to store the played card of the player 1
        private List<Card> j2PlayedCard = new List<Card>(); // Used to store the played card of the player 2
        private List<Card> assetCard = new List<Card>(); // Used to store the asset card

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

            string filePath = @"cards.csv";
            StreamReader streamReader = new StreamReader(filePath);

            //Pour ne pas traiter l'entête
            streamReader.ReadLine();

            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(';');
                Card card = new Card(int.Parse(line[0]), line[1], line[2], int.Parse(line[3]), int.Parse(line[4]), int.Parse(line[5]), int.Parse(line[6]), line[7]); // Création de la carte
                card.MouseClick += new MouseEventHandler(CardClickEvent); // Add a clic event on the card

                cards.Add(card);
            }

            Shuffle(cards); // Call the shuffle function

            assetCard.Add(cards[0]); // Set the asset card for the rest of the game
            ptbAtout.ImageLocation = cards[0].GetImage(); // Set the image of the asset for the rest of the game
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
        /// Card click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CardClickEvent(object sender, MouseEventArgs e)
        {
            PictureBox card = sender as PictureBox;
            int cardId = int.Parse(card.Name);
            PlayCard(cardId);
        }

        /// <summary>
        /// Play the selected card
        /// </summary>
        /// <param name="player"></param>
        /// <param name="cardId"></param>
        public void PlayCard(int cardId)
        {           
            if (playerTurn == 1)
            {
                foreach (Card card in player1Deck)
                {
                    if (card.GetId() == cardId)
                    {
                        j1PlayedCard.Add(card);
                        flpJ1PlayedCard.Controls.Add(card);
                        flpPlayer1Deck.Controls.Remove(card);
                    }
                }
            }
            else
            {
                foreach (Card card in player2Deck)
                {
                    if (card.GetId() == cardId)
                    {
                        j2PlayedCard.Add(card);
                        flpJ2PlayedCard.Controls.Add(card);
                        flpPlayer2Deck.Controls.Remove(card);
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
        /// Test which card is the best and gives points to the player
        /// </summary>
        private void CardBattle()
        {
            // Locks the decks
            flpPlayer1Deck.Enabled = false;
            flpPlayer2Deck.Enabled = false;

            bool isAssetJ1Card = false;
            bool isAssetJ2Card = false;           

            if (j1PlayedCard[0].GetCardType() == assetCard[0].GetCardType())
            {
                isAssetJ1Card = true;                    
            }

            if (j2PlayedCard[0].GetCardType() == assetCard[0].GetCardType())
            {
                isAssetJ2Card = true;
            }

            if(isAssetJ1Card == true && isAssetJ2Card == true)
            {
                if (j1PlayedCard[0].GetCardValueWithAsset() > j2PlayedCard[0].GetCardValueWithAsset())
                {
                    j1Score += j1PlayedCard[0].GetPointsWithAsset() + j2PlayedCard[0].GetPointsWithAsset(); // Stores the total of the won points
                    MakeJ1Score(j1Score); // Make the score of the player
                }
                else
                {
                    j2Score += j1PlayedCard[0].GetPointsWithAsset() + j2PlayedCard[0].GetPointsWithAsset(); // Stores the total of the won points
                    MakeJ2Score(j2Score); // Make the score of the player
                }
            }
            else if(isAssetJ1Card == true && isAssetJ2Card == false)
            {
                j1Score += j1PlayedCard[0].GetPointsWithAsset() + j2PlayedCard[0].GetPointsWithoutAsset(); // Stores the total of the won points
                MakeJ1Score(j1Score); // Make the score of the player
            }
            else if(isAssetJ1Card == false && isAssetJ2Card == true)
            {
                j2Score += j1PlayedCard[0].GetPointsWithoutAsset() + j2PlayedCard[0].GetPointsWithAsset(); // Stores the total of the won points
                MakeJ2Score(j2Score); // Make the score of the player
            }
            else 
            {
                if (j1PlayedCard[0].GetCardType() == j2PlayedCard[0].GetCardType())
                {
                    if(j1PlayedCard[0].GetCardValueWithoutAsset() > j2PlayedCard[0].GetCardValueWithoutAsset())
                    {
                        j1Score += j1PlayedCard[0].GetPointsWithoutAsset() + j2PlayedCard[0].GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ1Score(j1Score); // Make the score of the player
                    }
                    else
                    {
                        j2Score += j1PlayedCard[0].GetPointsWithoutAsset() + j2PlayedCard[0].GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ2Score(j2Score); // Make the score of the player
                    }
                }
                else
                {
                    if(firstPlayer == 1)
                    {
                        j1Score += j1PlayedCard[0].GetPointsWithoutAsset() + j2PlayedCard[0].GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ1Score(j1Score); // Make the score of the player
                    }
                    else
                    {
                        j2Score += j1PlayedCard[0].GetPointsWithoutAsset() + j2PlayedCard[0].GetPointsWithoutAsset(); // Stores the total of the won points
                        MakeJ2Score(j2Score); // Make the score of the player
                    }
                }
            }

            CheckForIllegalCrossThreadCalls = false; // To make disapear the two cards at the same time

            Task.Delay(5).ContinueWith(t => EndCardBattle()); // Delay before clearing the table
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
            // Clear the list
            j1PlayedCard.RemoveAt(0);
            j2PlayedCard.RemoveAt(0);

            // Clear the cards (visual)
            flpJ1PlayedCard.Controls.Clear();
            flpJ2PlayedCard.Controls.Clear();

            if(flpPlayer1Deck.Controls.Count == 0 && flpPlayer2Deck.Controls.Count == 0)
            {
                Form_Win form_Win = new Form_Win();

                form_Win.ShowDialog();
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

                SetPlayerTurn();
            }
        }
    }
}