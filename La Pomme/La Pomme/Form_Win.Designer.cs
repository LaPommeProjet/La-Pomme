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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Win));
            this.ptbCup = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCup)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbCup
            // 
            this.ptbCup.ImageLocation = "";
            this.ptbCup.Location = new System.Drawing.Point(47, 63);
            this.ptbCup.Name = "ptbCup";
            this.ptbCup.Size = new System.Drawing.Size(77, 87);
            this.ptbCup.TabIndex = 0;
            this.ptbCup.TabStop = false;
            // 
            // Form_Win
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(331, 208);
            this.Controls.Add(this.ptbCup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form_Win";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Win";
            this.Load += new System.EventHandler(this.Form_Win_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbCup)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbCup;
    }
}