namespace ChessInterface
{
    partial class FormComputerBoard
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
            this.MoveList = new System.Windows.Forms.DataGridView();
            this.ColumnWhite = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnBlack = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.MoveList)).BeginInit();
            this.SuspendLayout();
            // 
            // MoveList
            // 
            this.MoveList.AllowUserToAddRows = false;
            this.MoveList.AllowUserToDeleteRows = false;
            this.MoveList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MoveList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnWhite,
            this.ColumnBlack});
            this.MoveList.Location = new System.Drawing.Point(423, 12);
            this.MoveList.Name = "MoveList";
            this.MoveList.ReadOnly = true;
            this.MoveList.Size = new System.Drawing.Size(224, 403);
            this.MoveList.TabIndex = 12;
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
            // FormComputerBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 427);
            this.Controls.Add(this.MoveList);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormComputerBoard";
            this.Text = "FormComputerBoard";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormComputerBoard_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MoveList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView MoveList;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnWhite;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnBlack;
    }
}