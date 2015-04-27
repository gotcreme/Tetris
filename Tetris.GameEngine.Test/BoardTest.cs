using System;
using Tetris.GameEngine;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tetris.GameEngine.Test
{
    [TestClass]
    public class BoardTest
    {
        [TestMethod]
        public void TestConstructor()
        {
            Board board = new Board(10, 20);
            Assert.IsNotNull(board.ToArray());
            Assert.AreEqual(10, board.Width);
            Assert.AreEqual(20, board.Height);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestConstructor_Wrong_Size()
        {
            Board board = new Board(5, 30);
        }

        [TestMethod]
        public void TestFixPiece()
        {
            Board board = new Board(10, 20);
            Piece piece = new Piece(new int[,] { { 1, 1, 1, 1 } });
            board.FixPiece(piece, 3, 0);
            for(int i = 3; i < 3 + piece.Width; ++i)
            {
                Assert.AreEqual(1, board[0, i]);
            }
            for (int i = 0; i < board.Height; ++i)
            {
                for (int j = 0; j < board.Width; ++j)
                {
                    if (i == 0 && j >= 3 && j < 3 + piece.Width)
                    {
                        continue;
                    }
                    Assert.AreEqual(0, board[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestFixPiece_Init_Pos_Fix()
        {
            Board board = new Board(10, 20);
            Piece piece = PieceFactory.GetPiecebyId(1);
            board.FixPiece(piece, 3, -1);
            for (int i = 3; i < 3 + piece.Width; ++i)
            {
                Assert.AreEqual(2, board[0, i]);
            }
            for (int i = 0; i < board.Height; ++i)
            {
                for (int j = 0; j < board.Width; ++j)
                {
                    if (i == 0 && j >= 3 && j < 3 + piece.Width)
                    {
                        continue;
                    }
                    Assert.AreEqual(0, board[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestFixPiece_Wrong_X_Pos()
        {
            Board board = new Board(10, 20);
            Piece piece = PieceFactory.GetPiecebyId(1);
            board.FixPiece(piece, -3, -1);
            for (int i = 0; i < board.Height; ++i)
            {
                for (int j = 0; j < board.Width; ++j)
                {
                    Assert.AreEqual(0, board[i, j]);
                }
            }
        }

        [TestMethod]
        public void TestCheckLines()
        {
            Board board = new Board(10, 20);
            Piece p1 = PieceFactory.GetPiecebyId(0);
            Piece p2 = PieceFactory.GetPiecebyId(1);
            board.FixPiece(p1, 0, 0);
            board.FixPiece(p1, 4, 0);
            board.FixPiece(p2, 8, 0);
            board.FixPiece(p1, 0, 1);
            board.FixPiece(p1, 4, 1);
            board.FixPiece(p2, 8, 1);
            Assert.AreEqual(2, board.CheckLines());
        }

        [TestMethod]
        public void TestCanPosAt()
        {
            Board board = new Board(10, 20);
            Piece p1 = PieceFactory.GetPiecebyId(0);
            Assert.IsTrue(board.CanPosAt(p1, 0, 0));
        }

        [TestMethod]
        public void TestCanPosAt_Wrong_Pos()
        {
            Board board = new Board(10, 20);
            Piece p1 = PieceFactory.GetPiecebyId(0);
            board.FixPiece(p1, 0, 0);
            Assert.IsFalse(board.CanPosAt(p1, 0, 0));
        }

        [TestMethod]
        public void TestCanPosAt_Init_Piece_Pos()
        {
            Board board = new Board(10, 20);
            Piece p1 = PieceFactory.GetPiecebyId(1);
            Assert.IsTrue(board.CanPosAt(p1, 0, -1));
        }

        [TestMethod]
        public void TestCanPosAt_Wrong_X_Pos()
        {
            Board board = new Board(10, 20);
            Piece p1 = PieceFactory.GetPiecebyId(1);
            Assert.IsFalse(board.CanPosAt(p1, -1, -1));
        }

        [TestMethod]
        public void TestIsTopReached()
        {
            Board board = new Board(10, 20);
            Piece p1 = PieceFactory.GetPiecebyId(0);
            Piece p2 = PieceFactory.GetPiecebyId(1);
            board.FixPiece(p1, 0, 0);
            board.FixPiece(p1, 4, 0);
            board.FixPiece(p2, 8, 0);
            Assert.IsTrue(board.IsTopReached());
        }

        [TestMethod]
        public void TestIsTopReached_Not_Reached()
        {
            Board board = new Board(10, 20);
            Piece p1 = PieceFactory.GetPiecebyId(0);
            Piece p2 = PieceFactory.GetPiecebyId(1);
            board.FixPiece(p1, 0, 1);
            board.FixPiece(p1, 4, 2);
            board.FixPiece(p2, 8, 3);
            Assert.IsFalse(board.IsTopReached());
        }

        [TestMethod]
        public void TestToArray()
        {
            Board board = new Board(10, 20);
            int[,] board_arr = board.ToArray();
            Assert.IsNotNull(board_arr);
            Assert.AreEqual(20, board_arr.GetUpperBound(0) + 1);
            Assert.AreEqual(10, board_arr.GetUpperBound(1) + 1);
        }

        [TestMethod]
        public void TestFixShadowPiece()
        {
            Board board = new Board(10, 20);
            Piece piece = new Piece(new int[,] { { 1, 1, 1, 1 } });
            board.FixShadowPiece(piece, 3, 0);

            for (int i = 3; i < 3 + piece.Width; ++i)
            {
                Assert.AreEqual(8, board[19, i]);
            }
        }

        [TestMethod]
        public void TestGetHeightProp()
        {
            Board board = new Board(10, 20);
            Assert.AreEqual(20, board.Height);
        }

        [TestMethod]
        public void TestGetWidthtProp()
        {
            Board board = new Board(10, 20);
            Assert.AreEqual(10, board.Width);
        }

        [TestMethod]
        public void TestGetItem()
        {
            Board board = new Board(10, 20);
            Assert.AreEqual(0, board[9, 9]);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestGetItem_Wrong_Index_0()
        {
            Board board = new Board(10, 20);
            int try_get_val = board[10, 15];
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void TestGetItem_Wrong_Index_1()
        {
            Board board = new Board(10, 20);
            int try_get_val = board[-2, 44];
        }

        [TestMethod]
        public void TestClone()
        {
            Board board = new Board(10, 20);
            Board cloned_board = (Board)board.Clone();
            Assert.AreNotSame(cloned_board.ToArray(), board.ToArray());
            CollectionAssert.AreEqual(cloned_board.ToArray(), board.ToArray());
        }
    }
}
