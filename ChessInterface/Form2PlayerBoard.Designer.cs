namespace ChessInterface
{
    partial class Form2PlayerBoard
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
            this.components = new System.ComponentModel.Container();
            this.GroupBlack = new System.Windows.Forms.GroupBox();
            this.LabelBlackClock = new System.Windows.Forms.Label();
            this.MoveList = new System.Windows.Forms.DataGridView();
            this.ColumnWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBlack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ButtonDraw = new System.Windows.Forms.Button();
            this.GroupWhite = new System.Windows.Forms.GroupBox();
            this.LabelWhiteClock = new System.Windows.Forms.Label();
            this.TimerClock = new System.Windows.Forms.Timer(this.components);
            this.GroupBlack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MoveList)).BeginInit();
            this.GroupWhite.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBlack
            // 
            this.GroupBlack.Controls.Add(this.LabelBlackClock);
            this.GroupBlack.Location = new System.Drawing.Point(423, 12);
            this.GroupBlack.Name = "GroupBlack";
            this.GroupBlack.Size = new System.Drawing.Size(224, 98);
            this.GroupBlack.TabIndex = 5;
            this.GroupBlack.TabStop = false;
            this.GroupBlack.Text = "Black";
            // 
            // LabelBlackClock
            // 
            this.LabelBlackClock.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelBlackClock.Location = new System.Drawing.Point(6, 19);
            this.LabelBlackClock.Name = "LabelBlackClock";
            this.LabelBlackClock.Size = new System.Drawing.Size(212, 70);
            this.LabelBlackClock.TabIndex = 0;
            this.LabelBlackClock.Text = "30:30";
            this.LabelBlackClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.MoveList.TabIndex = 9;
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
            // ButtonDraw
            // 
            this.ButtonDraw.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonDraw.Location = new System.Drawing.Point(423, 268);
            this.ButtonDraw.Name = "ButtonDraw";
            this.ButtonDraw.Size = new System.Drawing.Size(224, 43);
            this.ButtonDraw.TabIndex = 8;
            this.ButtonDraw.Text = "Draw";
            this.ButtonDraw.UseVisualStyleBackColor = true;
            this.ButtonDraw.Click += new System.EventHandler(this.ButtonDraw_Click);
            // 
            // GroupWhite
            // 
            this.GroupWhite.Controls.Add(this.LabelWhiteClock);
            this.GroupWhite.Location = new System.Drawing.Point(423, 317);
            this.GroupWhite.Name = "GroupWhite";
            this.GroupWhite.Size = new System.Drawing.Size(224, 98);
            this.GroupWhite.TabIndex = 6;
            this.GroupWhite.TabStop = false;
            this.GroupWhite.Text = "White";
            // 
            // LabelWhiteClock
            // 
            this.LabelWhiteClock.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelWhiteClock.Location = new System.Drawing.Point(6, 19);
            this.LabelWhiteClock.Name = "LabelWhiteClock";
            this.LabelWhiteClock.Size = new System.Drawing.Size(212, 70);
            this.LabelWhiteClock.TabIndex = 0;
            this.LabelWhiteClock.Text = "30:30";
            this.LabelWhiteClock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerClock
            // 
            this.TimerClock.Enabled = true;
            this.TimerClock.Tick += new System.EventHandler(this.TimerClock_Tick);
            // 
            // Form2PlayerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 427);
            this.Controls.Add(this.GroupBlack);
            this.Controls.Add(this.MoveList);
            this.Controls.Add(this.ButtonDraw);
            this.Controls.Add(this.GroupWhite);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "Form2PlayerBoard";
            this.Text = "Form2PlayerBoard";
            this.GroupBlack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MoveList)).EndInit();
            this.GroupWhite.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupBlack;
        private System.Windows.Forms.Label LabelBlackClock;
        private System.Windows.Forms.DataGridView MoveList;
        private System.Windows.Forms.Button ButtonDraw;
        private System.Windows.Forms.GroupBox GroupWhite;
        private System.Windows.Forms.Label LabelWhiteClock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBlack;
        private System.Windows.Forms.Timer TimerClock;
    }
}