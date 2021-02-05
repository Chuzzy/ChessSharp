using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp
{
    /// <summary>
    /// A square on a chessboard.
    /// </summary>
    public class Square
    {
        /// <summary>
        /// The piece on this square.
        /// </summary>
        public Piece Piece { get; internal set; }

        /// <summary>
        /// The <see cref="ChessGame"/> this square belongs to.
        /// </summary>
        public readonly ChessGame Game;

        /// <summary>
        /// The player that is attacking this square.
        /// </summary>
        internal Player AttackedBy { get; set; }

        /// <summary>
        /// If the current side to move is in check, 
        /// whether it is possible for a piece to move to this square to block it.
        /// </summary>
        internal bool ThreatToKing { get; set; }

        /// <summary>
        /// The zero-based index of the square's file.
        /// </summary>
        internal readonly int FileIndex;

        /// <summary>
        /// The zero-based index of the square's rank.
        /// </summary>
        internal readonly int RankIndex;

        /// <summary>
        /// The vertical file (a-h) of this square.
        /// </summary>
        public char File => "abcdefgh"[FileIndex];

        /// <summary>
        /// The horizontal rank (1-8) of this square.
        /// </summary>
        public char Rank => "12345678"[RankIndex];

        #region Directional square collections
        /// <summary>
        /// All of the squares to the north of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> NorthSquares
        {
            get; private set;
        }

        /// <summary>
        /// All of the squares to the south of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> SouthSquares
        {
            get; private set;
        }

        /// <summary>
        /// All of the squares to the east of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> EastSquares
        {
            get; private set;
        }

        /// <summary>
        /// All of the squares to the west of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> WestSquares
        {
            get; private set;
        }

        /// <summary>
        /// All the squares to the northeast of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> NortheastSquares
        {
            get; private set;
        }

        /// <summary>
        /// All the squares to the northwest of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> NorthwestSquares
        {
            get; private set;
        }

        /// <summary>
        /// All the squares to the southwest of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> SouthwestSquares
        {
            get; private set;
        }

        /// <summary>
        /// All the squares to the southeast of this square.
        /// </summary>
        internal ReadOnlyCollection<Square> SoutheastSquares
        {
            get; private set;
        }
        #endregion

        /// <summary>
        /// Once the chessboard has been initialized, initializes the square's 8 directional square lists.
        /// </summary>
        internal void UpdateDirectionalSquares()
        {
            List<Square> squares;

            #region North Squares
            squares = new List<Square>();
            for (int r = RankIndex; r <= 7; r++)
                squares.Add(Game[FileIndex, r]);

            NorthSquares = new ReadOnlyCollection<Square>(squares);
            #endregion

            #region South Squares
            squares = new List<Square>();
            for (int r = RankIndex; r >= 0; r--)
                squares.Add(Game[FileIndex, r]);

            SouthSquares = new ReadOnlyCollection<Square>(squares);
            #endregion

            #region East Squares
            squares = new List<Square>();
            for (int f = FileIndex; f <= 7; f++)
                squares.Add(Game[f, RankIndex]);

            EastSquares = new ReadOnlyCollection<Square>(squares);
            #endregion

            #region West Squares
            squares = new List<Square>();
            for (int f = FileIndex; f >= 0; f--)
                squares.Add(Game[f, RankIndex]);

            WestSquares = new ReadOnlyCollection<Square>(squares);
            #endregion

            #region Northeast Squares
            squares = new List<Square>();
            for (int f = FileIndex, r = RankIndex; f <= 7 && r <= 7; f++, r++)
                squares.Add(Game[f, r]);

            NorthwestSquares = new ReadOnlyCollection<Square>(squares);
            #endregion

            #region Northwest Squares
            squares = new List<Square>();
            for (int f = FileIndex, r = RankIndex; f >= 0 && r <= 7; f--, r++)
                squares.Add(Game[f, r]);

            NorthwestSquares = new ReadOnlyCollection<Square>(squares);
            #endregion

            #region Southwest Squares
            squares = new List<Square>();
            for (int f = FileIndex, r = RankIndex; f >= 0 && r >= 0; f--, r--)
                squares.Add(Game[f, r]);

            SouthwestSquares = new ReadOnlyCollection<Square>(squares);
            #endregion

            #region Southeast Squares
            squares = new List<Square>();
            for (int f = FileIndex, r = RankIndex; f <= 7 && r >= 0; f++, r--)
                squares.Add(Game[f, r]);

            SoutheastSquares = new ReadOnlyCollection<Square>(squares);
            #endregion
        }

        internal Square(ChessGame game, int file, int rank)
        {
            Game = game;
            FileIndex = file;
            RankIndex = rank;
        }

        /// <summary>
        /// Returns a string representation of this square.
        /// </summary>
        public override string ToString() => File.ToString() + Rank.ToString();
    }
}
