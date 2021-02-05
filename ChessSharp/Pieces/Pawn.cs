using System;
using System.Collections.Generic;

namespace ChessSharp.Pieces
{
    public class Pawn : Piece
    {
        public override int PieceValue => 1;

        private int NextRank => Owner == Player.White ? 1 : -1;

        public override List<Move> GetLegalMoves()
        {
            var moves = new List<Move>();

            // If this pawn is not pinned east, west or along any diagonal
            if ((PinDirection & (Direction.East | Direction.West | Direction.Northeast | Direction.Northwest | Direction.Southeast | Direction.Southwest)) == 0)
            {
                // If there is no piece infront of the pawn
                Square oneSquareForward = Square.Game[Square.File, Square.Rank + NextRank];
                if (oneSquareForward.Piece is null)
                {
                    moves.Add(new Move(Square, oneSquareForward, this, MoveFlags.PawnMoveOneSquare));

                    if (Square.RankIndex == 1 || Square.RankIndex == 7)
                    {
                        Square twoSquaresForward = Square.Game[Square.File, Square.Rank + (2 * NextRank)];

                        if (twoSquaresForward.Piece is null)
                        {
                            moves.Add(new Move(Square, twoSquaresForward, this, MoveFlags.PawnMoveTwoSquares));
                        }
                    }
                }
            }
            
            // Subroutine that checks if it is possible for a pawn
            // to capture a piece or perform en passant on this square
            // and adds it to the list of moves.
            void CheckIfCaptureIsPossible(Square square)
            {
                if (!(square.Piece is null))
                {
                    moves.Add(new Move(Square, square, this, MoveFlags.Capture));
                }
                else if (square == Square.Game.EnPassantSquare)
                {
                    moves.Add(new Move(Square, square, this, MoveFlags.EnPassantCapture));
                }
            }

            // If this pawn is not pinned along the southeast or northwest diagonal
            if ((PinDirection & (Direction.Southeast | Direction.Northwest)) == 0)
            {
                // This piece can move northeast/southwest.
                // If it is a white pawn
                if (Owner == Player.White)
                {
                    // Check that there is a piece to the northeast
                    // or that it is the en passant square.
                    Square northEastSquare = Square.Game[Square.FileIndex + 1, Square.RankIndex + 1];
                    CheckIfCaptureIsPossible(northEastSquare);
                }
                else
                {
                    // Check that there is a piece to the southwest
                    // or that it is the en passant square.
                    Square southWestSquare = Square.Game[Square.FileIndex - 1, Square.RankIndex - 1];
                    CheckIfCaptureIsPossible(southWestSquare);
                }
            }

            // If this pawn is not pinned along the southwest/northeast diagonal
            if ((PinDirection & (Direction.Southwest | Direction.Northeast)) == 0)
            {
                // It can move southeast/northwest.
                if (Owner == Player.White)
                {
                    // Check that there is a piece to the northwest
                    try
                    {
                        Square northWestSquare = Square.Game[Square.FileIndex - 1, Square.RankIndex + 1];
                        CheckIfCaptureIsPossible(northWestSquare);
                    }
                    catch (ArgumentException) { }
                }
                else
                {
                    // Check that there is a piece to the southeast
                    try
                    {
                        Square southEastSquare = Square.Game[Square.FileIndex + 1, Square.RankIndex - 1];
                        CheckIfCaptureIsPossible(southEastSquare);
                    }
                    catch (ArgumentException) { }
                }
            }

            return moves;
        }

        internal override List<Square> AttackingSquares()
        {
            var squares = new List<Square>();
            
            // If this pawn is not on the a-file
            if (Square.FileIndex != 0)
                squares.Add(Square.Game[Square.File - 1, Square.Rank + NextRank]);

            // If this pawn is not on the h-file
            if (Square.FileIndex != 7)
                squares.Add(Square.Game[Square.File + 1, Square.Rank + NextRank]);

            return squares;
        }

        internal Pawn(Player owner, Square square) : base(owner, square) { }
    }
}