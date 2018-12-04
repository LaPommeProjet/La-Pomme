namespace La_Pomme
{
    partial class frmLaPomme
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLaPomme));
            this.lblPioche = new System.Windows.Forms.Label();
            this.lblAtout = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblCartesGagneesJ1 = new System.Windows.Forms.Label();
            this.lblCartesGagneesJ2 = new System.Windows.Forms.Label();
            this.ptbScoreJ2 = new System.Windows.Forms.PictureBox();
            this.ptbPioche = new System.Windows.Forms.PictureBox();
            this.ptbAtout = new System.Windows.Forms.PictureBox();
            this.ptbScoreJ1 = new System.Windows.Forms.PictureBox();
            this.lblScoreJ1 = new System.Windows.Forms.Label();
            this.lblScoreJ2 = new System.Windows.Forms.Label();
            this.ptbJ2PlayedCard = new System.Windows.Forms.PictureBox();
            this.ptbJ1PlayedCard = new System.Windows.Forms.PictureBox();
            this.flpPlayer2Deck = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer1Deck = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbScoreJ2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPioche)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtout)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbScoreJ1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJ2PlayedCard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJ1PlayedCard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPioche
            // 
            this.lblPioche.AutoSize = true;
            this.lblPioche.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPioche.ForeColor = System.Drawing.Color.White;
            this.lblPioche.Location = new System.Drawing.Point(675, 222);
            this.lblPioche.Name = "lblPioche";
            this.lblPioche.Size = new System.Drawing.Size(50, 16);
            this.lblPioche.TabIndex = 12;
            this.lblPioche.Text = "Pioche";
            // 
            // lblAtout
            // 
            this.lblAtout.AutoSize = true;
            this.lblAtout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAtout.ForeColor = System.Drawing.Color.White;
            this.lblAtout.Location = new System.Drawing.Point(518, 222);
            this.lblAtout.Name = "lblAtout";
            this.lblAtout.Size = new System.Drawing.Size(38, 16);
            this.lblAtout.TabIndex = 13;
            this.lblAtout.Text = "Atout";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(12, 122);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(45, 16);
            this.lblPlayer2.TabIndex = 14;
            this.lblPlayer2.Text = "label1";
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(12, 431);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(45, 16);
            this.lblPlayer1.TabIndex = 15;
            this.lblPlayer1.Text = "label1";
            // 
            // lblCartesGagneesJ1
            // 
            this.lblCartesGagneesJ1.AutoSize = true;
            this.lblCartesGagneesJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartesGagneesJ1.ForeColor = System.Drawing.Color.White;
            this.lblCartesGagneesJ1.Location = new System.Drawing.Point(799, 454);
            this.lblCartesGagneesJ1.Name = "lblCartesGagneesJ1";
            this.lblCartesGagneesJ1.Size = new System.Drawing.Size(120, 16);
            this.lblCartesGagneesJ1.TabIndex = 17;
            this.lblCartesGagneesJ1.Text = "Cartes gagnées : 0";
            // 
            // lblCartesGagneesJ2
            // 
            this.lblCartesGagneesJ2.AutoSize = true;
            this.lblCartesGagneesJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCartesGagneesJ2.ForeColor = System.Drawing.Color.White;
            this.lblCartesGagneesJ2.Location = new System.Drawing.Point(799, 15);
            this.lblCartesGagneesJ2.Name = "lblCartesGagneesJ2";
            this.lblCartesGagneesJ2.Size = new System.Drawing.Size(120, 16);
            this.lblCartesGagneesJ2.TabIndex = 18;
            this.lblCartesGagneesJ2.Text = "Cartes gagnées : 0";
            // 
            // ptbScoreJ2
            // 
            this.ptbScoreJ2.Image = ((System.Drawing.Image)(resources.GetObject("ptbScoreJ2.Image")));
            this.ptbScoreJ2.Location = new System.Drawing.Point(925, 12);
            this.ptbScoreJ2.Name = "ptbScoreJ2";
            this.ptbScoreJ2.Size = new System.Drawing.Size(75, 99);
            this.ptbScoreJ2.TabIndex = 16;
            this.ptbScoreJ2.TabStop = false;
            // 
            // ptbPioche
            // 
            this.ptbPioche.Image = ((System.Drawing.Image)(resources.GetObject("ptbPioche.Image")));
            this.ptbPioche.Location = new System.Drawing.Point(663, 241);
            this.ptbPioche.Name = "ptbPioche";
            this.ptbPioche.Size = new System.Drawing.Size(75, 99);
            this.ptbPioche.TabIndex = 11;
            this.ptbPioche.TabStop = false;
            // 
            // ptbAtout
            // 
            this.ptbAtout.Image = ((System.Drawing.Image)(resources.GetObject("ptbAtout.Image")));
            this.ptbAtout.Location = new System.Drawing.Point(501, 241);
            this.ptbAtout.Name = "ptbAtout";
            this.ptbAtout.Size = new System.Drawing.Size(75, 99);
            this.ptbAtout.TabIndex = 10;
            this.ptbAtout.TabStop = false;
            // 
            // ptbScoreJ1
            // 
            this.ptbScoreJ1.Image = ((System.Drawing.Image)(resources.GetObject("ptbScoreJ1.Image")));
            this.ptbScoreJ1.Location = new System.Drawing.Point(925, 450);
            this.ptbScoreJ1.Name = "ptbScoreJ1";
            this.ptbScoreJ1.Size = new System.Drawing.Size(75, 99);
            this.ptbScoreJ1.TabIndex = 10;
            this.ptbScoreJ1.TabStop = false;
            // 
            // lblScoreJ1
            // 
            this.lblScoreJ1.AutoSize = true;
            this.lblScoreJ1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreJ1.ForeColor = System.Drawing.Color.White;
            this.lblScoreJ1.Location = new System.Drawing.Point(799, 485);
            this.lblScoreJ1.Name = "lblScoreJ1";
            this.lblScoreJ1.Size = new System.Drawing.Size(89, 16);
            this.lblScoreJ1.TabIndex = 19;
            this.lblScoreJ1.Text = "Score : 0 pt(s)";
            // 
            // lblScoreJ2
            // 
            this.lblScoreJ2.AutoSize = true;
            this.lblScoreJ2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScoreJ2.ForeColor = System.Drawing.Color.White;
            this.lblScoreJ2.Location = new System.Drawing.Point(799, 48);
            this.lblScoreJ2.Name = "lblScoreJ2";
            this.lblScoreJ2.Size = new System.Drawing.Size(89, 16);
            this.lblScoreJ2.TabIndex = 20;
            this.lblScoreJ2.Text = "Score : 0 pt(s)";
            // 
            // ptbJ2PlayedCard
            // 
            this.ptbJ2PlayedCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbJ2PlayedCard.Location = new System.Drawing.Point(215, 159);
            this.ptbJ2PlayedCard.Name = "ptbJ2PlayedCard";
            this.ptbJ2PlayedCard.Size = new System.Drawing.Size(75, 99);
            this.ptbJ2PlayedCard.TabIndex = 21;
            this.ptbJ2PlayedCard.TabStop = false;
            // 
            // ptbJ1PlayedCard
            // 
            this.ptbJ1PlayedCard.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ptbJ1PlayedCard.Location = new System.Drawing.Point(215, 309);
            this.ptbJ1PlayedCard.Name = "ptbJ1PlayedCard";
            this.ptbJ1PlayedCard.Size = new System.Drawing.Size(75, 99);
            this.ptbJ1PlayedCard.TabIndex = 22;
            this.ptbJ1PlayedCard.TabStop = false;
            // 
            // flpPlayer2Deck
            // 
            this.flpPlayer2Deck.Location = new System.Drawing.Point(12, 12);
            this.flpPlayer2Deck.Name = "flpPlayer2Deck";
            this.flpPlayer2Deck.Size = new System.Drawing.Size(736, 107);
            this.flpPlayer2Deck.TabIndex = 10;
            // 
            // flpPlayer1Deck
            // 
            this.flpPlayer1Deck.Location = new System.Drawing.Point(12, 447);
            this.flpPlayer1Deck.Name = "flpPlayer1Deck";
            this.flpPlayer1Deck.Size = new System.Drawing.Size(736, 107);
            this.flpPlayer1Deck.TabIndex = 8;
            // 
            // frmLaPomme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(1012, 561);
            this.Controls.Add(this.ptbJ1PlayedCard);
            this.Controls.Add(this.ptbJ2PlayedCard);
            this.Controls.Add(this.lblScoreJ2);
            this.Controls.Add(this.lblScoreJ1);
            this.Controls.Add(this.lblCartesGagneesJ2);
            this.Controls.Add(this.lblCartesGagneesJ1);
            this.Controls.Add(this.ptbScoreJ2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblAtout);
            this.Controls.Add(this.lblPioche);
            this.Controls.Add(this.ptbPioche);
            this.Controls.Add(this.flpPlayer1Deck);
            this.Controls.Add(this.flpPlayer2Deck);
            this.Controls.Add(this.ptbAtout);
            this.Controls.Add(this.ptbScoreJ1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmLaPomme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "La Pomme";
            this.Load += new System.EventHandler(this.frmLaPomme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbScoreJ2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPioche)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbAtout)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbScoreJ1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJ2PlayedCard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbJ1PlayedCard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox ptbAtout;
        private System.Windows.Forms.PictureBox ptbPioche;
        private System.Windows.Forms.Label lblPioche;
        private System.Windows.Forms.Label lblAtout;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.PictureBox ptbScoreJ1;
        private System.Windows.Forms.PictureBox ptbScoreJ2;
        private System.Windows.Forms.Label lblCartesGagneesJ1;
        private System.Windows.Forms.Label lblCartesGagneesJ2;
        private System.Windows.Forms.Label lblScoreJ1;
        private System.Windows.Forms.Label lblScoreJ2;
        private System.Windows.Forms.PictureBox ptbJ2PlayedCard;
        private System.Windows.Forms.PictureBox ptbJ1PlayedCard;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer2Deck;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer1Deck;
    }
}

