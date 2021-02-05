using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ChessDotNet;
using System.Threading;

namespace ChessInterface
{
    public partial class FormComputerBoard : Form
    {
        User currentUser;
        ChessGame chessGame;
        ChessBoard chessboard;
        public string selectedSquare;

        Process chessEngineProcess;
        int ThinkingTime;

        private void StopGame(string reason)
        {
            chessboard.SquareClicked -= Chessboard_SquareClicked;
            MessageBox.Show(reason);
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

        private async void MakeComputerMove()
        {
            // Set the fen
            chessEngineProcess.StandardInput.WriteLine("position fen " + chessGame.GetFen());
            chessEngineProcess.StandardInput.WriteLine("go movetime " + (ThinkingTime));

            // Keep reading lines until "bestmove" comes up
            string programOutput;
            do
            {
                programOutput = await chessEngineProcess.StandardOutput.ReadLineAsync();
            } while (!programOutput.StartsWith("bestmove"));

            // Make that move
            // TODO: Fix
            programOutput = programOutput.Remove(0, 9);
            chessGame.ApplyMove(new Move(programOutput.Substring(0, 2), programOutput.Substring(2, 2), chessGame.WhoseTurn,
                programOutput.Length == 5 ? programOutput[4] as char? : null), true);

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
            else
            {
                chessboard.SquareClicked += Chessboard_SquareClicked;
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
                        else
                        {
                            chessboard.UnhighlightSquares();
                            MakeComputerMove();
                            chessboard.SquareClicked -= Chessboard_SquareClicked;
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
        
        public FormComputerBoard(User user, int computerSkillLevel, string playAs)
        {
            InitializeComponent();
            currentUser = user;

            chessGame = new ChessGame("2k5/6KP/8/8/8/8/8/8 w - - 0 1");
            chessboard = new ChessBoard(user.ChessSetPath, user.LightColor, user.DarkColor, 50)
            {
                Location = new Point(12, 12),
                Name = "chessboard",
                TabIndex = 0,
                FEN = "2k5/6KP/8/8/8/8/8/8 w - -",
            };
            if (playAs == "Black")
                chessboard.Flipped = true;
            else
                chessboard.SquareClicked += Chessboard_SquareClicked;

            Controls.Add(chessboard);

            chessEngineProcess = new Process()
            {
                StartInfo = new ProcessStartInfo() {
                    FileName = "stockfish_9_x64.exe",
                    RedirectStandardInput = true,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };
            chessEngineProcess.OutputDataReceived += ChessEngineProcess_OutputDataReceived;

            chessEngineProcess.Start();

            chessEngineProcess.StandardInput.WriteLine("setoption name Skill Level value " + computerSkillLevel);
            chessEngineProcess.StandardInput.WriteLine("ucinewgame");
            chessEngineProcess.StandardInput.Flush();
            chessEngineProcess.StandardOutput.ReadLine();

            ThinkingTime = Math.Max(computerSkillLevel * 100, 2000);

            if (playAs == "Black")
                MakeComputerMove();            
        }

        private void ChessEngineProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
        {
            if (e.Data != null)
            {
                MessageBox.Show(e.Data);
            }
        }

        private void FormComputerBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            chessEngineProcess.Close();
            chessEngineProcess.Dispose();
        }
    }
}
