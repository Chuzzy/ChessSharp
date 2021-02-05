using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ChessDotNet;

namespace ChessInterface
{
    public partial class Form2PlayerBoard : Form
    {
        User currentUser;
        ChessGame chessGame;
        ChessBoard chessboard;

        public string selectedSquare;

        public Stopwatch WhiteStopwatch, BlackStopwatch;

        public TimeSpan WhiteTime, BlackTime, Increment;

        private void TimerClock_Tick(object sender, EventArgs e)
        {
            if (WhiteStopwatch.IsRunning)
            {
                LabelWhiteClock.Text = (WhiteTime - WhiteStopwatch.Elapsed).ToString(@"mm\:ss");
            }
            else
            {
                LabelBlackClock.Text = (BlackTime - BlackStopwatch.Elapsed).ToString(@"mm\:ss");
            }

            if (WhiteTime - WhiteStopwatch.Elapsed < TimeSpan.Zero)
            {
                StopGame("Black wins on time");
            }
            else if (BlackTime - BlackStopwatch.Elapsed < TimeSpan.Zero)
            {
                StopGame("White wins on time");
            }
        }

        private void StopGame(string reason)
        {
            TimerClock.Tick -= TimerClock_Tick;
            chessboard.SquareClicked -= Chessboard_SquareClicked;
            ButtonDraw.Enabled = false;
            MessageBox.Show(reason);
        }
                
        public Form2PlayerBoard(User user, int initialTime, int increment)
        {
            InitializeComponent();
            currentUser = user;
            WhiteTime = BlackTime = TimeSpan.FromMilliseconds(initialTime);
            Increment = TimeSpan.FromMilliseconds(increment);

            LabelWhiteClock.Text = WhiteTime.ToString(@"mm\:ss");
            LabelBlackClock.Text = BlackTime.ToString(@"mm\:ss");

            chessGame = new ChessGame();
            WhiteStopwatch = new Stopwatch();
            BlackStopwatch = new Stopwatch();
            
            chessboard = new ChessBoard(user.ChessSetPath, user.LightColor, user.DarkColor, 50)
            {
                Location = new Point(12, 12),
                Name = "chessboard",
                TabIndex = 0,
                FEN = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1",
            };

            chessboard.SquareClicked += Chessboard_SquareClicked;

            Controls.Add(chessboard);
        }

        /// <summary>
        /// Stops one person's clock and starts the other.
        /// </summary>
        private void HitClock()
        {
            if (WhiteStopwatch.IsRunning || (!WhiteStopwatch.IsRunning && !BlackStopwatch.IsRunning))
            {
                // Get Black's stopwatch going
                WhiteTime -= WhiteStopwatch.Elapsed;
                WhiteStopwatch.Reset();
                WhiteTime += Increment;
                LabelWhiteClock.Text = WhiteTime.ToString(@"mm\:ss");
                BlackStopwatch.Start();
            }
            else
            {
                // Get White's stopwatch going
                BlackTime -= BlackStopwatch.Elapsed;
                BlackStopwatch.Reset();
                BlackTime += Increment;
                LabelBlackClock.Text = BlackTime.ToString(@"mm\:ss");
                WhiteStopwatch.Start();
            }
        }

