using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fun_with_2D_Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //for Better updating the user choises and Grid Appearance
            const string USER_GRID_CHOISE_1 = "S";
            const string USER_GRID_CHOISE_2 = "N";
            const string USER_GRID_CHOISE_3 = "C";
            string framingGridSymbols = "+--";
            string framingGridNumbers = "+-";
            string framingGridCorners = "+";
            string framingGridVerticalLines = "|";


            Console.OutputEncoding = Encoding.UTF8;

            // User inputs and choises
            Console.WriteLine("Chose bettwen numbers and Symbols: S= symbol, N= Numbers, C=Chess");
            string userChoiseInput = Console.ReadLine().ToUpper();
            Console.WriteLine("How manny Rows and Colums do you want to Have?:");
            Console.WriteLine("Rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Colums:");
            int cols = int.Parse(Console.ReadLine());

            //2D Array for the Visualisation
            string[,] itemsGrid = new string[rows, cols];
            // List with Numbers
            List<string> numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int indexListNumbers = numbers.Count;
            // string List with UTF8 symbols
            List<string> items = new List<string>();

            string apple = "\U0001F34E";
            string banana = "\U0001F34C";
            string strawbery = "\U0001F353";
            string orange = "\U0001F34A";
            string kirschen = "\U0001F352";
            string birne = "\U0001F350";
            string trauben = "\U0001F347";
            // Add to List(items)
            items.Add(apple);
            items.Add(banana);
            items.Add(orange);
            items.Add(strawbery);
            items.Add(birne);
            items.Add(kirschen);
            items.Add(trauben);
            int indexListItems = items.Count;

            Random gridItems = new Random();
            int switchIndexLists = 0;
            List<string> switchLists = new List<string>();
            // Case 3 variables for Chessgrid printing
            string chessGridSymbol1 = "X";
            string chessGridSymbol2 = "O";
            bool chessGrid = true;


            //gridframes will be updatet on the user choise
            string gridFrames = "-";
            // User case choise and variables for the grid output and displyFrames
            switch (userChoiseInput)
            {
                case USER_GRID_CHOISE_1:
                    switchLists = items;
                    switchIndexLists = indexListItems;
                    gridFrames = framingGridSymbols;
                    break;
                case USER_GRID_CHOISE_2:
                    switchLists = numbers;
                    switchIndexLists = indexListNumbers;
                    gridFrames = framingGridNumbers;
                    break;
                case USER_GRID_CHOISE_3:
                    switchLists.Add(chessGridSymbol1);
                    switchLists.Add(chessGridSymbol2);
                    switchIndexLists = 2;
                    gridFrames = "";
                    framingGridCorners = "";
                    framingGridVerticalLines = "";
                    chessGrid = false;
                    break;


            }

            // Nested Loops for displayng the 2D Array as Matrix 
            if (chessGrid)
            {
                for (int i = 0; i < cols; i++)
                {
                    Console.Write(gridFrames);
                }
                Console.WriteLine(framingGridCorners);
            }


            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    if (chessGrid)
                    {
                        itemsGrid[i, j] = switchLists[gridItems.Next(switchIndexLists)];
                        Console.Write(framingGridVerticalLines + itemsGrid[i, j]);
                    }
                    else
                    {
                        itemsGrid[i, j] = switchLists[(i + j) % 2];// Modulo Math for rest division (0,1)
                        Console.Write(itemsGrid[i, j]);
                    }


                }
                Console.WriteLine(framingGridVerticalLines);
                if (rows != cols && chessGrid)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Console.Write(gridFrames);

                    }
                    Console.WriteLine(framingGridCorners);
                }
                if (rows == cols && chessGrid)
                {
                    for (int r = 0; r < rows; r++)
                    {
                        Console.Write(gridFrames);

                    }
                    Console.WriteLine(framingGridCorners);
                }


            }

        }
    }
}
