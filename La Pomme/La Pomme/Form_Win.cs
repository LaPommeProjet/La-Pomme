using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace La_Pomme
{
    public partial class Form_Win : Form
    {
        public Form_Win()
        {
            InitializeComponent();
        }

        private void Form_Win_Load(object sender, EventArgs e)
        {
            ptbCup.ImageLocation = "cup.png";
        }
    }
}
