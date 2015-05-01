using System;
using System.Collections.Generic;

namespace Tetris.GameEngine
{
    /*
     * Review VV: 
     *      - виділення окремої фабрики для фігурок - правильне рішення
     *      
     *      Рекомендую скористатися принципом Dependency Inversion:
     *          - реалізувати фабрику як нестатичний клас
     *          - виділити для неї інтерфейс IPieceFactory
     *          - передавати екземпляр фабрики як параметр конструктора у Game
     *          - але список _pieces варто залишити статичним
     */
    public static class PieceFactory
    {
        #region Private Fields

        /// <summary>
        /// List of Tetris Pieces
        /// </summary>
        private static List<Piece> _pieces;

        #endregion

        #region Constructors

        /// <summary>
        /// Adds some basic Tetris Pieces to the list
        /// </summary>
        static PieceFactory()
        {
            Initialize();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Returns a specific Piece
        /// </summary>
        /// <param name="ID">ID of Piece (0-6)</param>
        /// <returns>the Piece (or null if invalid Value)</returns>
        /// 
        /*
            Review VV: ID повинно бути маленькими літерами - id
        */
        public static Piece GetPiecebyId(int ID)
        {
            if (_pieces.Count > ID && ID >= 0)
            {
                return _pieces[ID];
            }
            return null;
        }

        /// <summary>
        /// Returns a random Piece
        /// </summary>
        /// <returns>Random Piece</returns>
        public static Piece GetRandomPiece(Random r)
        {
            int ind = r.Next(_pieces.Count);
            return GetPiecebyId(ind);
        }

        #endregion

        #region Public Properties
        public static int Count
        {
            get 
            { 
                return _pieces.Count; 
            }
        }

        #endregion

        #region Helpers
        public static void Initialize()
        {
            _pieces = new List<Piece>();

            //####
            _pieces.Add(new Piece(new int[,] { { 1, 1, 1, 1 } }));

            //##
            //##
            _pieces.Add(new Piece(new int[,] { { 2, 2 }, { 2, 2 } }));

            //  #
            //###
            _pieces.Add(new Piece(new int[,] { { 0, 0, 3 }, { 3, 3, 3 } }));

            //#
            //###
            _pieces.Add(new Piece(new int[,] { { 4, 0, 0 }, { 4, 4, 4 } }));

            // ##
            //##
            _pieces.Add(new Piece(new int[,] { { 0, 5, 5 }, { 5, 5, 0 } }));

            //##
            // ##
            _pieces.Add(new Piece(new int[,] { { 6, 6, 0 }, { 0, 6, 6 } }));

            //###
            // #
            _pieces.Add(new Piece(new int[,] { { 7, 7, 7 }, { 0, 7, 0 } }));
        }

        #endregion
    }
}

