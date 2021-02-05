using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ChessInterface
{
    public partial class FormStats : Form
    {
        private Dictionary<DateTime, double> ratingData = new Dictionary<DateTime, double>();

        public FormStats()
        {
            InitializeComponent();
        }

        private void FormStats_Load(object sender, EventArgs e)
        {
            var random = new Random();
            for (int i = 1; i < 31; i++)
            {
                var pastDate = DateTime.Now.AddDays(-i);
                var randomRating = random.Next(400, 2001);

                ratingData.Add(pastDate, randomRating);

                ChartRating.Series["Rating"].Points.AddXY(pastDate, randomRating);
            }
        }

        private void ChartRating_MouseMove(object sender, MouseEventArgs e)
        {
            HitTestResult result = ChartRating.HitTest(e.X, e.Y);
            if (result.ChartElementType == ChartElementType.DataPoint) {
                DateTime selectedDate = DateTime.FromOADate(ChartRating.Series[0].Points[result.PointIndex].XValue);
                double selectedRating = ChartRating.Series[0].Points[result.PointIndex].YValues[0];
                LblSelectedPointInfo.Text = "(" + selectedDate.ToShortDateString() + ", " + selectedRating + ")";
            }
        }
    }
}
