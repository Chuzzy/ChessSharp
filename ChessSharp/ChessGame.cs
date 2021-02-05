using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChessSharp
{
    /// <summary>
    /// A chess game.
    /// </summary>
    public class ChessGame
    {
        private static Dictionary<string, char> StartingPosition => new Dictionary<string, char>()
            {
                {"a1", 'R'},
                {"b1", 'N'},
                {"c1", 'B'},
                {"d1", 'Q'},
                {"e1", 'K'},
                {"f1", 'B'},
                {"g1", 'N'},
                {"h1", 'R'},
                {"a2", 'P'},
                {"b2", 'P'},
                {"c2", 'P'},
                {"d2", 'P'},
                {"e2", 'P'},
                {"f2", 'P'},
                {"g2", 'P'},
                {"h2", 'P'},
                {"a7", 'p'},
                {"b7", 'p'},
                {"c7", 'p'},
                {"d7", 'p'},
                {"e7", 'p'},
                {"f7", 'p'},
                {"g7", 'p'},
                {"h7", 'p'},
                {"a8", 'r'},
                {"b8", 'n'},
                {"c8", 'b'},
                {"d8", 'q'},
                {"e8", 'k'},
                {"f8", 'b'},
                {"g8", 'n'},
                {"h8", 'r'}
            };

        private Square[,] board = new Square[8, 8];

        /// <summary>
        /// Returns the <see cref="Square"/> at the specified position.
        /// </summary>
        /// <param name="position">The position of the square.</param>
        public Square this[string position]
        {
            get
            {
                int file = "abcdefgh".IndexOf(position[0]);
                int rank = "12345678".IndexOf(position[1]);

                if (file == -1 || rank == -1)
                    throw new ArgumentException($"Invalid position {position}.");

                return board[file, rank];
            }
        }

        /// <summary>
        /// Returns the <see cref="Square"/> at the specified file and rank.
        /// </summary>
        /// <param name="file">The file of the square.</param>
        /// <param name="rank">The rank of the square.</param>
        public Square this[int file, int rank] => board[file, rank];

        /// <summary>
        /// The Forsyth-Edwards notation of the board.
        /// </summary>
        public string FEN
        {
            get
            {
                string fen = string.Empty;

                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        /// <summary>
        /// If a pawn just moved two squares forward, this is the square behind that pawn.
        /// </summary>
        internal Square EnPassantSquare { get; private set; }

        /// <summary>
        /// White's ability to castle.
        /// </summary>
        internal CastlingRights WhiteCastlingRights { get; private set; }

        /// <summary>
        /// Black's ability to castle.
        /// </summary>
        internal CastlingRights BlackCastlingRights { get; private set; }

        private void SetCastlingRights(CastlingRights rights)
        {
            if (SideToMove == Player.White)
                WhiteCastlingRights &= rights;
            else
                BlackCastlingRights &= rights;
        }

        /// <summary>
        /// A dictionary storing the positions that have occured in game, and how many times.
        /// </summary>
        internal Dictionary<string, int> PositionHistory { get; set; }

        private List<Piece> whitePieces;

        /// <summary>
        /// White's pieces that are currently alive on the board.
        /// </summary>
        public ReadOnlyCollection<Piece> WhitePieces => new ReadOnlyCollection<Piece>(whitePieces);

        private List<Piece> blackPieces;

        /// <summary>
        /// Black's pieces that are currently alive on the board.
        /// </summary>
        public ReadOnlyCollection<Piece> BlackPieces => new ReadOnlyCollection<Piece>(blackPieces);

        private List<Move> legalMoves;

        /// <summary>
        /// A list of legal moves the player can make.
        /// </summary>
        public ReadOnlyCollection<Move> LegalMoves => new ReadOnlyCollection<Move>(legalMoves);

        /// <summary>
        /// Updates the <see cref="legalMoves"/> list with legal moves.
        /// </summary>
        private void UpdateLegalMoves()
        {
            legalMoves.Clear();

            if (SideToMove == Player.White)
            {
                whitePieces.ForEach(piece => legalMoves.AddRange(piece.GetLegalMoves()));
            }
            else
            {
                blackPieces.ForEach(piece => legalMoves.AddRange(piece.GetLegalMoves()));
            }
        }

        /// <summary>
        /// The player to move.
        /// </summary>
        public Player SideToMove { get; private set; }

        /// <summary>
        /// Whether the player to move is in check.
        /// </summary>
        public bool Check { get; private set; }

        /// <summary>
        /// Whether the player to move is in checkmate.
        /// </summary>
        public bool Checkmate => Check && LegalMoves.Count == 0;

        /// <summary>
        /// Whether the player to move is in stalemate.
        /// </summary>
        public bool Stalemate => !Check && LegalMoves.Count == 0;

        /// <summary>
        /// Whether a draw can be claimed by threefold repitition.
        /// </summary>
        public bool ThreefoldRepitition => PositionHistory.Any((KeyValuePair<string, int> pair) => pair.Value > 2);

        /// <summary>
        /// The number of moves that have gone by without a capture or pawn movement.
        /// </summary>
        public int HalfmoveClock { get; private set; }

        /// <summary>
        /// Fill the chessboard with empty squares.
        /// </summary>
        private void SetUpBoard()
        {
            for (int rank = 0; rank < 8; rank++)
                for (int file = 0; file < 8; file++)
                    board[file, rank] = new Square(this, file, rank);

            for (int rank = 0; rank < 8; rank++)
                for (int file = 0; file < 8; file++)
                    board[file, rank].UpdateDirectionalSquares();
        }

        /// <summary>
        /// Initializes a new chess game with the starting position.
        /// </summary>
        public ChessGame() : this(StartingPosition) { }

        /// <summary>
        /// Initializes a new chess game using a dictionary.
        /// </summary>
        /// <param name="pieceDictionary">A dictionary mapping each square to a piece.</param>
        public ChessGame(Dictionary<string, char> pieceDictionary)
        {
            SetUpBoard();
            foreach (var entry in pieceDictionary)
            {
                int file = "abcdefgh".IndexOf(entry.Key[0]);
                int rank = "12345678".IndexOf(entry.Key[1]);

                if (file == -1 || rank == -1)
                    throw new ArgumentException($"Invalid position {entry.Key}.");

                board[file, rank].Piece = Piece.FromFENChar(entry.Value, board[file, rank]);
            }
        }

        /// <summary>
        /// Initializes a new chess game using either FEN or PGN.
        /// </summary>
        /// <param name="gameInfo">A string representing a board position in FEN
        /// or a chess game in PGN.</param>
        public ChessGame(string gameInfo)
        {
            if (Regex.IsMatch(gameInfo, @"^((?:(?:[KQRBNPkqrbnp1-8]){1,8}\/){7}[KQRBNPkqrbnp1-8]{1,8}) (w|b) ([KQkq]{1,4}|-) ([a-h][1-8]|-) (\d+) (\d+)$"))
            {
                // Forsyth-Edwards Notation
            }
            else if (Regex.IsMatch(gameInfo, "^\\[(\\w+) \"(.+)\"\\]$", RegexOptions.Multiline))
            {
                // Portable Game Notation
            }
            else
            {
                throw new ArgumentException("Expected FEN or PGN.", nameof(gameInfo));
            }
        }
    }
}
