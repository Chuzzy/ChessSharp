using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessInterface
{
    public partial class FormBoard : Form
    {
        ChessBoard chessboard;
        public FormBoard(User currentUser)
        {
            InitializeComponent();

            chessboard = new ChessBoard(currentUser.ChessSetPath, currentUser.LightColor, currentUser.DarkColor, 50)
            {
                Location = new Point(12, 12),
                Name = "chessboard",
                TabIndex = 0,
                FEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1"
            };

            chessboard.SquareClicked += Chessboard_SquareClicked;

            Controls.Add(chessboard);
        }

        private void Chessboard_SquareClicked(object sender, EventArgs e)
        {
            Panel squareClickedOn = sender as Panel;
            chessboard.HighlightSquares(squareClickedOn.Name);
            MessageBox.Show(squareClickedOn.Name);
            chessboard.Flipped = !chessboard.Flipped;
            chessboard.FEN = "r1bqkbnr/1pp2ppp/p1p5/4N3/4P3/8/PPPP1PPP/RNBQK2R b KQkq - 0 5";
        }
    }
}
