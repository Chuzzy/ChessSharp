using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChessInterface
{
    public partial class ChessBoard : Panel
    {
        private Panel[,] boardSquares;
        private Label[] horizontalLabels, verticalLabels;
        private HashSet<Panel> highlightedSquares = new HashSet<Panel>();

        private Dictionary<char, Image> chessSet;

        private string chessSetPath;
        /// <summary>
        /// The folder containing the chess pieces.
        /// </summary>
        public string ChessSetPath
        {
            get => chessSetPath;
            set
            {
                var newChessSet = new Dictionary<char, Image>();
                char[] fenChars = { 'p', 'n', 'b', 'r', 'q', 'k', 'P', 'N', 'B', 'R', 'Q', 'K' };

                if (string.IsNullOrEmpty(value))
                {
                    Image[] defaultPieces =
                    {
                        Properties.Resources.BlackPawn,
                        Properties.Resources.BlackKnight,
                        Properties.Resources.BlackBishop,
                        Properties.Resources.BlackRook,
                        Properties.Resources.BlackQueen,
                        Properties.Resources.BlackKing,
                        Properties.Resources.WhitePawn,
                        Properties.Resources.WhiteKnight,
                        Properties.Resources.WhiteBishop,
                        Properties.Resources.WhiteRook,
                        Properties.Resources.WhiteQueen,
                        Properties.Resources.WhiteKing
                    };
                    for (int i = 0; i < 12; i++)
                    {
                        newChessSet.Add(fenChars[i], defaultPieces[i]);
                    }
                }
                else
                {
                    string[] pieces = { "bp.png", "bn.png", "bb.png", "br.png", "bq.png", "bk.png", "wp.png", "wn.png", "wb.png", "wr.png", "wq.png", "wk.png" };
                    for (int i = 0; i < 12; i++)
                    {
                        newChessSet.Add(fenChars[i], Image.FromFile(Path.Combine(value, pieces[i])));
                    }
                }

                chessSet = newChessSet;
                chessSetPath = value;
            }
        }
        
        private string fen;
        public string FEN
        {
            get => fen;
            set
            {
                var match = Regex.Match(value, @"^((?:(?:[KQRBNPkqrbnp1-8]){1,8}\/){7}[KQRBNPkqrbnp1-8]{1,8})");

                if (!match.Success)
                    throw new ArgumentException("Expected value to be FEN.");

                var positionFen = match.Groups[1].Value.Split('/').Reverse().ToArray();

                for (int rank = 0; rank <= 7; rank++)
                {
                    var currentRow = positionFen[rank];
                    int file = 0;

                    foreach (var @char in currentRow)
                    {
                        if (int.TryParse(@char.ToString(), out int numberOfEmptySquares))
                        {
                            for (int i = 0; i < numberOfEmptySquares; i++)
                            {
                                boardSquares[file, rank].BackgroundImage = null;
                                file++;
                            }
                        }
                        else
                        {
                            boardSquares[file, rank].BackgroundImage = chessSet[@char];
                            file++;
                        }
                    }
                }

                fen = value;
            }
        }
                private Color lightColor;

        /// <summary>
        /// The color used for the light squares on the chess board.
        /// </summary>
        public Color LightSquareColor
        {
            get => lightColor;
            set
            {
                lightColor = value;
            }
        }

        private Color darkColor;

        /// <summary>
        /// The color used for the dark squares on the chess board.
        /// </summary>
        public Color DarkSquareColor
        {
            get => darkColor;
            set
            {
                darkColor = value;
            }
        }

        /// <summary>
        /// Fired when a square is clicked.
        /// </summary>
        public event EventHandler SquareClicked;

        /// <summary>
        /// Highlights squares on the board.
        /// </summary>
        /// <param name="squares">The names of the squares to highlight.</param>
        public void HighlightSquares(params string[] squares)
        {
            HashSet<Panel> chosenSquares = new HashSet<Panel>();
            foreach (string squareName in squares)
            {
                // Ensure squareName is valid.
                if (!"abcdefgh".Contains(squareName[0]) || !"12345678".Contains(squareName[1]))
                    throw new ArgumentException($"Invalid square name {squareName}.", nameof(squares));

                Panel panel = Controls.Find(squareName, false)[0] as Panel;

                chosenSquares.Add(panel);
                panel.BackColor = Color.FromArgb(128, panel.BackColor);
            }

            foreach (var square in highlightedSquares.Except(chosenSquares))
            {
                square.BackColor = (Color)square.Tag;
            }

            highlightedSquares = chosenSquares;
        }

        /// <summary>
        /// Highlights moves on the board.
        /// </summary>
        /// <param name="fromSquare">The square being moved from.</param>
        /// <param name="toSquares">Squares that can be moved to.</param>
        internal void HighlightSquares(string fromSquare, IEnumerable<string> toSquares)
        {
            var squaresToHighlight = toSquares.ToList();
            squaresToHighlight.Add(fromSquare);
            HighlightSquares(squaresToHighlight.ToArray());
        }

        /// <summary>
        /// Unhighlights all squares.
        /// </summary>
        public void UnhighlightSquares()
        {
            foreach (var square in highlightedSquares)
            {
                square.BackColor = (Color)square.Tag;
            }
            highlightedSquares.Clear();
        }

        private bool flipped;
        /// <summary>
        /// Whether the board is flipped (viewed from Black's perspective instead of White's).
        /// </summary>
        public bool Flipped
        {
            get => flipped;
            set
            {
                if (flipped != value)
                {
                    flipped = value;
                    FlipBoard();
                }
            }
        }

        /// <summary>
        /// Flips the orientation of the board.
        /// </summary>
        private void FlipBoard()
        {
            int SQUARE_SIZE = Size.Width / 8;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Panel panel = boardSquares[j, i];
                    panel.Location = new Point(Size.Width - panel.Location.X - SQUARE_SIZE, Size.Height - panel.Location.Y - SQUARE_SIZE);
                }
            }

            if (flipped)
            {
                for (int i = 0; i < 8; i++)
                {
                    // Move horizontal labels to 8th rank
                    boardSquares[i, 0].Controls.Remove(horizontalLabels[i]);
                    boardSquares[i, 7].Controls.Add(horizontalLabels[i]);
                    horizontalLabels[i].ForeColor = i % 2 == 1 ? lightColor : darkColor;

                    // Move vertical labels to h-file
                    boardSquares[0, i].Controls.Remove(verticalLabels[i]);
                    boardSquares[7, i].Controls.Add(verticalLabels[i]);
                    verticalLabels[i].ForeColor = i % 2 == 1 ? lightColor : darkColor;
                }
            }
            else
            {
                for (int i = 0; i < 8; i++)
                {
                    // Move horizontal labels to 1st rank
                    boardSquares[i, 7].Controls.Remove(horizontalLabels[i]);
                    boardSquares[i, 0].Controls.Add(horizontalLabels[i]);
                    horizontalLabels[i].ForeColor = i % 2 == 0 ? lightColor : darkColor;

                    // Move vertical labels to a-file
                    boardSquares[7, i].Controls.Remove(verticalLabels[i]);
                    boardSquares[0, i].Controls.Add(verticalLabels[i]);
                    verticalLabels[i].ForeColor = i % 2 == 0 ? lightColor : darkColor;
                }
            }
        }

        /// <summary>
        /// Creates 64 panels that make up the chess board.
        /// </summary>
        private void CreatePanels()
        {
            BackColor = Color.FromArgb(0, 255, 0);
            int squareSize = Math.Min(Size.Width, Size.Height) / 8;

            boardSquares = new Panel[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Panel panel = new Panel()
                    {
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Name = "abcdefgh"[j].ToString() + "12345678"[i],
                        Location = new Point(squareSize * j, squareSize * 7 - squareSize * i),
                        Size = new Size(squareSize, squareSize),
                        TabStop = false,
                        Tag = i % 2 == 0 ? (j % 2 == 0 ? darkColor : lightColor) : (j % 2 == 0 ? lightColor : darkColor)
                    };

                    panel.Click += Panel_Click;
                    if (i % 2 == 0)
                        panel.BackColor = j % 2 == 0 ? darkColor : lightColor;
                    else
                        panel.BackColor = j % 2 == 0 ? lightColor : darkColor;

                    Controls.Add(panel);
                    boardSquares[j, i] = panel;
                }
            }

            horizontalLabels = new Label[8];

            // Create horizontal labels
            for (int i = 0; i < 8; i++)
            {
                Label label = new Label()
                {
                    Text = "abcdefgh"[i].ToString(),
                    AutoSize = true,
                    ForeColor = i % 2 == 0 ? lightColor : darkColor,
                    BackColor = Color.FromArgb(0, 0, 0, 0)
                };
                label.Location = new Point(squareSize - 12, squareSize - label.Font.Height - 3);

                boardSquares[i, 0].Controls.Add(label);
                horizontalLabels[i] = label;
            }

            verticalLabels = new Label[8];

            // Create vertical labels
            for (int i = 0; i < 8; i++)
            {
                Label label = new Label()
                {
                    Text = "12345678"[i].ToString(),
                    AutoSize = true,
                    ForeColor = i % 2 == 0 ? lightColor : darkColor,
                    BackColor = Color.FromArgb(0, 0, 0, 0)
                };
                label.Location = new Point(0, 0);

                boardSquares[0, i].Controls.Add(label);
                verticalLabels[i] = label;
            }
        }

        private void Panel_Click(object sender, EventArgs e)
        {
            SquareClicked?.Invoke(sender, e);
        }

        public ChessBoard(string chessSetPath, Color light, Color dark, int squareSize)
        {
            InitializeComponent();
            Size = new Size(squareSize * 8, squareSize * 8);
            LightSquareColor = light; DarkSquareColor = dark;
            ChessSetPath = chessSetPath;
            CreatePanels();
        }
    }
}
