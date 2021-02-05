using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp.Pieces
{
    class Bishop : Piece
    {
        public override int PieceValue => 3;

        public override List<Move> GetLegalMoves()
        {
            var moves = new List<Move>();

            // If this bishop is pinned north, south, east or west
            if ((PinDirection & (Direction.North | Direction.South | Direction.West | Direction.East)) != 0)
            {
                // It cannot move, so return an empty list
                return moves;
            }

            // If this bishop is not pinned southeast or northwest
            if ((PinDirection & (Direction.Southeast | Direction.Northwest)) == 0)
            {
                // It can move southwest and northeast.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.SouthwestSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.NortheastSquares));
            }

            // If this bishop is not pinned southwest or northeast
            if ((PinDirection & (Direction.Southwest | Direction.Northeast)) == 0)
            {
                // It can move southeast and northwest.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.SouthwestSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.NorthwestSquares));
            }

            return moves;
        }

        internal override List<Square> AttackingSquares()
        {
            var squares = new List<Square>();

            squares.AddRange(UntilPieceIsNull(Square.NorthwestSquares));
            squares.AddRange(UntilPieceIsNull(Square.NortheastSquares));
            squares.AddRange(UntilPieceIsNull(Square.SouthwestSquares));
            squares.AddRange(UntilPieceIsNull(Square.SoutheastSquares));

            return squares;
        }

        internal Bishop(Player player, Square square) : base(player, square) { }
    }
}
