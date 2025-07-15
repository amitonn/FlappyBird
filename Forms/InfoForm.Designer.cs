namespace flappyBird
{
    partial class InfoForm
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
            this.Backbt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Backbt
            // 
            this.Backbt.BackColor = System.Drawing.Color.Transparent;
            this.Backbt.BackgroundImage = global::flappyBird.Properties.Resources.BackBtn;
            this.Backbt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Backbt.FlatAppearance.BorderSize = 0;
            this.Backbt.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Backbt.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Backbt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backbt.Location = new System.Drawing.Point(124, 326);
            this.Backbt.Name = "Backbt";
            this.Backbt.Size = new System.Drawing.Size(198, 87);
            this.Backbt.TabIndex = 0;
            this.Backbt.UseVisualStyleBackColor = false;
            this.Backbt.Click += new System.EventHandler(this.Backbt_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(1, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 189);
            this.label1.TabIndex = 1;
            this.label1.Text = "\r\nYou\'re the Bird, and you\'re jumping through pipes to go as far away as you can." +
    "\r\nButtons :\r\nPress SPACE button to Jump.\r\nPress ESC to pause the game";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 17F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkRed;
            this.label2.Location = new System.Drawing.Point(162, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 27);
            this.label2.TabIndex = 2;
            this.label2.Text = "Instructions";
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::flappyBird.Properties.Resources.InstructionsBackground;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(445, 425);
            this.ControlBox = false;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Backbt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InfoForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InfoForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Backbt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}