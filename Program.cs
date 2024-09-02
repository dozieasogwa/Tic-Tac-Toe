namespace Tic_Tac_Toe
{
    internal class Program
    {
        static char[] spaces = new char[] { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag;

      
        /// <summary>
        /// Function to draw the board columns and rows.
        /// </summary>
        static void DrawBoard()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0}   |  {1}  |   {2}  ", spaces[0], spaces[1], spaces[2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0}   |  {1}  |   {2}  ", spaces[3], spaces[4], spaces[5]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine(" {0}   |  {1}  |   {2}  ", spaces[6], spaces[7], spaces[8]);
            Console.WriteLine("     |     |     ");
        }

        /// <summary>
        /// Function to determine a win based on the matches of variable spaces.
        /// </summary>
        /// <returns></returns>
        static int CheckWin()
        {
            if (spaces[0] == spaces[1] && //Horizontal_Marches 1
                spaces[1] == spaces[2] ||
                spaces[3] == spaces[4] && //Horizontal 2
                spaces[4] == spaces[5] ||
                spaces[6] == spaces[7] && //Horizontal 3
                spaces[7] == spaces[8] ||
                spaces[2] == spaces[5] && //Verical_Marches 1
                spaces[5] == spaces[8] ||
                spaces[1] == spaces[4] && //Verical 2
                spaces[4] == spaces[7] ||
                spaces[0] == spaces[3] && //Verical 3
                spaces[3] == spaces[6] ||
                spaces[0] == spaces[4] && //Diagonal_Marches 1
                spaces[4] == spaces[8] ||
                spaces[2] == spaces[4] && //Diagonal 2
                spaces[4] == spaces[6]
                )
            {
                return 1;
            }
            else if (spaces[0] != '1' &&
                     spaces[1] != '2' &&
                     spaces[2] != '3' &&
                     spaces[3] != '4' &&
                     spaces[4] != '5' &&
                     spaces[5] != '6' &&
                     spaces[6] != '7' &&
                     spaces[7] != '8' &&
                     spaces[8] != '9')
            {
                return -1;
            }
            else
            {
                return 0;
            }


        }

        /// <summary>
        /// fuction to create the character "X".
        /// </summary>
        /// <param name="position"></param>
        static void DrawX(int position)
        {
            spaces[position] = 'X';
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="position"></param>
        static void DrawO(int position)
        {
            spaces[position] = 'O';
        }
        static void Main(string[] args)
        {
            // gameBoard = new GameBoard();
            
            //var drawBoard = new DrawBoard();
            do
            {
                Console.Clear();
                Console.WriteLine("Player 1 : X and Player 2 : 0" + "\n");
                if (player % 2 == 0)
                {
                    Console.WriteLine("Player 2's turn");
                }
                else
                {
                    Console.WriteLine("Player 1's turn");
                }
                Console.WriteLine("\n");
                DrawBoard();
                choice = int.Parse(Console.ReadLine()) - 1;

                if (spaces[choice] != 'X' &&
                    spaces[choice] != 'O')
                {
                    if (player % 2 == 0)
                    {
                        DrawO(choice);
                    }
                    else
                    { 
                        DrawX(choice); 
                    }
                    player++; 
                }
                else
                {
                    Console.WriteLine("Sorry the row {0} is already marked with {1} \n", choice, spaces[choice]);
                    Console.WriteLine("Please wait 2 seconds, board is loading again...");
                    Thread.Sleep(2000);
                }

                flag = CheckWin();
            } 
            while (flag != 1 && flag != -1);

            Console.Clear();
            DrawBoard();

            if (player == 1)
            {
                Console.WriteLine("Player {0} has won", (player % 2) + 1);
            }
            else
            {
                Console.WriteLine("Tie Game");
            }

            Console.ReadLine();

        }
    }
}
