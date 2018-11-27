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

        public frmLaPomme()
        {
            InitializeComponent();
        }

        private void frmLaPomme_Load(object sender, EventArgs e)
        {
            form2.ShowDialog(); // Shows the second form
            playerNames = form2.GetPlayerNames(); // Used to store the player names

            lblPlayer1.Text = playerNames[0]; // Player 1 name
            lblPlayer2.Text = playerNames[1]; // Player 2 name

            /*string filePath = @"cards.csv";
            StreamReader streamReader = new StreamReader(filePath);

            var everybody = new List<Person>();

            while (!streamReader.EndOfStream)
            {
                string[] line = streamReader.ReadLine().Split(';');
                Person person = new Person(line[0], int.Parse(line[1]));
                List<int> responses = new List<int>();

                for (int i = 2; i < line.Length; i++)
                {
                    responses.Add(int.Parse(line[i]));
                }

                person.SetResponses(responses);
                everybody.Add(person);
            }*/
        }
    }
}
