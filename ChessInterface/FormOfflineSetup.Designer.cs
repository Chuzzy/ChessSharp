namespace ChessInterface
{
    partial class FormOfflineSetup
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
            this.Group2Player = new System.Windows.Forms.GroupBox();
            this.ButtonStart2Player = new System.Windows.Forms.Button();
            this.ComboPlayAs = new System.Windows.Forms.ComboBox();
            this.NumTimeControlIncrement = new System.Windows.Forms.NumericUpDown();
            this.LabelSecPerTurn = new System.Windows.Forms.Label();
            this.NumTimeControlMins = new System.Windows.Forms.NumericUpDown();
            this.LabelMins = new System.Windows.Forms.Label();
            this.LabelTimeControl = new System.Windows.Forms.Label();
            this.GroupComputer = new System.Windows.Forms.GroupBox();
            this.LabelDifficulty = new System.Windows.Forms.Label();
            this.ButtonStartComputer = new System.Windows.Forms.Button();
            this.TrackBarDifficulty = new System.Windows.Forms.TrackBar();
            this.LabelComputerLevel = new System.Windows.Forms.Label();
            this.Group2Player.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlMins)).BeginInit();
            this.GroupComputer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // Group2Player
            // 
            this.Group2Player.Controls.Add(this.ButtonStart2Player);
            this.Group2Player.Controls.Add(this.NumTimeControlIncrement);
            this.Group2Player.Controls.Add(this.LabelSecPerTurn);
            this.Group2Player.Controls.Add(this.NumTimeControlMins);
            this.Group2Player.Controls.Add(this.LabelMins);
            this.Group2Player.Controls.Add(this.LabelTimeControl);
            this.Group2Player.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.Group2Player.Location = new System.Drawing.Point(238, 12);
            this.Group2Player.Name = "Group2Player";
            this.Group2Player.Size = new System.Drawing.Size(221, 168);
            this.Group2Player.TabIndex = 3;
            this.Group2Player.TabStop = false;
            this.Group2Player.Text = "2 Player";
            // 
            // ButtonStart2Player
            // 
            this.ButtonStart2Player.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtonStart2Player.Location = new System.Drawing.Point(6, 114);
            this.ButtonStart2Player.Name = "ButtonStart2Player";
            this.ButtonStart2Player.Size = new System.Drawing.Size(206, 45);
            this.ButtonStart2Player.TabIndex = 5;
            this.ButtonStart2Player.Text = "Create match";
            this.ButtonStart2Player.UseVisualStyleBackColor = true;
            this.ButtonStart2Player.Click += new System.EventHandler(this.ButtonStart2Player_Click);
            // 
            // ComboPlayAs
            // 
            this.ComboPlayAs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboPlayAs.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ComboPlayAs.FormattingEnabled = true;
            this.ComboPlayAs.Items.AddRange(new object[] {
            "White",
            "Black",
            "Random color"});
            this.ComboPlayAs.Location = new System.Drawing.Point(10, 85);
            this.ComboPlayAs.Name = "ComboPlayAs";
            this.ComboPlayAs.Size = new System.Drawing.Size(206, 23);
            this.ComboPlayAs.TabIndex = 6;
            // 
            // NumTimeControlIncrement
            // 
            this.NumTimeControlIncrement.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumTimeControlIncrement.Location = new System.Drawing.Point(111, 57);
            this.NumTimeControlIncrement.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.NumTimeControlIncrement.Name = "NumTimeControlIncrement";
            this.NumTimeControlIncrement.Size = new System.Drawing.Size(46, 23);
            this.NumTimeControlIncrement.TabIndex = 4;
            // 
            // LabelSecPerTurn
            // 
            this.LabelSecPerTurn.AutoSize = true;
            this.LabelSecPerTurn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelSecPerTurn.Location = new System.Drawing.Point(163, 59);
            this.LabelSecPerTurn.Name = "LabelSecPerTurn";
            this.LabelSecPerTurn.Size = new System.Drawing.Size(52, 15);
            this.LabelSecPerTurn.TabIndex = 3;
            this.LabelSecPerTurn.Text = "Sec/turn";
            // 
            // NumTimeControlMins
            // 
            this.NumTimeControlMins.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.NumTimeControlMins.Location = new System.Drawing.Point(9, 57);
            this.NumTimeControlMins.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.NumTimeControlMins.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumTimeControlMins.Name = "NumTimeControlMins";
            this.NumTimeControlMins.Size = new System.Drawing.Size(46, 23);
            this.NumTimeControlMins.TabIndex = 2;
            this.NumTimeControlMins.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // LabelMins
            // 
            this.LabelMins.AutoSize = true;
            this.LabelMins.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelMins.Location = new System.Drawing.Point(61, 59);
            this.LabelMins.Name = "LabelMins";
            this.LabelMins.Size = new System.Drawing.Size(44, 15);
            this.LabelMins.TabIndex = 1;
            this.LabelMins.Text = "Mins +";
            // 
            // LabelTimeControl
            // 
            this.LabelTimeControl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelTimeControl.Location = new System.Drawing.Point(6, 34);
            this.LabelTimeControl.Name = "LabelTimeControl";
            this.LabelTimeControl.Size = new System.Drawing.Size(209, 20);
            this.LabelTimeControl.TabIndex = 0;
            this.LabelTimeControl.Text = "Time control";
            this.LabelTimeControl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GroupComputer
            // 
            this.GroupComputer.Controls.Add(this.LabelComputerLevel);
            this.GroupComputer.Controls.Add(this.TrackBarDifficulty);
            this.GroupComputer.Controls.Add(this.ComboPlayAs);
            this.GroupComputer.Controls.Add(this.ButtonStartComputer);
            this.GroupComputer.Controls.Add(this.LabelDifficulty);
            this.GroupComputer.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.GroupComputer.Location = new System.Drawing.Point(11, 12);
            this.GroupComputer.Name = "GroupComputer";
            this.GroupComputer.Size = new System.Drawing.Size(221, 168);
            this.GroupComputer.TabIndex = 2;
            this.GroupComputer.TabStop = false;
            this.GroupComputer.Text = "Computer";
            // 
            // LabelDifficulty
            // 
            this.LabelDifficulty.AutoSize = true;
            this.LabelDifficulty.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelDifficulty.Location = new System.Drawing.Point(7, 39);
            this.LabelDifficulty.Name = "LabelDifficulty";
            this.LabelDifficulty.Size = new System.Drawing.Size(55, 15);
            this.LabelDifficulty.TabIndex = 0;
            this.LabelDifficulty.Text = "Strength:";
            // 
            // ButtonStartComputer
            // 
            this.ButtonStartComputer.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtonStartComputer.Location = new System.Drawing.Point(10, 114);
            this.ButtonStartComputer.Name = "ButtonStartComputer";
            this.ButtonStartComputer.Size = new System.Drawing.Size(206, 45);
            this.ButtonStartComputer.TabIndex = 4;
            this.ButtonStartComputer.Text = "Create match";
            this.ButtonStartComputer.UseVisualStyleBackColor = true;
            this.ButtonStartComputer.Click += new System.EventHandler(this.ButtonStartComputer_Click);
            // 
            // TrackBarDifficulty
            // 
            this.TrackBarDifficulty.LargeChange = 1;
            this.TrackBarDifficulty.Location = new System.Drawing.Point(60, 34);
            this.TrackBarDifficulty.Maximum = 20;
            this.TrackBarDifficulty.Minimum = 1;
            this.TrackBarDifficulty.Name = "TrackBarDifficulty";
            this.TrackBarDifficulty.Size = new System.Drawing.Size(155, 45);
            this.TrackBarDifficulty.TabIndex = 5;
            this.TrackBarDifficulty.Value = 1;
            this.TrackBarDifficulty.Scroll += new System.EventHandler(this.TrackBarDifficulty_Scroll);
            // 
            // LabelComputerLevel
            // 
            this.LabelComputerLevel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelComputerLevel.Location = new System.Drawing.Point(60, 64);
            this.LabelComputerLevel.Name = "LabelComputerLevel";
            this.LabelComputerLevel.Size = new System.Drawing.Size(155, 16);
            this.LabelComputerLevel.TabIndex = 7;
            this.LabelComputerLevel.Text = "Level 1";
            this.LabelComputerLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormOfflineSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 190);
            this.Controls.Add(this.Group2Player);
            this.Controls.Add(this.GroupComputer);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormOfflineSetup";
            this.Text = "FormOfflineSetup";
            this.Load += new System.EventHandler(this.FormOfflineSetup_Load);
            this.Group2Player.ResumeLayout(false);
            this.Group2Player.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlMins)).EndInit();
            this.GroupComputer.ResumeLayout(false);
            this.GroupComputer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrackBarDifficulty)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Group2Player;
        private System.Windows.Forms.Button ButtonStart2Player;
        private System.Windows.Forms.ComboBox ComboPlayAs;
        private System.Windows.Forms.NumericUpDown NumTimeControlIncrement;
        private System.Windows.Forms.Label LabelSecPerTurn;
        private System.Windows.Forms.NumericUpDown NumTimeControlMins;
        private System.Windows.Forms.Label LabelMins;
        private System.Windows.Forms.Label LabelTimeControl;
        private System.Windows.Forms.GroupBox GroupComputer;
        private System.Windows.Forms.Label LabelDifficulty;
        private System.Windows.Forms.TrackBar TrackBarDifficulty;
        private System.Windows.Forms.Button ButtonStartComputer;
        private System.Windows.Forms.Label LabelComputerLevel;
    }
}