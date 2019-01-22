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
            this.cmdLeave = new System.Windows.Forms.Button();
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.flpPlayer1 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpPlayer2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flpP1Result = new System.Windows.Forms.FlowLayoutPanel();
            this.flpP2Result = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // cmdLeave
            // 
            this.cmdLeave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmdLeave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdLeave.Location = new System.Drawing.Point(84, 876);
            this.cmdLeave.Name = "cmdLeave";
            this.cmdLeave.Size = new System.Drawing.Size(240, 23);
            this.cmdLeave.TabIndex = 1;
            this.cmdLeave.Text = "Quitter l\'afficheur d\'événements";
            this.cmdLeave.UseVisualStyleBackColor = true;
            this.cmdLeave.Click += new System.EventHandler(this.cmdLeave_Click);
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.AutoSize = true;
            this.lblPlayer1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(72, 23);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(51, 20);
            this.lblPlayer1.TabIndex = 2;
            this.lblPlayer1.Text = "label1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.AutoSize = true;
            this.lblPlayer2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(281, 23);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(51, 20);
            this.lblPlayer2.TabIndex = 3;
            this.lblPlayer2.Text = "label2";
            // 
            // flpPlayer1
            // 
            this.flpPlayer1.Location = new System.Drawing.Point(45, 58);
            this.flpPlayer1.Name = "flpPlayer1";
            this.flpPlayer1.Size = new System.Drawing.Size(65, 781);
            this.flpPlayer1.TabIndex = 4;
            // 
            // flpPlayer2
            // 
            this.flpPlayer2.Location = new System.Drawing.Point(291, 58);
            this.flpPlayer2.Name = "flpPlayer2";
            this.flpPlayer2.Size = new System.Drawing.Size(65, 781);
            this.flpPlayer2.TabIndex = 5;
            // 
            // flpP1Result
            // 
            this.flpP1Result.Location = new System.Drawing.Point(121, 58);
            this.flpP1Result.Name = "flpP1Result";
            this.flpP1Result.Size = new System.Drawing.Size(65, 781);
            this.flpP1Result.TabIndex = 5;
            // 
            // flpP2Result
            // 
            this.flpP2Result.Location = new System.Drawing.Point(212, 58);
            this.flpP2Result.Name = "flpP2Result";
            this.flpP2Result.Size = new System.Drawing.Size(65, 781);
            this.flpP2Result.TabIndex = 5;
            // 
            // Form_Console
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaGreen;
            this.ClientSize = new System.Drawing.Size(410, 920);
            this.Controls.Add(this.flpP2Result);
            this.Controls.Add(this.flpP1Result);
            this.Controls.Add(this.flpPlayer2);
            this.Controls.Add(this.flpPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.cmdLeave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Console";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form_Console";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button cmdLeave;
        private System.Windows.Forms.Label lblPlayer1;
        private System.Windows.Forms.Label lblPlayer2;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer1;
        private System.Windows.Forms.FlowLayoutPanel flpPlayer2;
        private System.Windows.Forms.FlowLayoutPanel flpP1Result;
        private System.Windows.Forms.FlowLayoutPanel flpP2Result;
    }
}