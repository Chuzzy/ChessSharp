using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp.Pieces
{
    public class Knight : Piece
    {
        public override int PieceValue => 3;

        public char FENChar => Owner == Player.White ? 'N' : 'n';

        public override List<Move> GetLegalMoves()
        {
            var moves = new List<Move>();

            // A pinned knight cannot move.
            if (PinDirection != Direction.None)
                return moves;

            (int, int)[] knightOffsets =
            {
                (1, 2),
                (2, 1),
                (2, -1),
                (1, -2),
                (-1, -2),
                (-2, -1),
                (-2, 1),
                (-1, 2)
            };
            
            foreach (var offset in knightOffsets)
            {
                try
                {
                    Square square = Square.Game[offset.Item1, offset.Item2];
                    moves.Add(new Move(Square, square, this, square.Piece is null ? MoveFlags.Capture : MoveFlags.None));
                }
                catch (IndexOutOfRangeException) { }
            }

            return moves;
        }

        internal override List<Square> AttackingSquares()
        {
            var squares = new List<Square>();
            (int, int)[] knightOffsets =
            {
                (1, 2),
                (2, 1),
                (2, -1),
                (1, -2),
                (-1, -2),
                (-2, -1),
                (-2, 1),
                (-1, 2)
            };

            foreach (var offset in knightOffsets)
            {
                try
                {
                    Square square = Square.Game[offset.Item1, offset.Item2];
                    squares.Add(square);
                }
                catch (IndexOutOfRangeException) { }
            }

            return squares;
        }

        internal Knight(Player owner, Square square) : base(owner, square) { }
    }
}
