using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessSharp
{
    /// <summary>
    /// A detailed chess move, including fields for SAN and FEN.
    /// </summary>
    public class DetailedMove : Move
    {
        /// <summary>
        /// The standard algebraic notation of the move.
        /// </summary>
        public readonly string SAN;

        /// <summary>
        /// The position of the board after the move had been made.
        /// </summary>
        public readonly string FEN;

        internal DetailedMove(Square from, Square to, Piece piece, MoveFlags flags, Type promotion, string san, string fen) : base(from, to, piece, flags, promotion)
        {
            SAN = san; FEN = fen;
        }
        
    }
}
