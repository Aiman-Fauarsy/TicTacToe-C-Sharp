using System;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {

            playGame();
        }

        public static void PrintBoard(string[] gameArray)
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.BufferHeight = 30;
            Console.WriteLine(
                gameArray[0] + " | " + gameArray[1] + " | " + gameArray[2] + "\n" +
                gameArray[3] + " | " + gameArray[4] + " | " + gameArray[5] + "\n" +
                gameArray[6] + " | " + gameArray[7] + " | " + gameArray[8] + "\n");
        }

        public static void checkWinner(string player, string[] gameArray)
        {

            if (gameArray[0] == "X" && gameArray[1] == "X" && gameArray[2] == "X" ||
                gameArray[0] == "O" && gameArray[1] == "O" && gameArray[2] == "O")
            {
                Console.WriteLine("Player : " + player + " Is the winner ");



            }
            else if (gameArray[3] == "X" && gameArray[4] == "X" && gameArray[5] == "X" ||
                gameArray[3] == "O" && gameArray[4] == "O" && gameArray[5] == "O")
            {
                Console.WriteLine("Player : " + player + " Is the winner ");

            }
            else if (gameArray[6] == "X" && gameArray[7] == "X" && gameArray[8] == "X" ||
                gameArray[6] == "O" && gameArray[7] == "O" && gameArray[8] == "O")
            {
                Console.WriteLine("Player : " + player + " Is the winner ");



            }
            else if (gameArray[0] == "X" && gameArray[4] == "X" && gameArray[8] == "X" ||
               gameArray[0] == "O" && gameArray[4] == "O" && gameArray[8] == "O")
            {
                Console.WriteLine("Player : " + player + " Is the winner ");



            }
            else if (gameArray[2] == "X" && gameArray[4] == "X" && gameArray[6] == "X" ||
                gameArray[2] == "O" && gameArray[4] == "O" && gameArray[6] == "O")
            {
                Console.WriteLine("Player : " + player + " Is the winner ");


            }
            else if (gameArray[0] == "X" && gameArray[3] == "X" && gameArray[6] == "X" ||
                gameArray[0] == "O" && gameArray[3] == "O" && gameArray[6] == "O")
            {
                Console.WriteLine("Player : " + player + " Is the winner ");



            }
            else if (gameArray[2] == "X" && gameArray[5] == "X" && gameArray[8] == "X" ||
                gameArray[2] == "O" && gameArray[5] == "O" && gameArray[8] == "O")
            {
                Console.WriteLine("Player : " + player + " Is the winner ");


            }




        }

        public static void playGame()
        {

            string[] gameArray = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };

            Console.WriteLine("Lets start the game : \n ");
            PrintBoard(gameArray);
            bool playerTurn = true;
            string player = playerTurn ? "X" : "O";
            int counter = 0;

            while (counter < 9)
            {

                player = playerTurn ? "X" : "O";
                Console.WriteLine("Player " + player + " chose ");
                string userTurn = Console.ReadLine();
                if (userTurn == "1" &&
                    gameArray[0] != "X" &&
                    gameArray[0] != "O")
                {
                    gameArray[0] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "2" && gameArray[1] != "X" &&
                    gameArray[1] != "O")
                {
                    gameArray[1] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "3" && gameArray[2] != "X" &&
                    gameArray[2] != "O")
                {
                    gameArray[2] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "4" && gameArray[3] != "X" &&
                    gameArray[3] != "O")
                {
                    gameArray[3] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "5" && gameArray[4] != "X" &&
                    gameArray[4] != "O")
                {
                    gameArray[4] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "6" && gameArray[5] != "X" &&
                    gameArray[5] != "O")
                {
                    gameArray[5] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "7" && gameArray[6] != "X" &&
                    gameArray[6] != "O")
                {
                    gameArray[6] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "8" && gameArray[7] != "X" &&
                    gameArray[7] != "O")
                {
                    gameArray[7] = player;
                    PrintBoard(gameArray);


                }
                else if (userTurn == "9" && gameArray[8] != "X" &&
                    gameArray[8] != "O")
                {
                    gameArray[8] = player;
                    PrintBoard(gameArray);


                }
                else
                {
                    Console.WriteLine("please chose valid input. ");
                    counter--;
                    playerTurn = !playerTurn;

                }
                checkWinner(player, gameArray);
                counter++;
                playerTurn = !playerTurn;

            }


        }
    }
}