        private void Chessboard_SquareClicked(object sender, EventArgs e)
        {
            Panel squareClickedOn = sender as Panel;

            if (string.IsNullOrWhiteSpace(selectedSquare))
            {
                selectedSquare = squareClickedOn.Name;
                // Only highlight moves if the user clicked on a friendly piece
                if (chessGame.GetPieceAt(new Position(squareClickedOn.Name))?.Owner == chessGame.WhoseTurn)
                    HighlightMovesFromPosition(selectedSquare);
            }
            else
            {
                // If there is a friendly piece
                if (chessGame.GetPieceAt(new Position(squareClickedOn.Name))?.Owner == chessGame.WhoseTurn)
                {
                    // Select that piece instead
                    selectedSquare = squareClickedOn.Name;
                    HighlightMovesFromPosition(selectedSquare);
                } 
                else
                {
                    Move move;
                    // If we are moving a pawn to 8th/1st rank
                    if (chessGame.GetPieceAt(new Position(selectedSquare)) is ChessDotNet.Pieces.Pawn p &&
                        (selectedSquare.EndsWith(p.Owner == Player.White ? "7" : "2")) &&
                        (squareClickedOn.Name.EndsWith(p.Owner == Player.White ? "8" : "1")))
                    {
                        // Choose a promotion
                        var promotionForm = new FormPromotion(currentUser, chessGame.WhoseTurn == Player.White, "Promotion on square " + squareClickedOn.Name);
                        promotionForm.ShowDialog();
                        move = new Move(selectedSquare, squareClickedOn.Name, chessGame.WhoseTurn, promotionForm.PromotedTo[0]);
                    }
                    else
                    {                        
                        move = new Move(selectedSquare, squareClickedOn.Name, chessGame.WhoseTurn);
                    }

                    if (chessGame.IsValidMove(move))
                    {
                        chessGame.ApplyMove(move, true);
                        chessboard.FEN = chessGame.GetFen();

                        var lastMove = chessGame.Moves.Last();
                        string moveInSAN = DetailedMoveToString(lastMove, chessGame.IsInCheck(chessGame.WhoseTurn));

                        // If it was White to move last
                        if (chessGame.WhoseTurn == Player.Black)
                        {
                            MoveList.Rows.Add(moveInSAN);
                        }
                        else
                        {
                            MoveList.Rows[MoveList.Rows.GetLastRow(0)].Cells["ColumnBlack"].Value = moveInSAN;
                        }
                        HitClock();
                        chessboard.Flipped = !chessboard.Flipped;

                        // Test for checkmate, stalemate
                        if (chessGame.IsCheckmated(chessGame.WhoseTurn))
                        {
                            chessboard.UnhighlightSquares();
                            StopGame(Enum.GetName(typeof(Player), chessGame.WhoseTurn) + " has been checkmated");
                        }
                        else if (chessGame.IsStalemated(chessGame.WhoseTurn))
                        {
                            chessboard.UnhighlightSquares();
                            StopGame(Enum.GetName(typeof(Player), chessGame.WhoseTurn) + " has been stalemated");
                        }
                    }
                    else
                    {
                        selectedSquare = null;
                    }
                    chessboard.UnhighlightSquares();
                }
            }
        }

        private void ButtonDraw_Click(object sender, EventArgs e)
        {
            // Check if a draw can be automatically claimed
            if (chessGame.DrawCanBeClaimed)
            {
                chessGame.ClaimDraw("50-move rule");
                StopGame("Draw by 50-move rule");
            }
            else
            {
                var result = MessageBox.Show(Enum.GetName(typeof(Player), chessGame.WhoseTurn) + " offers a draw. Do you accept?", "Draw offer", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (result == DialogResult.Yes)
                {
                    StopGame("Draw by agreement");

                }
            }
        }

        private string DetailedMoveToString(DetailedMove move, bool check)
        {
            if (move.Castling == CastlingType.KingSide)
                return "O-O";
            else if (move.Castling == CastlingType.QueenSide)
                return "O-O-O";
            
            if (move.Piece is ChessDotNet.Pieces.Pawn)
            {
                string movetext;
                if (move.IsCapture)
                {
                    movetext = $"{move.OriginalPosition.ToString().ToLower()[0]}x{move.NewPosition.ToString().ToLower()}";
                }
                else
                {
                    movetext = move.NewPosition.ToString().ToLower();
                }

                if (move.Promotion.HasValue)
                {
                    movetext += "=" + move.Promotion.Value;
                }
                return movetext + (check ? "+" : "");
            }
            else
            {
                return $"{move.Piece.GetFenCharacter().ToString().ToUpper()}{(move.IsCapture ? 'x' : ' ')}{move.NewPosition.ToString().ToLower()}{(check ? '+' : ' ')}".Replace(" ", "");
            }
        }

        private void HighlightMovesFromPosition(string square)
        {
            IEnumerable<string> moves = chessGame.GetValidMoves(new Position(square)).Select(move => move.NewPosition.ToString().ToLower());
            chessboard.HighlightSquares(square, moves);
        }
    }
}
