namespace ChessInterface
{
    partial class FormStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 34D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 12D);
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 8D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 7D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 37D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(0D, 20D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TabUserStats = new System.Windows.Forms.TabControl();
            this.TabPageGameStats = new System.Windows.Forms.TabPage();
            this.ChartGameStats = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabPageRating = new System.Windows.Forms.TabPage();
            this.LblSelectedPointInfo = new System.Windows.Forms.Label();
            this.BtnChangeView = new System.Windows.Forms.Button();
            this.BtnNext = new System.Windows.Forms.Button();
            this.BtnPrevious = new System.Windows.Forms.Button();
            this.ChartRating = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TabUserStats.SuspendLayout();
            this.TabPageGameStats.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartGameStats)).BeginInit();
            this.TabPageRating.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ChartRating)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelTitle
            // 
            this.LabelTitle.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelTitle.Location = new System.Drawing.Point(12, 9);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(691, 65);
            this.LabelTitle.TabIndex = 1;
            this.LabelTitle.Text = "Stats";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // TabUserStats
            // 
            this.TabUserStats.Controls.Add(this.TabPageGameStats);
            this.TabUserStats.Controls.Add(this.TabPageRating);
            this.TabUserStats.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.TabUserStats.Location = new System.Drawing.Point(12, 77);
            this.TabUserStats.Name = "TabUserStats";
            this.TabUserStats.SelectedIndex = 0;
            this.TabUserStats.Size = new System.Drawing.Size(691, 390);
            this.TabUserStats.TabIndex = 3;
            // 
            // TabPageGameStats
            // 
            this.TabPageGameStats.Controls.Add(this.ChartGameStats);
            this.TabPageGameStats.Location = new System.Drawing.Point(4, 24);
            this.TabPageGameStats.Name = "TabPageGameStats";
            this.TabPageGameStats.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageGameStats.Size = new System.Drawing.Size(683, 362);
            this.TabPageGameStats.TabIndex = 0;
            this.TabPageGameStats.Text = "Game Results";
            this.TabPageGameStats.UseVisualStyleBackColor = true;
            // 
            // ChartGameStats
            // 
            chartArea1.AxisX.IsLabelAutoFit = false;
            chartArea1.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisX.MajorGrid.Enabled = false;
            chartArea1.AxisX.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisX2.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY.IsLabelAutoFit = false;
            chartArea1.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY.MinorGrid.Enabled = true;
            chartArea1.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea1.AxisY.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.AxisY2.ScaleBreakStyle.Enabled = true;
            chartArea1.AxisY2.TitleAlignment = System.Drawing.StringAlignment.Far;
            chartArea1.AxisY2.TitleFont = new System.Drawing.Font("Segoe UI", 9F);
            chartArea1.Name = "ChartArea1";
            this.ChartGameStats.ChartAreas.Add(chartArea1);
            legend1.Font = new System.Drawing.Font("Segoe UI", 9F);
            legend1.IsTextAutoFit = false;
            legend1.Name = "Legend1";
            legend1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ChartGameStats.Legends.Add(legend1);
            this.ChartGameStats.Location = new System.Drawing.Point(6, 6);
            this.ChartGameStats.Name = "ChartGameStats";
            this.ChartGameStats.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.ChartGameStats.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))))};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Wins";
            dataPoint1.AxisLabel = "White";
            dataPoint1.Label = "#VAL #SERIESNAME as #AXISLABEL";
            dataPoint2.AxisLabel = "Black";
            dataPoint2.Label = "#VAL #SERIESNAME as #AXISLABEL";
            series1.Points.Add(dataPoint1);
            series1.Points.Add(dataPoint2);
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            series2.Legend = "Legend1";
            series2.Name = "Draws";
            dataPoint3.AxisLabel = "White";
            dataPoint3.Label = "#VAL #SERIESNAME as #AXISLABEL";
            dataPoint4.AxisLabel = "Black";
            dataPoint4.Label = "#VAL #SERIESNAME as #AXISLABEL";
            series2.Points.Add(dataPoint3);
            series2.Points.Add(dataPoint4);
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series3.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            series3.Legend = "Legend1";
            series3.Name = "Losses";
            dataPoint5.AxisLabel = "White";
            dataPoint5.Label = "#VAL #SERIESNAME as #AXISLABEL";
            dataPoint6.AxisLabel = "Black";
            dataPoint6.Label = "#VAL #SERIESNAME as #AXISLABEL";
            series3.Points.Add(dataPoint5);
            series3.Points.Add(dataPoint6);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            this.ChartGameStats.Series.Add(series1);
            this.ChartGameStats.Series.Add(series2);
            this.ChartGameStats.Series.Add(series3);
            this.ChartGameStats.Size = new System.Drawing.Size(660, 350);
            this.ChartGameStats.TabIndex = 0;
            this.ChartGameStats.Text = "Wins, Draws and Losses";
            // 
            // TabPageRating
            // 
            this.TabPageRating.Controls.Add(this.LblSelectedPointInfo);
            this.TabPageRating.Controls.Add(this.BtnChangeView);
            this.TabPageRating.Controls.Add(this.BtnNext);
            this.TabPageRating.Controls.Add(this.BtnPrevious);
            this.TabPageRating.Controls.Add(this.ChartRating);
            this.TabPageRating.Location = new System.Drawing.Point(4, 24);
            this.TabPageRating.Name = "TabPageRating";
            this.TabPageRating.Padding = new System.Windows.Forms.Padding(3);
            this.TabPageRating.Size = new System.Drawing.Size(683, 362);
            this.TabPageRating.TabIndex = 1;
            this.TabPageRating.Text = "Rating";
            this.TabPageRating.UseVisualStyleBackColor = true;
            // 
            // LblSelectedPointInfo
            // 
            this.LblSelectedPointInfo.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblSelectedPointInfo.Location = new System.Drawing.Point(317, 308);
            this.LblSelectedPointInfo.Name = "LblSelectedPointInfo";
            this.LblSelectedPointInfo.Size = new System.Drawing.Size(360, 47);
            this.LblSelectedPointInfo.TabIndex = 4;
            this.LblSelectedPointInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnChangeView
            // 
            this.BtnChangeView.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnChangeView.Location = new System.Drawing.Point(6, 306);
            this.BtnChangeView.Name = "BtnChangeView";
            this.BtnChangeView.Size = new System.Drawing.Size(182, 50);
            this.BtnChangeView.TabIndex = 3;
            this.BtnChangeView.Text = "Week View";
            this.BtnChangeView.UseVisualStyleBackColor = true;
            // 
            // BtnNext
            // 
            this.BtnNext.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.Location = new System.Drawing.Point(250, 306);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(50, 50);
            this.BtnNext.TabIndex = 2;
            this.BtnNext.Text = ">";
            this.BtnNext.UseVisualStyleBackColor = true;
            // 
            // BtnPrevious
            // 
            this.BtnPrevious.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPrevious.Location = new System.Drawing.Point(194, 306);
            this.BtnPrevious.Name = "BtnPrevious";
            this.BtnPrevious.Size = new System.Drawing.Size(50, 50);
            this.BtnPrevious.TabIndex = 1;
            this.BtnPrevious.Text = "<";
            this.BtnPrevious.UseVisualStyleBackColor = true;
            // 
            // ChartRating
            // 
            chartArea2.AxisX.IsLabelAutoFit = false;
            chartArea2.AxisX.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisY.IsLabelAutoFit = false;
            chartArea2.AxisY.LabelStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            chartArea2.AxisY.MinorGrid.Enabled = true;
            chartArea2.AxisY.MinorGrid.LineColor = System.Drawing.Color.Gray;
            chartArea2.AxisY.MinorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea2.Name = "ChartArea1";
            this.ChartRating.ChartAreas.Add(chartArea2);
            this.ChartRating.Location = new System.Drawing.Point(6, 6);
            this.ChartRating.Name = "ChartRating";
            this.ChartRating.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel;
            series4.BorderWidth = 5;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.MarkerColor = System.Drawing.Color.Red;
            series4.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series4.Name = "Rating";
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
            series4.YValuesPerPoint = 2;
            this.ChartRating.Series.Add(series4);
            this.ChartRating.Size = new System.Drawing.Size(660, 300);
            this.ChartRating.TabIndex = 0;
            this.ChartRating.Text = "ChartRating";
            this.ChartRating.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ChartRating_MouseMove);
            // 
            // FormStats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 499);
            this.Controls.Add(this.TabUserStats);
            this.Controls.Add(this.LabelTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormStats";
            this.Text = "Stats - Chess";
            this.Load += new System.EventHandler(this.FormStats_Load);
            this.TabUserStats.ResumeLayout(false);
            this.TabPageGameStats.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartGameStats)).EndInit();
            this.TabPageRating.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ChartRating)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LabelTitle;
        internal System.Windows.Forms.TabControl TabUserStats;
        internal System.Windows.Forms.TabPage TabPageGameStats;
        internal System.Windows.Forms.DataVisualization.Charting.Chart ChartGameStats;
        internal System.Windows.Forms.TabPage TabPageRating;
        internal System.Windows.Forms.Label LblSelectedPointInfo;
        internal System.Windows.Forms.Button BtnChangeView;
        internal System.Windows.Forms.Button BtnNext;
        internal System.Windows.Forms.Button BtnPrevious;
        internal System.Windows.Forms.DataVisualization.Charting.Chart ChartRating;
    }
}