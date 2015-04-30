﻿using System;
using Tetris.GameEngine.Interfaces;

namespace Tetris.GameEngine
{
    public class Game: IMovable, IMode
    {
        // Review VV: рекомендую замінити "static readonly" на "const"
        private static readonly int _board_width = 10;
        private static readonly int _board_height = 20;

        public enum GameStatus
        {
            ReadyToStart,
            InProgress,
            Paused,
            Finished
        }

        #region Private Fields

        /// <summary>
        /// The Playfield
        /// </summary>
        // Review VV: невірне іменування: слід замінити на _gameBoard
        private Board _game_board;
        private GameStatus _status;
        private Piece _currPiece;
        private Piece _nextPiece;
        private Random _rnd;
        private int _posX;
        private int _posY;
        private int _lines;
        private int _score;

        #endregion

        #region Constructors

        public Game()
        {
            _game_board = new Board(_board_width, _board_height);
            
            _currPiece = null;
            _nextPiece = null;
            _status = GameStatus.ReadyToStart;
            ShadowPieceMode = true;
            NextPieceMode = true;
            _rnd = new Random();
            _posX = _posY = 0;
            _lines = 0;
            _score = 0;
        }

        #endregion

        #region Public Methods

        public void Start()
        {
            if (this._status != GameStatus.ReadyToStart)
            {
                throw new InvalidOperationException("Only game with status 'ReadyToStart' can be started");
            }
            this._status = GameStatus.InProgress;
            DropNewPiece();
        }

        public void Pause()
        {
            /*
             * Review VV: чи можна викликати цей метод, якщо гра знаходиться у статусах ReadyToStart чи Finished?
             */
            if (this._status == GameStatus.InProgress)
            {
                this._status = GameStatus.Paused;
            }
            else 
            {
                this._status = GameStatus.InProgress;
            }
        }

        public void GameOver()
        {
            if ( (this._status != GameStatus.InProgress) && (this._status != GameStatus.Paused) )
            {
                throw new InvalidOperationException("Only game with status 'InProgress' or 'Pause'  can be finished");
            }
            _status = GameStatus.Finished;
        }

        #endregion

        #region Public Properties

        public int PosX
        {
            get 
            {
                return this._posX;
            }
        }

        public int PosY
        {
            get
            {
                return this._posY;
            }
        }

        /*
         * Reivew VV: What does this method do?
         * Is it correct to use Clone()?
         * Is there more optimal approach?
         */
        public Board ActualBoard
        {
            get
            {
                if (this.Status == GameStatus.ReadyToStart)
                {
                    return this._game_board;
                }
                Board tmp_board = (Board)_game_board.Clone();
                Piece tmp_piece = (Piece)_currPiece.Clone();
                
                if (ShadowPieceMode == true)
                {
                    Piece shadow_piece = (Piece)_currPiece.Clone();
                    tmp_board.FixShadowPiece(shadow_piece, _posX, _posY);
                }
                tmp_board.FixPiece(tmp_piece, _posX, _posY);
                return tmp_board;
            }
        }

        public Piece NextPiece
        {
            get 
            { 
                return _nextPiece; 
            }
        }

        public Piece CurrPiece
        {
            get
            {
                return _currPiece;
            }
        }

        public GameStatus Status
        {
            get 
            {
                return this._status; 
            }
        }

        public int Lines
        {
            get 
            { 
                return _lines; 
            }
        }

        public int Score
        {
            get 
            { 
                return _score; 
            }
        }

        #endregion

        #region Private Methods

        private void Step()
        {
            if (this.Status == GameStatus.InProgress)
            {
                if (_game_board.CanPosAt(_currPiece, _posX, _posY + 1))
                {
                    _posY++;
                }
                else
                {
                    _game_board.FixPiece(_currPiece, _posX, _posY);
                    int tmp_lines_made = _game_board.CheckLines();
                    _lines += tmp_lines_made;
                    _score += 40 * tmp_lines_made;

                    if (_game_board.IsTopReached())
                    {
                        GameOver();
                    }
                    else
                    {
                        DropNewPiece();
                    }
                }
            }
        }

        private void DropNewPiece()
        {
            _rnd = new Random(DateTime.Now.Millisecond);
            _currPiece = _nextPiece != null ? _nextPiece : PieceFactory.GetRandomPiece(_rnd);
            _posY = _currPiece.InitPosY;
            _posX = ( _game_board.Width - 1 ) / 2 + _currPiece.InitPosX;
            _nextPiece = PieceFactory.GetRandomPiece(_rnd);
        }

        #endregion

        #region IMovable Implementation

        public void MoveRight()
        {
            if (_game_board.CanPosAt(_currPiece, _posX + 1, _posY))
            {
                _posX++;
            }
        }

        public void MoveLeft()
        {
            if (_game_board.CanPosAt(_currPiece, _posX - 1, _posY))
            {
                _posX--;
            }
        }

        public void MoveDown()
        {
            Step();
        }

        public void SmashDown()
        {
            while (_game_board.CanPosAt(_currPiece, _posX, _posY + 1))
            {
                Step();
            }
            MoveDown();
        }

        public void Rotate()
        {
            Piece tmp_piece = _currPiece.RotateRight();
            if (_game_board.CanPosAt(tmp_piece, _posX, _posY))
            {
                _currPiece = tmp_piece;
            }
        }

        #endregion

        #region IMode Implementation

        /*
         * Review VV: what is the purpose of it?
         */
        public bool NextPieceMode
        {
            get; set;
        }

        /*
         * Review VV: what is the purpose of it?
         */
        public bool ShadowPieceMode
        {
            get; set;
        }

        #endregion
    }
}
