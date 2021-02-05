using System.Drawing;

namespace ChessInterface
{
    partial class FormMainMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ButtonPlayOnline = new System.Windows.Forms.Button();
            this.ButtonPlayOffline = new System.Windows.Forms.Button();
            this.ButtonAnalysisBoard = new System.Windows.Forms.Button();
            this.ButtonStatistics = new System.Windows.Forms.Button();
            this.ButtonOptions = new System.Windows.Forms.Button();
            this.RtbUserInfo = new System.Windows.Forms.RichTextBox();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.ButtonPlayOnline);
            this.flowLayoutPanel1.Controls.Add(this.ButtonPlayOffline);
            this.flowLayoutPanel1.Controls.Add(this.ButtonAnalysisBoard);
            this.flowLayoutPanel1.Controls.Add(this.ButtonStatistics);
            this.flowLayoutPanel1.Controls.Add(this.ButtonOptions);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 74);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(267, 286);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // ButtonPlayOnline
            // 
            this.ButtonPlayOnline.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlayOnline.Location = new System.Drawing.Point(3, 3);
            this.ButtonPlayOnline.Name = "ButtonPlayOnline";
            this.ButtonPlayOnline.Size = new System.Drawing.Size(261, 50);
            this.ButtonPlayOnline.TabIndex = 8;
            this.ButtonPlayOnline.Text = "Play Online";
            this.ButtonPlayOnline.UseVisualStyleBackColor = true;
            this.ButtonPlayOnline.Click += new System.EventHandler(this.ButtonPlayOnline_Click);
            // 
            // ButtonPlayOffline
            // 
            this.ButtonPlayOffline.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonPlayOffline.Location = new System.Drawing.Point(3, 59);
            this.ButtonPlayOffline.Name = "ButtonPlayOffline";
            this.ButtonPlayOffline.Size = new System.Drawing.Size(261, 50);
            this.ButtonPlayOffline.TabIndex = 9;
            this.ButtonPlayOffline.Text = "Play Offline";
            this.ButtonPlayOffline.UseVisualStyleBackColor = true;
            this.ButtonPlayOffline.Click += new System.EventHandler(this.ButtonPlayOffline_Click);
            // 
            // ButtonAnalysisBoard
            // 
            this.ButtonAnalysisBoard.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonAnalysisBoard.Location = new System.Drawing.Point(3, 115);
            this.ButtonAnalysisBoard.Name = "ButtonAnalysisBoard";
            this.ButtonAnalysisBoard.Size = new System.Drawing.Size(261, 50);
            this.ButtonAnalysisBoard.TabIndex = 10;
            this.ButtonAnalysisBoard.Text = "Analysis Board";
            this.ButtonAnalysisBoard.UseVisualStyleBackColor = true;
            // 
            // ButtonStatistics
            // 
            this.ButtonStatistics.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonStatistics.Location = new System.Drawing.Point(3, 171);
            this.ButtonStatistics.Name = "ButtonStatistics";
            this.ButtonStatistics.Size = new System.Drawing.Size(261, 50);
            this.ButtonStatistics.TabIndex = 11;
            this.ButtonStatistics.Text = "View Stats";
            this.ButtonStatistics.UseVisualStyleBackColor = true;
            // 
            // ButtonOptions
            // 
            this.ButtonOptions.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonOptions.Location = new System.Drawing.Point(3, 227);
            this.ButtonOptions.Name = "ButtonOptions";
            this.ButtonOptions.Size = new System.Drawing.Size(261, 50);
            this.ButtonOptions.TabIndex = 12;
            this.ButtonOptions.Text = "Options";
            this.ButtonOptions.UseVisualStyleBackColor = true;
            this.ButtonOptions.Click += new System.EventHandler(this.ButtonOptions_Click);
            // 
            // RtbUserInfo
            // 
            this.RtbUserInfo.Location = new System.Drawing.Point(285, 74);
            this.RtbUserInfo.Name = "RtbUserInfo";
            this.RtbUserInfo.ReadOnly = true;
            this.RtbUserInfo.Size = new System.Drawing.Size(287, 275);
            this.RtbUserInfo.TabIndex = 13;
            this.RtbUserInfo.Text = "";
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 6);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(560, 65);
            this.LabelTitle.TabIndex = 7;
            this.LabelTitle.Text = "Chess";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.RtbUserInfo);
            this.Controls.Add(this.LabelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormMainMenu";
            this.Text = "Chess";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button ButtonPlayOffline;
        private System.Windows.Forms.Button ButtonStatistics;
        private System.Windows.Forms.RichTextBox RtbUserInfo;
        private System.Windows.Forms.Button ButtonOptions;
        private System.Windows.Forms.Button ButtonAnalysisBoard;
        private System.Windows.Forms.Button ButtonPlayOnline;
        private System.Windows.Forms.Label LabelTitle;
    }
}

