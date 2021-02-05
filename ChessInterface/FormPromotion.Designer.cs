namespace ChessInterface
{
    partial class FormPromotion
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
            this.ButtonQueen = new System.Windows.Forms.Button();
            this.ButtonRook = new System.Windows.Forms.Button();
            this.ButtonBishop = new System.Windows.Forms.Button();
            this.ButtonKnight = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonQueen
            // 
            this.ButtonQueen.BackgroundImage = global::ChessInterface.Properties.Resources.WhiteQueen;
            this.ButtonQueen.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonQueen.Location = new System.Drawing.Point(12, 12);
            this.ButtonQueen.Name = "ButtonQueen";
            this.ButtonQueen.Size = new System.Drawing.Size(100, 100);
            this.ButtonQueen.TabIndex = 0;
            this.ButtonQueen.UseVisualStyleBackColor = true;
            this.ButtonQueen.Click += new System.EventHandler(this.ButtonQueen_Click);
            // 
            // ButtonRook
            // 
            this.ButtonRook.BackgroundImage = global::ChessInterface.Properties.Resources.WhiteRook;
            this.ButtonRook.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonRook.Location = new System.Drawing.Point(118, 12);
            this.ButtonRook.Name = "ButtonRook";
            this.ButtonRook.Size = new System.Drawing.Size(100, 100);
            this.ButtonRook.TabIndex = 1;
            this.ButtonRook.UseVisualStyleBackColor = true;
            this.ButtonRook.Click += new System.EventHandler(this.ButtonRook_Click);
            // 
            // ButtonBishop
            // 
            this.ButtonBishop.BackgroundImage = global::ChessInterface.Properties.Resources.WhiteBishop;
            this.ButtonBishop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonBishop.Location = new System.Drawing.Point(224, 12);
            this.ButtonBishop.Name = "ButtonBishop";
            this.ButtonBishop.Size = new System.Drawing.Size(100, 100);
            this.ButtonBishop.TabIndex = 2;
            this.ButtonBishop.UseVisualStyleBackColor = true;
            this.ButtonBishop.Click += new System.EventHandler(this.ButtonBishop_Click);
            // 
            // ButtonKnight
            // 
            this.ButtonKnight.BackgroundImage = global::ChessInterface.Properties.Resources.WhiteKnight;
            this.ButtonKnight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ButtonKnight.Location = new System.Drawing.Point(330, 12);
            this.ButtonKnight.Name = "ButtonKnight";
            this.ButtonKnight.Size = new System.Drawing.Size(100, 100);
            this.ButtonKnight.TabIndex = 3;
            this.ButtonKnight.UseVisualStyleBackColor = true;
            this.ButtonKnight.Click += new System.EventHandler(this.ButtonKnight_Click);
            // 
            // FormPromotion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 126);
            this.Controls.Add(this.ButtonKnight);
            this.Controls.Add(this.ButtonBishop);
            this.Controls.Add(this.ButtonRook);
            this.Controls.Add(this.ButtonQueen);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormPromotion";
            this.Text = "FormPromotion";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonQueen;
        private System.Windows.Forms.Button ButtonRook;
        private System.Windows.Forms.Button ButtonBishop;
        private System.Windows.Forms.Button ButtonKnight;
    }
}