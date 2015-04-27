using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tetris.GameEngine.Test
{
    [TestClass]
    public class GameTest
    {
        #region LifeCycle
        [TestMethod]
        public void TestUsualLifecycle()
        {
            Game game = new Game();
            Assert.AreEqual(Game.GameStatus.ReadyToStart, game.Status);
            game.Start();
            Assert.AreEqual(Game.GameStatus.InProgress, game.Status);
            game.Pause();
            Assert.AreEqual(Game.GameStatus.Paused, game.Status);
            game.GameOver();
            Assert.AreEqual(Game.GameStatus.Finished, game.Status);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestStart_Wrong_Status_0()
        {
            Game game = new Game();
            Assert.AreEqual(Game.GameStatus.ReadyToStart, game.Status);
            game.Start();
            game.Start();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestStart_Wrong_Status_1()
        {
            Game game = new Game();
            Assert.AreEqual(Game.GameStatus.ReadyToStart, game.Status);
            game.GameOver();
            game.GameOver();
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestStart_Wrong_Status_2()
        {
            Game game = new Game();
            game.GameOver();
        }

        [TestMethod]
        public void TestPause()
        {
            Game game = new Game();
            game.Start();
            game.Pause();
            Assert.AreEqual(Game.GameStatus.Paused, game.Status);
            game.Pause();
            Assert.AreEqual(Game.GameStatus.InProgress, game.Status);
        }

        #endregion

        [TestMethod]
        public void TestBoardCreation()
        {
            Game game = new Game();
            Assert.IsNotNull( game.ActualBoard );
        }

        [TestMethod]
        public void TestBoardSize()
        {
            Game game = new Game();
            Assert.AreEqual(10, game.ActualBoard.Width);
            Assert.AreEqual(20, game.ActualBoard.Height);
        }

        [TestMethod]
        public void TestGetActualBoard()
        {
            Game game = new Game();
            Assert.IsNotNull(game.ActualBoard);
        }

        [TestMethod]
        public void TestGetNextPieceProp()
        {
            Game game = new Game();
            game.Start();
            Assert.IsNotNull(game.NextPiece);
        }

        [TestMethod]
        public void TestGetLinesProp()
        {
            Game game = new Game();
            game.Start();
            Assert.AreEqual(0, game.Lines);
        }

        [TestMethod]
        public void TestGetScoreProp()
        {
            Game game = new Game();
            game.Start();
            Assert.AreEqual(0, game.Score);
        }

        [TestMethod]
        public void TestNextPieceModeProp()
        {
            Game game = new Game();
            Assert.IsTrue(game.NextPieceMode);
            game.NextPieceMode = false;
            Assert.IsFalse(game.NextPieceMode);
        }

        [TestMethod]
        public void TestShadowPieceModeProp()
        {
            Game game = new Game();
            Assert.IsTrue(game.ShadowPieceMode);
            game.ShadowPieceMode = false;
            Assert.IsFalse(game.ShadowPieceMode);
        }

        [TestMethod]
        public void TestMoveDown()
        {
            Game game = new Game();
            game.Start();
            int expected_pos = game.PosY + 1;
            game.MoveDown();
            Assert.AreEqual(expected_pos, game.PosY);
        }

        [TestMethod]
        public void TestMoveLeft()
        {
            Game game = new Game();
            game.Start();
            game.MoveDown();
            int expected_pos = game.PosX - 1;
            game.MoveLeft();
            Assert.AreEqual(expected_pos, game.PosX);
        }

        [TestMethod]
        public void TestMoveRight()
        {
            Game game = new Game();
            game.Start();
            game.MoveDown();
            int expected_pos = game.PosX + 1;
            game.MoveRight();
            Assert.AreEqual(expected_pos, game.PosX);
        }

        [TestMethod]
        public void TestSmashDown()
        {
            Game game = new Game();
            game.Start();
            int pos_y = game.ActualBoard.Height + game.CurrPiece.InitPosY;
            int pos_x = game.PosX;
            Assert.IsFalse(game.ActualBoard.CanPosAt(game.CurrPiece, pos_x, pos_y));
        }

        [TestMethod]
        public void TestRotate()
        {
            Game game = new Game();
            game.Start();
            Piece expected = game.CurrPiece.RotateRight();
            game.Rotate();
            CollectionAssert.AreEqual(expected.ToArray(), game.CurrPiece.ToArray());
        }

        [TestMethod]
        public void TestLinesUpdate()
        {
            Game game = new Game();
            game.Start();
            game.SmashDown();
            Assert.AreEqual(0, game.Lines);
        }

        [TestMethod]
        public void TestMoveDown_Top_Is_Reached()
        {
            Game game = new Game();
            game.Start();
            for (int i = 0; i < game.ActualBoard.Height; ++i)
            {
                game.SmashDown();
            }
            Assert.IsTrue(game.ActualBoard.IsTopReached());
        }
    }
}
