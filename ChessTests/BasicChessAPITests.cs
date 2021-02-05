using System;
using ChessSharp;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace ChessTests
{
    [TestClass]
    public class BasicChessAPITests
    {
        ChessGame game;

        [TestInitialize]
        public void SetUp()
        {
            game = new ChessGame();
        }

        [TestMethod]
        public void AllValidBoardPositions()
        {
            for (char file = 'a'; file <= 'h'; file++)
            {
                for (char rank = '1'; rank < '8'; rank++)
                {
                    string pos = file.ToString() + rank.ToString();
                    Assert.IsNotNull(game[pos], $"Error trying to get position {pos}.");
                }
            }
        }

        [TestMethod]
        public void InvalidBoardPositions()
        {
            for (char file = 'i'; file < 'z'; file++)
            {
                for (char rank = '0'; rank < '9'; rank++)
                {
                    string pos = file.ToString() + rank.ToString();
                    Assert.ThrowsException<ArgumentException>(() => game[pos], $"game[{pos}] did not throw an ArgumentException.");
                }
            }
        }
        
    }
}
