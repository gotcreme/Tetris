using System;
using Tetris.GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tetris.GameEngine.Test
{
    [TestClass]
    public class PieceTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            Piece piece = new Piece(new int[,] { { 1, 1, 1, 1 } });
            Assert.IsNotNull(piece.ToArray());
            Assert.AreEqual(0, piece.InitPosX);
            Assert.AreEqual(-1, piece.InitPosY);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestConstructor_Wrong_Parameter()
        {
            int[,] p = null;
            Piece target = new Piece(p);
        }

        [TestMethod]
        public void TestRotateRight()
        {
            Piece piece = new Piece(new int[,] { { 1, 1, 1, 1 } });
            Piece actual = piece.RotateRight();
            int[,] expected = new int[,] { { 1 }, { 1 }, { 1 }, { 1 } };
            CollectionAssert.AreEqual(expected, actual.ToArray());
        }

        [TestMethod]
        public void TestMakeItShadow()
        {
            Piece actual = new Piece(new int[,] { { 1, 1, 1, 1 } });
            actual.MakeItShadow();
            int[,] expected = new int[,] { { 8, 8, 8, 8 } };
            CollectionAssert.AreEqual(expected, actual.ToArray());
        }

        [TestMethod]
        public void TestToAray()
        {
            Piece actual = new Piece(new int[,] { { 1, 1, 1, 1 } }); ;
            int[,] expected = new int[,] { { 1, 1, 1, 1 } };
            CollectionAssert.AreEqual(expected, actual.ToArray());
        }

        [TestMethod]
        public void TestInitPosX()
        {
            Piece target = new Piece(new int[,] { { 1, 1, 1, 1 } }); 
            int actual = target.InitPosX;
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestHeight()
        {
            Piece target = new Piece(new int[,] { { 1, 1, 1, 1 } }); 
            int actual = target.Height;
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestInitPosY()
        {
            Piece target = new Piece(new int[,] { { 1, 1, 1, 1 } });
            int actual = target.InitPosY;
            int expected = -1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestWidth()
        {
            Piece target = new Piece(new int[,] { { 1, 1, 1, 1 } }); 
            int actual = target.Width;
            int expected = 4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestGetItem()
        {
            Piece target = new Piece(new int[,] { { 1, 1, 1, 1 } });
            int actual = target[0, 0];
            int expected = 1;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestGetItem_Wrong()
        {
            Piece target = new Piece(new int[,] { { 1, 1, 1, 1 } });
            int actual = target[8, 0];
        }

        [TestMethod]
        public void TestClone()
        {
            Piece piece = new Piece(new int[,] { { 1, 1, 1, 1 } });
            Piece cloned_piece = (Piece)piece.Clone();
            Assert.AreNotSame(cloned_piece, piece);
            CollectionAssert.AreEqual(cloned_piece.ToArray(), piece.ToArray());
        }
    }
}
