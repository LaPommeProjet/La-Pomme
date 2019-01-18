namespace La_Pomme
{
    partial class Form_Console
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
            this.lstText = new System.Windows.Forms.ListBox();
            this.cmdLeave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstText
            // 
            this.lstText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstText.FormattingEnabled = true;
            this.lstText.ItemHeight = 16;
            this.lstText.Location = new System.Drawing.Point(12, 12);
            this.lstText.Name = "lstText";
            this.lstText.Size = new System.Drawing.Size(386, 516);
            this.lstText.TabIndex = 0;
            // 
            // cmdLeave
            // 
            this.cmdLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLeave.Location = new System.Drawing.Point(85, 554);
            this.cmdLeave.Name = "cmdLeave";
            this.cmdLeave.Size = new System.Drawing.Size(240, 23);
            this.cmdLeave.TabIndex = 1;
            this.cmdLeave.Text = "Quitter l\'afficheur d\'événements";
            this.cmdLeave.UseVisualStyleBackColor = true;
            this.cmdLeave.Click += new System.EventHandler(this.cmdLeave_Click);
            // 
            // Form_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(410, 589);
            this.Controls.Add(this.cmdLeave);
            this.Controls.Add(this.lstText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Console";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Console";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstText;
        private System.Windows.Forms.Button cmdLeave;
    }
}