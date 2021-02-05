using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp
{
    [Flags]
    public enum MoveFlags
    {
        None = 0,
        /// <summary>
        /// A capture.
        /// </summary>
        Capture = 1,
        /// <summary>
        /// An en passant capture.
        /// </summary>
        EnPassantCapture = 2,
        /// <summary>
        /// A pawn moving one square forward.
        /// </summary>
        PawnMoveOneSquare = 4,
        /// <summary>
        /// A pawn moving two squares forward.
        /// </summary>
        PawnMoveTwoSquares = 8,
        /// <summary>
        /// A pawn promotion.
        /// </summary>
        Promotion = 16,
        /// <summary>
        /// Castling kingside.
        /// </summary>
        CastleKingside = 32,
        /// <summary>
        /// Castling queenside.
        /// </summary>
        CastleQueenside = 64
    }
}
