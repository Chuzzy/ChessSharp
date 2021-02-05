namespace ChessInterface
{
    partial class FormOnlineSetup
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
            this.GroupListenForMatch = new System.Windows.Forms.GroupBox();
            this.ButtonListenForMatch = new System.Windows.Forms.Button();
            this.TextPortNum = new System.Windows.Forms.TextBox();
            this.LabelPortNum = new System.Windows.Forms.Label();
            this.TextYourIP = new System.Windows.Forms.TextBox();
            this.LabelYourIP = new System.Windows.Forms.Label();
            this.GroupCreateMatch = new System.Windows.Forms.GroupBox();
            this.ButtonCreateMatch = new System.Windows.Forms.Button();
            this.TextOpponentIPandPort = new System.Windows.Forms.TextBox();
            this.LabelOpponentIPandPort = new System.Windows.Forms.Label();
            this.ComboPlayAs = new System.Windows.Forms.ComboBox();
            this.CheckRatedGame = new System.Windows.Forms.CheckBox();
            this.NumTimeControlIncrement = new System.Windows.Forms.NumericUpDown();
            this.LabelSecPerTurn = new System.Windows.Forms.Label();
            this.NumTimeControlMins = new System.Windows.Forms.NumericUpDown();
            this.LabelMins = new System.Windows.Forms.Label();
            this.LabelTimeControl = new System.Windows.Forms.Label();
            this.GroupListenForMatch.SuspendLayout();
            this.GroupCreateMatch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlIncrement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlMins)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupListenForMatch
            // 
            this.GroupListenForMatch.Controls.Add(this.ButtonListenForMatch);
            this.GroupListenForMatch.Controls.Add(this.TextPortNum);
            this.GroupListenForMatch.Controls.Add(this.LabelPortNum);
            this.GroupListenForMatch.Controls.Add(this.TextYourIP);
            this.GroupListenForMatch.Controls.Add(this.LabelYourIP);
            this.GroupListenForMatch.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.GroupListenForMatch.Location = new System.Drawing.Point(12, 12);
            this.GroupListenForMatch.Name = "GroupListenForMatch";
            this.GroupListenForMatch.Size = new System.Drawing.Size(221, 277);
            this.GroupListenForMatch.TabIndex = 0;
            this.GroupListenForMatch.TabStop = false;
            this.GroupListenForMatch.Text = "Listen for a match";
            // 
            // ButtonListenForMatch
            // 
            this.ButtonListenForMatch.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtonListenForMatch.Location = new System.Drawing.Point(9, 226);
            this.ButtonListenForMatch.Name = "ButtonListenForMatch";
            this.ButtonListenForMatch.Size = new System.Drawing.Size(206, 45);
            this.ButtonListenForMatch.TabIndex = 4;
            this.ButtonListenForMatch.Text = "Start listening";
            this.ButtonListenForMatch.UseVisualStyleBackColor = true;
            // 
            // TextPortNum
            // 
            this.TextPortNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextPortNum.Location = new System.Drawing.Point(156, 65);
            this.TextPortNum.Name = "TextPortNum";
            this.TextPortNum.Size = new System.Drawing.Size(59, 23);
            this.TextPortNum.TabIndex = 3;
            // 
            // LabelPortNum
            // 
            this.LabelPortNum.AutoSize = true;
            this.LabelPortNum.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelPortNum.Location = new System.Drawing.Point(7, 68);
            this.LabelPortNum.Name = "LabelPortNum";
            this.LabelPortNum.Size = new System.Drawing.Size(77, 15);
            this.LabelPortNum.TabIndex = 2;
            this.LabelPortNum.Text = "Port number:";
            // 
            // TextYourIP
            // 
            this.TextYourIP.Enabled = false;
            this.TextYourIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextYourIP.Location = new System.Drawing.Point(60, 36);
            this.TextYourIP.Name = "TextYourIP";
            this.TextYourIP.Size = new System.Drawing.Size(155, 23);
            this.TextYourIP.TabIndex = 1;
            // 
            // LabelYourIP
            // 
            this.LabelYourIP.AutoSize = true;
            this.LabelYourIP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelYourIP.Location = new System.Drawing.Point(7, 39);
            this.LabelYourIP.Name = "LabelYourIP";
            this.LabelYourIP.Size = new System.Drawing.Size(47, 15);
            this.LabelYourIP.TabIndex = 0;
            this.LabelYourIP.Text = "Your IP:";
            // 
            // GroupCreateMatch
            // 
            this.GroupCreateMatch.Controls.Add(this.ButtonCreateMatch);
            this.GroupCreateMatch.Controls.Add(this.TextOpponentIPandPort);
            this.GroupCreateMatch.Controls.Add(this.LabelOpponentIPandPort);
            this.GroupCreateMatch.Controls.Add(this.ComboPlayAs);
            this.GroupCreateMatch.Controls.Add(this.CheckRatedGame);
            this.GroupCreateMatch.Controls.Add(this.NumTimeControlIncrement);
            this.GroupCreateMatch.Controls.Add(this.LabelSecPerTurn);
            this.GroupCreateMatch.Controls.Add(this.NumTimeControlMins);
            this.GroupCreateMatch.Controls.Add(this.LabelMins);
            this.GroupCreateMatch.Controls.Add(this.LabelTimeControl);
            this.GroupCreateMatch.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.GroupCreateMatch.Location = new System.Drawing.Point(239, 12);
            this.GroupCreateMatch.Name = "GroupCreateMatch";
            this.GroupCreateMatch.Size = new System.Drawing.Size(221, 277);
            this.GroupCreateMatch.TabIndex = 1;
            this.GroupCreateMatch.TabStop = false;
            this.GroupCreateMatch.Text = "Create a match";
            // 
            // ButtonCreateMatch
            // 
            this.ButtonCreateMatch.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.ButtonCreateMatch.Location = new System.Drawing.Point(9, 226);
            this.ButtonCreateMatch.Name = "ButtonCreateMatch";
            this.ButtonCreateMatch.Size = new System.Drawing.Size(206, 45);
            this.ButtonCreateMatch.TabIndex = 5;
            this.ButtonCreateMatch.Text = "Create match";
            this.ButtonCreateMatch.UseVisualStyleBackColor = true;
            this.ButtonCreateMatch.Click += new System.EventHandler(this.ButtonCreateMatch_Click);
            // 
            // TextOpponentIPandPort
            // 
            this.TextOpponentIPandPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TextOpponentIPandPort.Location = new System.Drawing.Point(9, 180);
            this.TextOpponentIPandPort.Name = "TextOpponentIPandPort";
            this.TextOpponentIPandPort.Size = new System.Drawing.Size(206, 23);
            this.TextOpponentIPandPort.TabIndex = 5;
            // 
            // LabelOpponentIPandPort
            // 
            this.LabelOpponentIPandPort.AutoSize = true;
            this.LabelOpponentIPandPort.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LabelOpponentIPandPort.Location = new System.Drawing.Point(6, 162);
            this.LabelOpponentIPandPort.Name = "LabelOpponentIPandPort";
            this.LabelOpponentIPandPort.Size = new System.Drawing.Size(170, 15);
            this.LabelOpponentIPandPort.TabIndex = 7;
            this.LabelOpponentIPandPort.Text = "Opponent IP and port number:";
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
            this.ComboPlayAs.Location = new System.Drawing.Point(9, 111);
            this.ComboPlayAs.Name = "ComboPlayAs";
            this.ComboPlayAs.Size = new System.Drawing.Size(206, 23);
            this.ComboPlayAs.TabIndex = 6;
            // 
            // CheckRatedGame
            // 
            this.CheckRatedGame.AutoSize = true;
            this.CheckRatedGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.CheckRatedGame.Location = new System.Drawing.Point(9, 86);
            this.CheckRatedGame.Name = "CheckRatedGame";
            this.CheckRatedGame.Size = new System.Drawing.Size(89, 19);
            this.CheckRatedGame.TabIndex = 5;
            this.CheckRatedGame.Text = "Rated game";
            this.CheckRatedGame.UseVisualStyleBackColor = true;
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
            // FormOnlineSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 301);
            this.Controls.Add(this.GroupCreateMatch);
            this.Controls.Add(this.GroupListenForMatch);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormOnlineSetup";
            this.Text = "FormOnlineSetup";
            this.Load += new System.EventHandler(this.FormOnlineSetup_Load);
            this.GroupListenForMatch.ResumeLayout(false);
            this.GroupListenForMatch.PerformLayout();
            this.GroupCreateMatch.ResumeLayout(false);
            this.GroupCreateMatch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlIncrement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NumTimeControlMins)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupListenForMatch;
        private System.Windows.Forms.TextBox TextYourIP;
        private System.Windows.Forms.Label LabelYourIP;
        private System.Windows.Forms.GroupBox GroupCreateMatch;
        private System.Windows.Forms.Button ButtonListenForMatch;
        private System.Windows.Forms.TextBox TextPortNum;
        private System.Windows.Forms.Label LabelPortNum;
        private System.Windows.Forms.Label LabelTimeControl;
        private System.Windows.Forms.Label LabelMins;
        private System.Windows.Forms.NumericUpDown NumTimeControlIncrement;
        private System.Windows.Forms.Label LabelSecPerTurn;
        private System.Windows.Forms.NumericUpDown NumTimeControlMins;
        private System.Windows.Forms.ComboBox ComboPlayAs;
        private System.Windows.Forms.CheckBox CheckRatedGame;
        private System.Windows.Forms.Button ButtonCreateMatch;
        private System.Windows.Forms.TextBox TextOpponentIPandPort;
        private System.Windows.Forms.Label LabelOpponentIPandPort;
    }
}