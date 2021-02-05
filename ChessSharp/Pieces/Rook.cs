using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp.Pieces
{
    internal class Rook : Piece
    {
        public override int PieceValue => 5;

        public override List<Move> GetLegalMoves()
        {
            var moves = new List<Move>();

            // If this rook is pinned diagonally
            if ((PinDirection & (Direction.Northwest | Direction.Northeast | Direction.Southeast | Direction.Southwest)) != 0)
            {
                // It cannot move, so return an empty list
                return moves;
            }

            // If this rook is not pinned vertically
            if ((PinDirection & (Direction.North | Direction.South)) == 0) {
                // It can move east and west.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.WestSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.EastSquares));
            }

            // If this rook is not pinned horizontally
            if ((PinDirection & (Direction.West | Direction.East)) == 0)
            {
                // It can move north and south.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.NorthSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.SouthSquares));
            }

            return moves;
        }

        internal override List<Square> AttackingSquares()
        {
            var squares = new List<Square>();

            // Iterates over an array of squares and stops as soon as a piece is reached.
            IEnumerable<Square> UntilPieceIsNull(IEnumerable<Square> directionalSquares)
            {
                foreach (var square in directionalSquares)
                {
                    yield return square;

                    if (square.Piece != null)
                        break;
                }
            }

            squares.AddRange(UntilPieceIsNull(Square.NorthSquares));
            squares.AddRange(UntilPieceIsNull(Square.EastSquares));
            squares.AddRange(UntilPieceIsNull(Square.SouthSquares));
            squares.AddRange(UntilPieceIsNull(Square.WestSquares));

            return squares;
        }

        internal Rook(Player owner, Square square) : base(owner, square) { }
    }
}
