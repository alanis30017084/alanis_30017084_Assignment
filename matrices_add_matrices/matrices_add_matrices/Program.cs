using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrices_add_matrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();

            // Using a nested loop to populate and display matrix A with random numbers.
            int[,] A = new int[3, 3];

            Console.WriteLine("Auto-generated matrix A: ");
            for (int x = 0; x <3; x++)
            {
                for (int y = 0; y< 3; y++)
                {
                    A[x, y] = rand.Next(-10, 10);
                    Console.Write(A[x, y] + " ");
                }
                Console.WriteLine();
            }

            // Using the same method as above to create matrix B.
            Console.WriteLine("\nAuto-generated matrix B: ");
            int[,] B = new int[3, 3];

            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    B[x, y] = rand.Next(-10, 10);
                    Console.Write(B[x, y] + " ");
                }
                Console.WriteLine();
            }

            // Using Console.Write within the nested loop to add values of matrix A and B, displayed as matrix C.
            Console.WriteLine("\nResulting matrix C from adding A and B: ");
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Console.Write(A[x, y] + B[x, y] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
