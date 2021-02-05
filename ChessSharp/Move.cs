using System;
using ChessSharp;

namespace ChessSharp
{
    /// <summary>
    /// A chess move.
    /// </summary>
    public class Move : IEquatable<Move>
    {
        /// <summary>
        /// The square the piece moved from.
        /// </summary>
        public readonly Square FromSquare;

        /// <summary>
        /// The square the piece moved to.
        /// </summary>
        public readonly Square ToSquare;

        /// <summary>
        /// The piece that moved.
        /// </summary>
        public readonly Piece PieceMoved;

        /// <summary>
        /// The type of piece this pawn promoted to, if any.
        /// </summary>
        public readonly Type PromotedTo;

        /// <summary>
        /// Special characteristics about this move.
        /// </summary>
        public readonly MoveFlags MoveFlags;

        /// <summary>
        /// Initializes a new chess move.
        /// </summary>
        /// <param name="from">The square the piece moved from.</param>
        /// <param name="to">The square the piece moved to.</param>
        /// <param name="piece">The piece that moved.</param>
        /// <param name="flags">Special characteristics about this move.</param>
        internal Move(Square from, Square to, Piece piece, MoveFlags flags = MoveFlags.None)
        {
            FromSquare = from;
            ToSquare = to;
            PieceMoved = piece;
            MoveFlags = flags;
        }

        internal Move(Square from, Square to, Piece piece, MoveFlags flags, Type promotion) : this(from, to, piece, flags)
        {
            if (promotion.BaseType != typeof(Piece) || promotion == typeof(Pieces.Pawn) || promotion == typeof(Pieces.King))
                throw new ArgumentException($"Invalid promotion {promotion}.");
            PromotedTo = promotion;
        }

        public bool Equals(Move other)
        {
            if (this is null)
                return other is null;
            else if (other is null)
                return this is null;

            return FromSquare.Equals(other.FromSquare) &&
                ToSquare.Equals(other.ToSquare) &&
                MoveFlags.Equals(other.MoveFlags);
        }
    }
}