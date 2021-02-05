namespace ChessInterface
{
    partial class FormBoard
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
            this.GroupOpponent = new System.Windows.Forms.GroupBox();
            this.LabelOpponentClock = new System.Windows.Forms.Label();
            this.LabelPlayerClock = new System.Windows.Forms.Label();
            this.GroupPlayer = new System.Windows.Forms.GroupBox();
            this.ButtonResign = new System.Windows.Forms.Button();
            this.ButtonDraw = new System.Windows.Forms.Button();
            this.MoveList = new System.Windows.Forms.DataGridView();
            this.ColumnWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBlack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupOpponent.SuspendLayout();
            this.GroupPlayer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveList)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupOpponent
            // 
            this.GroupOpponent.Controls.Add(this.LabelOpponentClock);
            this.GroupOpponent.Location = new System.Drawing.Point(423, 12);
            this.GroupOpponent.Name = "GroupOpponent";
            this.GroupOpponent.Size = new System.Drawing.Size(224, 98);
            this.GroupOpponent.TabIndex = 0;
            this.GroupOpponent.TabStop = false;
            this.GroupOpponent.Text = "Opponent";
            // 
            // LabelOpponentClock
            // 
            this.LabelOpponentClock.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelOpponentClock.Location = new System.Drawing.Point(6, 19);
            this.LabelOpponentClock.Name = "LabelOpponentClock";
            this.LabelOpponentClock.Size = new System.Drawing.Size(212, 70);
            this.LabelOpponentClock.TabIndex = 0;
            this.LabelOpponentClock.Text = "30:30";
            this.LabelOpponentClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LabelPlayerClock
            // 
            this.LabelPlayerClock.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelPlayerClock.Location = new System.Drawing.Point(6, 19);
            this.LabelPlayerClock.Name = "LabelPlayerClock";
            this.LabelPlayerClock.Size = new System.Drawing.Size(212, 70);
            this.LabelPlayerClock.TabIndex = 0;
            this.LabelPlayerClock.Text = "30:30";
            this.LabelPlayerClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupPlayer
            // 
            this.GroupPlayer.Controls.Add(this.LabelPlayerClock);
            this.GroupPlayer.Location = new System.Drawing.Point(423, 317);
            this.GroupPlayer.Name = "GroupPlayer";
            this.GroupPlayer.Size = new System.Drawing.Size(224, 98);
            this.GroupPlayer.TabIndex = 1;
            this.GroupPlayer.TabStop = false;
            this.GroupPlayer.Text = "You";
            // 
            // ButtonResign
            // 
            this.ButtonResign.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonResign.Location = new System.Drawing.Point(535, 268);
            this.ButtonResign.Name = "ButtonResign";
            this.ButtonResign.Size = new System.Drawing.Size(112, 43);
            this.ButtonResign.TabIndex = 2;
            this.ButtonResign.Text = "Resign";
            this.ButtonResign.UseVisualStyleBackColor = true;
            // 
            // ButtonDraw
            // 
            this.ButtonDraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDraw.Location = new System.Drawing.Point(423, 268);
            this.ButtonDraw.Name = "ButtonDraw";
            this.ButtonDraw.Size = new System.Drawing.Size(112, 43);
            this.ButtonDraw.TabIndex = 3;
            this.ButtonDraw.Text = "Draw";
            this.ButtonDraw.UseVisualStyleBackColor = true;
            // 
            // MoveList
            // 
            this.MoveList.AllowUserToAddRows = false;
            this.MoveList.AllowUserToDeleteRows = false;
            this.MoveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWhite,
            this.ColumnBlack});
            this.MoveList.Location = new System.Drawing.Point(423, 116);
            this.MoveList.Name = "MoveList";
            this.MoveList.ReadOnly = true;
            this.MoveList.Size = new System.Drawing.Size(224, 146);
            this.MoveList.TabIndex = 4;
            // 
            // ColumnWhite
            // 
            this.ColumnWhite.Frozen = true;
            this.ColumnWhite.HeaderText = "White";
            this.ColumnWhite.Name = "ColumnWhite";
            this.ColumnWhite.ReadOnly = true;
            // 
            // ColumnBlack
            // 
            this.ColumnBlack.Frozen = true;
            this.ColumnBlack.HeaderText = "Black";
            this.ColumnBlack.Name = "ColumnBlack";
            this.ColumnBlack.ReadOnly = true;
            // 
            // FormBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 427);
            this.Controls.Add(this.MoveList);
            this.Controls.Add(this.ButtonDraw);
            this.Controls.Add(this.ButtonResign);
            this.Controls.Add(this.GroupPlayer);
            this.Controls.Add(this.GroupOpponent);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormBoard";
            this.Text = "FormBoard";
            this.GroupOpponent.ResumeLayout(false);
            this.GroupPlayer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoveList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupOpponent;
        private System.Windows.Forms.Label LabelOpponentClock;
        private System.Windows.Forms.Label LabelPlayerClock;
        private System.Windows.Forms.GroupBox GroupPlayer;
        private System.Windows.Forms.Button ButtonResign;
        private System.Windows.Forms.Button ButtonDraw;
        private System.Windows.Forms.DataGridView MoveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBlack;
    }
}