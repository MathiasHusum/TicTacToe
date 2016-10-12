using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Services
{
    public interface IGameWinnerService
    {
        char Validate(char[,] gameBoard);
    }

    public class GameWinnerService : IGameWinnerService
    {
        private const char SymbolForNoWinner = ' ';

        public char Validate(char[,] gameBoard)
        {
            var currentWinningSymbol = CheckForThreeInARowInHorizontalRow(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
                return currentWinningSymbol;
            currentWinningSymbol = CheckForThreeInARowInVerticalColumn(gameBoard);
            if (currentWinningSymbol != SymbolForNoWinner)
                return currentWinningSymbol;
            currentWinningSymbol = CheckForThreeInARowDiagonally(gameBoard);
            return currentWinningSymbol;
        }

        private static char CheckForThreeInARowInVerticalColumn(char[,] gameBoard)
        {
            if (gameBoard[0, 0] == 'X' && gameBoard[1, 0] == 'X' && gameBoard[2, 0] == 'X')
            {
                return 'X';
            }
            else if(gameBoard[0, 0] == 'O' && gameBoard[1, 0] == 'O' && gameBoard[2, 0]== 'O')
            {
                return 'O';
            }
            if (gameBoard[0, 1] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 1] == 'X')
            {
                return 'X';
            }
            else if (gameBoard[0, 1] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 1] == 'O')
            {
                return 'O';
            }
            if (gameBoard[0, 2] == 'X' && gameBoard[1, 2] == 'X' && gameBoard[2, 2] == 'X')
            {
                return 'X';
            }
            else if (gameBoard[0, 2] == 'O' && gameBoard[1, 2] == 'O' && gameBoard[2, 2] == 'O')
            {
                return 'O';
            }
            
            
            return SymbolForNoWinner;
            




            //var rowOneChar = gameBoard[0, 0];
            //var rowTwoChar = gameBoard[1, 0];
            //var rowThreeChar = gameBoard[2, 0];
            //if (rowOneChar == rowTwoChar &&
            //    rowTwoChar == rowThreeChar)
            //{
            //    return rowOneChar;
            //}
            //return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowInHorizontalRow(char[,] gameBoard)
        {
            if (gameBoard[0, 0] == 'X' && gameBoard[0, 1] == 'X' && gameBoard[0, 2] == 'X')
            {
                return 'X';
            }
            else if (gameBoard[0, 0] == 'O' && gameBoard[0, 1] == 'O' && gameBoard[0, 2] == 'O')
            {
                return 'O';
            }
            if (gameBoard[1, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[1, 2] == 'X')
            {
                return 'X';
            }
            else if (gameBoard[1, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[1, 2] == 'O')
            {
                return 'O';
            }
            if (gameBoard[2, 0] == 'X' && gameBoard[2, 1] == 'X' && gameBoard[2, 2] == 'X')
            {
                return 'X';
            }
            else if (gameBoard[2, 0] == 'O' && gameBoard[2, 1] == 'O' && gameBoard[2, 2] == 'O')
            {
                return 'O';
            }


            return SymbolForNoWinner;





            //var columnOneChar = gameBoard[0, 0];
            //var columnTwoChar = gameBoard[0, 1];
            //var columnThreeChar = gameBoard[0, 2];
            //if (columnOneChar == columnTwoChar && 
            //    columnTwoChar == columnThreeChar)
            //{
            //    return columnOneChar;
            //}
            //return SymbolForNoWinner;
        }

        private static char CheckForThreeInARowDiagonally(char[,] gameBoard)
        {

            if (gameBoard[0, 0] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 2] == 'X')
            {
                return 'X';
            }
            else if (gameBoard[0, 0] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 2] == 'O')
            {
                return 'O';
            }
            if (gameBoard[0, 2] == 'X' && gameBoard[1, 1] == 'X' && gameBoard[2, 0] == 'X')
            {
                return 'X';
            }
            else if (gameBoard[0, 2] == 'O' && gameBoard[1, 1] == 'O' && gameBoard[2, 0] == 'O')
            {
                return 'O';
            }

            return SymbolForNoWinner;


            //var cellOneChar = gameBoard[0, 0];
            //var cellTwoChar = gameBoard[1, 1];
            //var cellThreeChar = gameBoard[2, 2];
            //if (cellOneChar == cellTwoChar &&
            //    cellTwoChar == cellThreeChar)
            //{
            //    return cellOneChar;
            //}
            //return SymbolForNoWinner;
        }
    }
}
