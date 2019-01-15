namespace La_Pomme
{
    partial class Form_Win
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdOk = new System.Windows.Forms.Button();
            this.ptbTrophee = new System.Windows.Forms.PictureBox();
            this.lblWin = new System.Windows.Forms.Label();
            this.lblWinTitle = new System.Windows.Forms.Label();
            this.cmdPlayAgain = new System.Windows.Forms.Button();
            this.cmdLeave = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTrophee)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdOk
            // 
            this.cmdOk.Location = new System.Drawing.Point(559, 160);
            this.cmdOk.Name = "cmdOk";
            this.cmdOk.Size = new System.Drawing.Size(120, 23);
            this.cmdOk.TabIndex = 1;
            this.cmdOk.Text = "Ok";
            this.cmdOk.UseVisualStyleBackColor = true;
            this.cmdOk.Click += new System.EventHandler(this.cmdOk_Click);
            // 
            // ptbTrophee
            // 
            this.ptbTrophee.Location = new System.Drawing.Point(0, 0);
            this.ptbTrophee.Name = "ptbTrophee";
            this.ptbTrophee.Size = new System.Drawing.Size(550, 550);
            this.ptbTrophee.TabIndex = 2;
            this.ptbTrophee.TabStop = false;
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.Location = new System.Drawing.Point(14, 514);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(51, 20);
            this.lblWin.TabIndex = 3;
            this.lblWin.Text = "label1";
            // 
            // lblWinTitle
            // 
            this.lblWinTitle.AutoSize = true;
            this.lblWinTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblWinTitle.Font = new System.Drawing.Font("Felix Titling", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinTitle.Location = new System.Drawing.Point(195, 30);
            this.lblWinTitle.Name = "lblWinTitle";
            this.lblWinTitle.Size = new System.Drawing.Size(156, 32);
            this.lblWinTitle.TabIndex = 4;
            this.lblWinTitle.Text = "Victoire !";
            // 
            // cmdPlayAgain
            // 
            this.cmdPlayAgain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdPlayAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdPlayAgain.Location = new System.Drawing.Point(368, 569);
            this.cmdPlayAgain.Name = "cmdPlayAgain";
            this.cmdPlayAgain.Size = new System.Drawing.Size(75, 32);
            this.cmdPlayAgain.TabIndex = 5;
            this.cmdPlayAgain.Text = "Rejouer";
            this.cmdPlayAgain.UseVisualStyleBackColor = true;
            this.cmdPlayAgain.Click += new System.EventHandler(this.cmdPlayAgain_Click);
            // 
            // cmdLeave
            // 
            this.cmdLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLeave.Location = new System.Drawing.Point(449, 569);
            this.cmdLeave.Name = "cmdLeave";
            this.cmdLeave.Size = new System.Drawing.Size(75, 32);
            this.cmdLeave.TabIndex = 6;
            this.cmdLeave.Text = "Quitter";
            this.cmdLeave.UseVisualStyleBackColor = true;
            this.cmdLeave.Click += new System.EventHandler(this.cmdLeave_Click);
            // 
            // Form_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Azure;
            this.ClientSize = new System.Drawing.Size(550, 620);
            this.Controls.Add(this.cmdLeave);
            this.Controls.Add(this.cmdPlayAgain);
            this.Controls.Add(this.lblWinTitle);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.ptbTrophee);
            this.Controls.Add(this.cmdOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Win";
            this.Load += new System.EventHandler(this.Form_Win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTrophee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.PictureBox ptbTrophee;
        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Label lblWinTitle;
        private System.Windows.Forms.Button cmdPlayAgain;
        private System.Windows.Forms.Button cmdLeave;
    }
}