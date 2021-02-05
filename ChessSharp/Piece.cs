using ChessSharp.Pieces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp
{
    /// <summary>
    /// A piece in a game of chess.
    /// </summary>
    public abstract class Piece
    {
        /// <summary>
        /// Iterates over an array of squares and stops as soon as a piece is reached.
        /// </summary>
        /// <param name="directionalSquares">A list of squares returned by a directional square function.</param>
        static protected IEnumerable<Square> UntilPieceIsNull(IEnumerable<Square> directionalSquares)
        {
            foreach (var square in directionalSquares)
            {
                yield return square;

                if (square.Piece != null)
                    break;
            }
        }

        /// <summary>
        /// Iterates over an array of squares and generates moves for a sliding piece (bishop, rook or queen).
        /// </summary>
        /// <param name="directionalSquares">A list of squares returned by a directional square function.</param>
        protected IEnumerable<Move> SquaresToSlidingPieceMoves(IEnumerable<Square> directionalSquares)
        {
            foreach(var square in directionalSquares)
            {
                if (square.Piece != null)
                {
                    if (square.Piece.OppositeOwner == Owner)
                        yield return new Move(Square, square, this, MoveFlags.Capture);

                    break;
                }

                yield return new Move(Square, square, this);
            }
        }

        internal static Piece FromFENChar(char value, Square square)
        {
            switch (value)
            {
                case 'P':
                    return new Pawn(Player.White, square);
                case 'N':
                    return new Knight(Player.White, square);
                case 'B':
                    return new Bishop(Player.White, square);
                case 'R':
                    return new Rook(Player.White, square);
                case 'Q':
                    return new Queen(Player.White, square);
                case 'K':
                    return new King(Player.White, square);
                case 'p':
                    return new Pawn(Player.Black, square);
                case 'n':
                    return new Knight(Player.Black, square);
                case 'b':
                    return new Bishop(Player.Black, square);
                case 'r':
                    return new Rook(Player.Black, square);
                case 'q':
                    return new Queen(Player.Black, square);
                case 'k':
                    return new King(Player.Black, square);
                default:
                    throw new ArgumentException($"Invalid FEN character {value}.");
            }
        }

        /// <summary>
        /// Whether this piece has been captured.
        /// </summary>
        public bool Captured { get; internal set; }

        /// <summary>
        /// The <see cref="ChessSharp.Square"/> this piece resides on.
        /// </summary>
        public Square Square { get; internal set; }
        
        /// <summary>
        /// The owner of this piece.
        /// </summary>
        public Player Owner { get; protected set; }

        /// <summary>
        /// The opponent to this piece's owner.
        /// </summary>
        public Player OppositeOwner => Owner == Player.White ? Player.Black : Player.White;

        /// <summary>
        /// The value of the piece in pawns.
        /// </summary>
        public abstract int PieceValue { get; }

        /// <summary>
        /// The piece's Forsyth-Edwards Notation symbol.
        /// </summary>
        public virtual char FENSymbol => Owner == Player.White ? GetType().Name[0] : GetType().Name.ToLower()[0];
        
        internal Direction PinDirection { get; }
        
        internal abstract List<Square> AttackingSquares();

        /// <summary>
        /// Generate a list of moves this piece can make.
        /// </summary>
        public abstract List<Move> GetLegalMoves();
        
        /// <summary>
        /// Returns a string representation of this piece.
        /// </summary>
        public override string ToString()
        {
            string str = (Owner == Player.White ? "White " : "Black ") + GetType().Name;
            return Captured ? "Captured " + str : str + " on " + Square;
        }

        public Piece(Player owner, Square square)
        {
            Owner = owner;
            Square = square;
        }
    }
}
