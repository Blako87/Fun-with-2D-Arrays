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
<<<<<<< HEAD
            //for Better updating the user choises and Grid Appearance
            const string USERGRIDCHOISE1 = "S";
            const string USERGRIDCHOISE2 = "N";
            const string FRAMINGGRIDSYMBOLS = "+--";
            const string FRAMINGGRIDNUMBERS = "+-";
            const string FRAMINGGRIDCORNERS = "+";
            const string FRAMINGGRIDVERTICALLINES = "|";

            Console.OutputEncoding = Encoding.UTF8;

=======
            Console.OutputEncoding = Encoding.UTF8;

>>>>>>> 9c9207e945b768708d32bde0268377ff62297b02
            // User inputs and choises
            Console.WriteLine("Chose bettwen numbers and Symbols: S= symbol, N= Numbers");
            string userChoiseInput = Console.ReadLine().ToUpper();
            Console.WriteLine("How manny Rows and Colums do you want to Have?:");
            Console.WriteLine("Rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Colums:");
            int cols = int.Parse(Console.ReadLine());
<<<<<<< HEAD

            //2D Array for the Visualisation
            string[,] itemsGrid = new string[rows, cols];
            // List with Numbers
            List<string> numbers = new List<string> { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
            int indexListNumbers = numbers.Count;
            // string List with UTF8 symbols
            List<string> items = new List<string>();

=======
            int[,] numbers = new int[rows, cols];
            int number = 9;
            Random rndNumbers = new Random();

            // string List with UTF8 symbols
            List<string> items = new List<string>();
>>>>>>> 9c9207e945b768708d32bde0268377ff62297b02
            string apple = "\U0001F34E";
            string banana = "\U0001F34C";
            string strawbery = "\U0001F353";
            string orange = "\U0001F34A";
            string kirschen = "\U0001F352";
            string birne = "\U0001F350";
            string trauben = "\U0001F347";
<<<<<<< HEAD
            // Add to List(items)
=======

>>>>>>> 9c9207e945b768708d32bde0268377ff62297b02
            items.Add(apple);
            items.Add(banana);
            items.Add(orange);
            items.Add(strawbery);
            items.Add(birne);
            items.Add(kirschen);
            items.Add(trauben);
<<<<<<< HEAD
            int indexListItems = items.Count;

            Random gridItems = new Random();
            int switchIndexLists = 0;
            List<string> switchLists = new List<string>();
            //gridframes will be updatet on the user choise
            string gridFrames = "-";
            // User case choise and variables for the grid output and displyFrames
            switch (userChoiseInput)
            {
                case USERGRIDCHOISE1:
                    switchLists = items;
                    switchIndexLists = indexListItems;
                    gridFrames = FRAMINGGRIDSYMBOLS;
                    break;
                case USERGRIDCHOISE2:
                    switchLists = numbers;
                    switchIndexLists = indexListNumbers;
                    gridFrames = FRAMINGGRIDNUMBERS;
                    break;
            }

            // Nested Loops for displayng the 2D Array as Matrix 

            for (int i = 0; i < cols; i++)
            {
                Console.Write(gridFrames);
            }
            Console.WriteLine(FRAMINGGRIDCORNERS);

            for (int i = 0; i < rows; i++)
=======

            int [,] symbols = new int [rows, cols];
            Random rndItems = new Random();

            switch (userChoiseInput)
>>>>>>> 9c9207e945b768708d32bde0268377ff62297b02
            {
                case "N":

<<<<<<< HEAD
                for (int j = 0; j < cols; j++)
                {
                    itemsGrid[i, j] = switchLists[gridItems.Next(switchIndexLists)];


                    Console.Write(FRAMINGGRIDVERTICALLINES + itemsGrid[i, j]);

                }
                Console.WriteLine(FRAMINGGRIDVERTICALLINES);
                if (rows != cols)
                {
                    for (int c = 0; c < cols; c++)
                    {
                        Console.Write(gridFrames);

                    }
                    Console.WriteLine(FRAMINGGRIDCORNERS);
                }
                else
                {
                    for (int r = 0; r < rows; r++)
                    {
                        Console.Write(gridFrames);

                    }
                    Console.WriteLine(FRAMINGGRIDCORNERS);
                }
=======
                    for (int i = 0; i < cols; i++)
                    {
                        Console.Write("+-");
                    }
                    Console.WriteLine("+");

                    for (int i = 0; i < rows; i++)
                    {

                        for (int j = 0; j < cols; j++)
                        {
                            numbers[i, j] = rndNumbers.Next(number);

                            Console.Write("|" + numbers[i, j]);

                        }
                        Console.WriteLine("|");
                        if (rows != cols)
                        {
                            for (int c = 0; c < cols; c++)
                            {
                                Console.Write("+-");

                            }
                            Console.WriteLine("+");
                        }
                        else
                        {
                            for (int r = 0; r < rows; r++)
                            {
                                Console.Write("+-");

                            }
                            Console.WriteLine("+");
                        }

                    }
                    break;

                case "S":

                    for (int i = 0; i < cols; i++)
                    {
                        Console.Write("+--");
                    }
                    Console.WriteLine("+");

                    for (int i = 0; i < rows; i++)
                    {

                        for (int j = 0; j < cols; j++)
                        {
                            symbols[i, j] = rndItems.Next(items.Count);

                            Console.Write("|" + items[symbols[i, j]]);

                        }
                        Console.WriteLine("| ");
                        if (rows != cols)
                        {
                            for (int c = 0; c < cols; c++)
                            {
                                Console.Write("+--");

                            }
                            Console.WriteLine("+");
                        }
                        else
                        {
                            for (int r = 0; r < rows; r++)
                            {
                                Console.Write("+--");

                            }
                            Console.WriteLine("+");
                        }
                    }
                    break;
>>>>>>> 9c9207e945b768708d32bde0268377ff62297b02


            }
        }
    }
}
