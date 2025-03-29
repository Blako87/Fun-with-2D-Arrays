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
            Console.OutputEncoding = Encoding.UTF8;

            // User inputs and choises
            Console.WriteLine("Chose bettwen numbers and Symbols: S= symbol, N= Numbers");
            string userChoiseInput = Console.ReadLine().ToUpper();
            Console.WriteLine("How manny Rows and Colums do you want to Have?:");
            Console.WriteLine("Rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Colums:");
            int cols = int.Parse(Console.ReadLine());
            int[,] numbers = new int[rows, cols];
            int number = 9;
            Random rndNumbers = new Random();

            // string List with UTF8 symbols
            List<string> items = new List<string>();
            string apple = "\U0001F34E";
            string banana = "\U0001F34C";
            string strawbery = "\U0001F353";
            string orange = "\U0001F34A";
            string kirschen = "\U0001F352";
            string birne = "\U0001F350";
            string trauben = "\U0001F347";

            items.Add(apple);
            items.Add(banana);
            items.Add(orange);
            items.Add(strawbery);
            items.Add(birne);
            items.Add(kirschen);
            items.Add(trauben);

            int [,] symbols = new int [rows, cols];
            Random rndItems = new Random();

            switch (userChoiseInput)
            {
                case "N":

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


            }
        }
    }
}
