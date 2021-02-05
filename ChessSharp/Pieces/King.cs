using System;
using System.Collections.Generic;

namespace ChessSharp.Pieces
{
    public class King : Piece
    {
        public override int PieceValue => int.MaxValue;

        public override List<Move> GetLegalMoves()
        {
            var moves = new List<Move>();

            (int, int)[] kingOffsets =
            {
                (0, 1),
                (1, 1),
                (1, 0),
                (1, -1),
                (0, -1),
                (-1, -1),
                (-1, 0),
                (-1, 1)
            };

            foreach (var offset in kingOffsets)
            {
                try
                {
                    Square square = Square.Game[offset.Item1, offset.Item2];

                    if (!square.AttackedBy.HasFlag(OppositeOwner))
                        moves.Add(new Move(Square, square, this, square.Piece is null ? MoveFlags.None : MoveFlags.Capture));
                }
                catch (IndexOutOfRangeException) { }
            }

            #region Castling rules
            if (!Square.Game.Check)
            {
                CastlingRights myCastlingRights = Owner == Player.White ? Square.Game.WhiteCastlingRights : Square.Game.BlackCastlingRights;

                if (myCastlingRights.HasFlag(CastlingRights.Kingside))
                {
                    // Check to see if it is possible to castle kingside
                    Square oneSquareEast = Square.Game[Square.File + 1, Square.Rank];
                    Square twoSquaresEast = Square.Game[Square.File + 2, Square.Rank];

                    if (!oneSquareEast.AttackedBy.HasFlag(OppositeOwner) &&
                        !twoSquaresEast.AttackedBy.HasFlag(OppositeOwner) &&
                        oneSquareEast.Piece is null && twoSquaresEast.Piece is null)
                    {
                        // It is possible to castle kingside.
                        moves.Add(new Move(Square, twoSquaresEast, this, MoveFlags.CastleKingside));
                    }
                }

                if (myCastlingRights.HasFlag(CastlingRights.Queenside))
                {
                    // Check to see if it is possible to castle queenside
                    Square oneSquareWest = Square.Game[Square.File - 1, Square.Rank];
                    Square twoSquaresWest = Square.Game[Square.File - 2, Square.Rank];

                    if (!oneSquareWest.AttackedBy.HasFlag(OppositeOwner) &&
                        !twoSquaresWest.AttackedBy.HasFlag(OppositeOwner) && 
                        oneSquareWest.Piece is null && twoSquaresWest.Piece is null)
                    {
                        // It is possible to castle queenside
                        moves.Add(new Move(Square, twoSquaresWest, this, MoveFlags.CastleQueenside));
                    }
                }
            }
            #endregion

            return moves;
        }

        internal override List<Square> AttackingSquares()
        {
            var squares = new List<Square>();

            (int, int)[] kingOffsets =
            {
                (0, 1),
                (1, 1),
                (1, 0),
                (1, -1),
                (0, -1),
                (-1, -1),
                (-1, 0),
                (-1, 1)
            };

            foreach (var offset in kingOffsets)
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

        internal King(Player owner, Square square) : base(owner, square) { }
    }
}