using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;
        private int[] _boardPositions = new int[9];
        private int _rounds;


        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10, 6);
            _boardRenderer.Render();
        }

        /* private  void PlayMoveX()
         {
             //ask user for row and column

             Console.SetCursorPosition(2, 19);

             Console.Write("Player X");


             Console.SetCursorPosition(2, 20);

             Console.Write("Please Enter Row: ");
             var row = Console.ReadLine();

             Console.SetCursorPosition(2, 22);


             Console.Write("Please Enter Column: ");
             var column = Console.ReadLine();

             //store move in the array
             int rowNumber = int.Parse(row);
             int columnNumber = int.Parse(column);
             int arrayPos = (rowNumber * 3) + columnNumber;

             _boardPositions[arrayPos] = 1;


             //add move to the board

             _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.X, true);

         }*/

        private void PlayMove(int player)
        {
            //ask user for row and column

            Console.SetCursorPosition(2, 19);

            if (player == 1)
                Console.Write("Player X");
            else
                Console.Write("Player O");

            Console.SetCursorPosition(2, 20);

            Console.Write("Please Enter Row: ");
            var row = Console.ReadLine();

            Console.SetCursorPosition(2, 22);


            Console.Write("Please Enter Column: ");
            var column = Console.ReadLine();

            //store move in the array
            int rowNumber = int.Parse(row);
            int columnNumber = int.Parse(column);
            int arrayPos = (rowNumber * 3) + columnNumber;

            _boardPositions[arrayPos] = player;


            //add move to the board
            if (player == 1)

                _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.X, true);
            else
                _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.O, true);
        }

        /* private void PlayMoveO()
         {
             //ask user for row and column

             Console.SetCursorPosition(2, 19);

             Console.Write("Player O");

             Console.SetCursorPosition(2, 20);

             Console.Write("Please Enter Row: ");
             var row = Console.ReadLine();

             Console.SetCursorPosition(2, 22);


             Console.Write("Please Enter Column: ");
             var column = Console.ReadLine();

             //store move in the array
             int rowNumber = int.Parse(row);
             int columnNumber = int.Parse(column);
             int arrayPos = (rowNumber * 3) + columnNumber;

             _boardPositions[arrayPos] = 1;


             //add move to the board

             _boardRenderer.AddMove(rowNumber, columnNumber, PlayerEnum.O, true);

         }*/

        public bool CheckIfPlayerWins(int player)
        {
            if ((_boardPositions[0] == player) && (-_boardPositions[1] == player) && (_boardPositions[2] == player))
                return true;
            if ((_boardPositions[0] == player) && (-_boardPositions[4] == player) && (_boardPositions[8] == player))
                return true;
            if ((_boardPositions[3] == player) && (-_boardPositions[4] == player) && (_boardPositions[5] == player))
                return true;
            if ((_boardPositions[6] == player) && (-_boardPositions[7] == player) && (_boardPositions[8] == player))
                return true;
            if ((_boardPositions[0] == player) && (-_boardPositions[3] == player) && (_boardPositions[6] == player))
                return true;
            if ((_boardPositions[2] == player) && (-_boardPositions[5] == player) && (_boardPositions[8] == player))
                return true;
            if ((_boardPositions[0] == player) && (-_boardPositions[4] == player) && (_boardPositions[8] == player))
                return true;
            if ((_boardPositions[2] == player) && (-_boardPositions[4] == player) && (_boardPositions[6] == player))
                return true;


            return false;
        }

        public void Run()
        {
            _rounds = 0;

            bool playerXWins = false;
            bool playerOWins = false;

            while (_rounds < 4)
            {
                //play x

                PlayMove(1);
                playerXWins = CheckIfPlayerWins(1);

                if (playerXWins)
                {
                    Console.WriteLine("Player X Wins!!!!");

                    break;
                }

                //play o

                PlayMove(2);
                playerOWins = CheckIfPlayerWins(2);

                if (playerOWins)
                {
                    Console.WriteLine("Player O Wins!!!!");

                    break;
                }

                //check if x won

                //if x won exit

                //check if o won

                //if o won exit

                _rounds++;
            }

            //any code here


            if (!playerXWins && !playerOWins)
                Console.WriteLine("The game is draw!!!");


            // FOR ILLUSTRATION CHANGE TO YOUR OWN LOGIC TO DO TIC TAC TOE

            /* Console.SetCursorPosition(2, 19);

             Console.Write("Player X");

             Console.SetCursorPosition(2, 20);

             Console.Write("Please Enter Row: ");
             var row = Console.ReadLine();

             Console.SetCursorPosition(2, 21);


             Console.Write("Please Enter Column: ");
             var column = Console.ReadLine();*/


            // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)
            // _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);

        }

    }
}
