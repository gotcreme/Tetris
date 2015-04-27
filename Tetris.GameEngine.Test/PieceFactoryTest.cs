using System;
using Tetris.GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tetris.GameEngine.Test
{
    [TestClass]
    public class PieceFactoryTest
    {
        [TestMethod]
        public void TestInitialization()
        {
            PieceFactory.Initialize();
            Assert.AreEqual(7, PieceFactory.Count);
        }

        [TestMethod]
        public void TestGetPieceById()
        {
            PieceFactory.Initialize();
            Piece actual = PieceFactory.GetPiecebyId(0);
            Piece expected = new Piece(new int[,] { { 1, 1, 1, 1 } });
            CollectionAssert.AreEqual(expected.ToArray(), actual.ToArray());
        }

        [TestMethod]
        public void TestGetPieceById_WrongId()
        {
            PieceFactory.Initialize();
            Piece actual = PieceFactory.GetPiecebyId(9);
            Piece expected = null;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetRandomPiece()
        {
            Random r = new Random(DateTime.Now.Millisecond);
            PieceFactory.Initialize();
            Piece gen_piece = PieceFactory.GetRandomPiece(r);
            Assert.IsNotNull(gen_piece);
        }

        [TestMethod]
        public void TestGetCount()
        {
            PieceFactory.Initialize();
            Assert.AreEqual(7, PieceFactory.Count);
        }
    }
}
