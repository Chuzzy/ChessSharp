namespace ChessInterface
{
    partial class FormOptions
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
            this.ChkAnnounceMoves = new System.Windows.Forms.CheckBox();
            this.FolderBrowserChessSet = new System.Windows.Forms.FolderBrowserDialog();
            this.ButtonLoadChessSet = new System.Windows.Forms.Button();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextChessSetPath = new System.Windows.Forms.TextBox();
            this.GroupCustomSettings = new System.Windows.Forms.GroupBox();
            this.ButtonChangeDarkColor = new System.Windows.Forms.Button();
            this.ButtonChangeLightColor = new System.Windows.Forms.Button();
            this.LabelName = new System.Windows.Forms.Label();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.ColorPicker = new System.Windows.Forms.ColorDialog();
            this.CheckCustomChessSet = new System.Windows.Forms.CheckBox();
            this.GroupCustomSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // ChkAnnounceMoves
            // 
            this.ChkAnnounceMoves.AutoSize = true;
            this.ChkAnnounceMoves.Location = new System.Drawing.Point(12, 77);
            this.ChkAnnounceMoves.Name = "ChkAnnounceMoves";
            this.ChkAnnounceMoves.Size = new System.Drawing.Size(119, 19);
            this.ChkAnnounceMoves.TabIndex = 0;
            this.ChkAnnounceMoves.Text = "Announce moves";
            this.ChkAnnounceMoves.UseVisualStyleBackColor = true;
            // 
            // FolderBrowserChessSet
            // 
            this.FolderBrowserChessSet.Description = "Load a chess set";
            this.FolderBrowserChessSet.ShowNewFolderButton = false;
            // 
            // ButtonLoadChessSet
            // 
            this.ButtonLoadChessSet.Location = new System.Drawing.Point(248, 71);
            this.ButtonLoadChessSet.Name = "ButtonLoadChessSet";
            this.ButtonLoadChessSet.Size = new System.Drawing.Size(106, 23);
            this.ButtonLoadChessSet.TabIndex = 1;
            this.ButtonLoadChessSet.Text = "Load chess set";
            this.ButtonLoadChessSet.UseVisualStyleBackColor = true;
            this.ButtonLoadChessSet.Click += new System.EventHandler(this.ButtonLoadChessSet_Click);
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(360, 65);
            this.LabelTitle.TabIndex = 2;
            this.LabelTitle.Text = "Options";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(214, 75);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(158, 23);
            this.TextName.TabIndex = 3;
            // 
            // TextChessSetPath
            // 
            this.TextChessSetPath.Location = new System.Drawing.Point(6, 47);
            this.TextChessSetPath.Name = "TextChessSetPath";
            this.TextChessSetPath.Size = new System.Drawing.Size(348, 23);
            this.TextChessSetPath.TabIndex = 5;
            this.TextChessSetPath.Leave += new System.EventHandler(this.TextChessSetPath_Leave);
            // 
            // GroupCustomSettings
            // 
            this.GroupCustomSettings.Controls.Add(this.CheckCustomChessSet);
            this.GroupCustomSettings.Controls.Add(this.ButtonChangeDarkColor);
            this.GroupCustomSettings.Controls.Add(this.ButtonChangeLightColor);
            this.GroupCustomSettings.Controls.Add(this.TextChessSetPath);
            this.GroupCustomSettings.Controls.Add(this.ButtonLoadChessSet);
            this.GroupCustomSettings.Location = new System.Drawing.Point(12, 104);
            this.GroupCustomSettings.Name = "GroupCustomSettings";
            this.GroupCustomSettings.Size = new System.Drawing.Size(360, 241);
            this.GroupCustomSettings.TabIndex = 6;
            this.GroupCustomSettings.TabStop = false;
            this.GroupCustomSettings.Text = "Board Settings";
            // 
            // ButtonChangeDarkColor
            // 
            this.ButtonChangeDarkColor.Location = new System.Drawing.Point(201, 212);
            this.ButtonChangeDarkColor.Name = "ButtonChangeDarkColor";
            this.ButtonChangeDarkColor.Size = new System.Drawing.Size(153, 23);
            this.ButtonChangeDarkColor.TabIndex = 7;
            this.ButtonChangeDarkColor.Text = "Change dark square color";
            this.ButtonChangeDarkColor.UseVisualStyleBackColor = true;
            this.ButtonChangeDarkColor.Click += new System.EventHandler(this.ButtonChangeDarkColor_Click);
            // 
            // ButtonChangeLightColor
            // 
            this.ButtonChangeLightColor.Location = new System.Drawing.Point(6, 212);
            this.ButtonChangeLightColor.Name = "ButtonChangeLightColor";
            this.ButtonChangeLightColor.Size = new System.Drawing.Size(153, 23);
            this.ButtonChangeLightColor.TabIndex = 6;
            this.ButtonChangeLightColor.Text = "Change light square color";
            this.ButtonChangeLightColor.UseVisualStyleBackColor = true;
            this.ButtonChangeLightColor.Click += new System.EventHandler(this.ButtonChangeLightColor_Click);
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(166, 78);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(42, 15);
            this.LabelName.TabIndex = 7;
            this.LabelName.Text = "Name:";
            // 
            // pictureBox10
            // 
            this.pictureBox10.Location = new System.Drawing.Point(137, 260);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(50, 50);
            this.pictureBox10.TabIndex = 14;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.Location = new System.Drawing.Point(81, 260);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(50, 50);
            this.pictureBox11.TabIndex = 13;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.Location = new System.Drawing.Point(25, 260);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(50, 50);
            this.pictureBox12.TabIndex = 12;
            this.pictureBox12.TabStop = false;
            // 
            // CheckCustomChessSet
            // 
            this.CheckCustomChessSet.AutoSize = true;
            this.CheckCustomChessSet.Location = new System.Drawing.Point(6, 22);
            this.CheckCustomChessSet.Name = "CheckCustomChessSet";
            this.CheckCustomChessSet.Size = new System.Drawing.Size(147, 19);
            this.CheckCustomChessSet.TabIndex = 8;
            this.CheckCustomChessSet.Text = "Use a custom chess set";
            this.CheckCustomChessSet.UseVisualStyleBackColor = true;
            this.CheckCustomChessSet.CheckedChanged += new System.EventHandler(this.CheckCustomChessSet_CheckedChanged);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 352);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.GroupCustomSettings);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.LabelTitle);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.ChkAnnounceMoves);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "FormOptions";
            this.Text = "Options - Chess";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormOptions_FormClosing);
            this.GroupCustomSettings.ResumeLayout(false);
            this.GroupCustomSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox ChkAnnounceMoves;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserChessSet;
        private System.Windows.Forms.Button ButtonLoadChessSet;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextChessSetPath;
        private System.Windows.Forms.GroupBox GroupCustomSettings;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
        private System.Windows.Forms.ColorDialog ColorPicker;
        private System.Windows.Forms.Button ButtonChangeLightColor;
        private System.Windows.Forms.Button ButtonChangeDarkColor;
        private System.Windows.Forms.CheckBox CheckCustomChessSet;
    }
}