using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp.Pieces
{
    class Queen : Piece
    {
        public override int PieceValue => 9;

        public override List<Move> GetLegalMoves()
        {
            var moves = new List<Move>();

            // If this queen is not pinned vertically or diagonally
            if ((PinDirection & (Direction.North | Direction.South | Direction.Northeast | Direction.Northwest | Direction.Southeast | Direction.Southwest)) == 0)
            {
                // It can move east and west.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.WestSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.EastSquares));
            }

            // If this queen is not pinned horizontally or diagonally
            if ((PinDirection & (Direction.West | Direction.East | Direction.Northeast | Direction.Northwest | Direction.Southeast | Direction.Southwest)) == 0)
            {
                // It can move north and south.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.NorthSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.SouthSquares));
            }

            // If this queen is not pinned southeast or northwest or any axis
            if ((PinDirection & (Direction.Southeast | Direction.Northwest | Direction.North | Direction.South | Direction.East | Direction.West)) == 0)
            {
                // It can move northeast and southwest.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.NortheastSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.SouthwestSquares));
            }

            // If this queen is not pinned southwest or northeast or any axis
            if ((PinDirection & (Direction.Southwest | Direction.Northeast | Direction.North | Direction.South | Direction.East | Direction.West)) == 0)
            {
                // It can move northwest and southeast.
                moves.AddRange(SquaresToSlidingPieceMoves(Square.NorthwestSquares));
                moves.AddRange(SquaresToSlidingPieceMoves(Square.SoutheastSquares));
            }

            return moves;
        }

        internal override List<Square> AttackingSquares()
        {
            var squares = new List<Square>();
            
            squares.AddRange(UntilPieceIsNull(Square.NorthSquares));
            squares.AddRange(UntilPieceIsNull(Square.EastSquares));
            squares.AddRange(UntilPieceIsNull(Square.SouthSquares));
            squares.AddRange(UntilPieceIsNull(Square.WestSquares));
            squares.AddRange(UntilPieceIsNull(Square.NorthwestSquares));
            squares.AddRange(UntilPieceIsNull(Square.NortheastSquares));
            squares.AddRange(UntilPieceIsNull(Square.SouthwestSquares));
            squares.AddRange(UntilPieceIsNull(Square.SoutheastSquares));

            return squares;
        }

        internal Queen(Player player, Square square) : base(player, square) { }
    }
}
