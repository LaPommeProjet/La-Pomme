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
            this.lblWin = new System.Windows.Forms.Label();
            this.cmdOk = new System.Windows.Forms.Button();
            this.ptbTrophee = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbTrophee)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWin.ForeColor = System.Drawing.Color.White;
            this.lblWin.Location = new System.Drawing.Point(12, 64);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(0, 20);
            this.lblWin.TabIndex = 0;
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
            this.ptbTrophee.Location = new System.Drawing.Point(559, 12);
            this.ptbTrophee.Name = "ptbTrophee";
            this.ptbTrophee.Size = new System.Drawing.Size(120, 130);
            this.ptbTrophee.TabIndex = 2;
            this.ptbTrophee.TabStop = false;
            // 
            // Form_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(691, 195);
            this.Controls.Add(this.ptbTrophee);
            this.Controls.Add(this.cmdOk);
            this.Controls.Add(this.lblWin);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form_Win";
            this.Text = "Form_Wins";
            this.Load += new System.EventHandler(this.Form_Win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbTrophee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWin;
        private System.Windows.Forms.Button cmdOk;
        private System.Windows.Forms.PictureBox ptbTrophee;
    }
}