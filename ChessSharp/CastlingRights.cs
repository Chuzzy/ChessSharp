using System;

namespace ChessSharp
{
    /// <summary>
    /// The right to castle.
    /// </summary>
    [Flags]
    public enum CastlingRights
    {
        /// <summary>
        /// No castling.
        /// </summary>
        None,
        /// <summary>
        /// Castling can only be done kingside.
        /// </summary>
        Kingside,
        /// <summary>
        /// Castling can only be done queenside.
        /// </summary>
        Queenside,
        /// <summary>
        /// Castling can be done kingside and queenside.
        /// </summary>
        Both
    }
}
