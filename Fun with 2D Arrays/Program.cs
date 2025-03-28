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

            Console.WriteLine("How manny Rows and Colums do you want to Have?:");
            Console.WriteLine("Rows:");
            int rows = int.Parse(Console.ReadLine());
            Console.WriteLine("Colums:");
            int cols = int.Parse(Console.ReadLine());
            int[,] numbers = new int[rows, cols];
            Random rndNumbers = new Random();

            for(int i = 0; i < cols; i++)
            {
                Console.Write("+-");
            }
            Console.WriteLine("+");
            
            for (int i = 0; i < rows; i++)
            {

                for (int j = 0; j < cols; j++)
                {
                    numbers[i, j] = rndNumbers.Next(9);

                    Console.Write("|" + numbers[i, j]);

                }
                Console.WriteLine("|");
                if(rows != cols)
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

        }
    }
}
