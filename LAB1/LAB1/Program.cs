using System;

namespace LAB1
{
    internal class Program
    {
        static void Task1()
        {
            Console.Write("Enter value of n (0<n<1): ");
            double n = Convert.ToDouble(Console.ReadLine());

            // Створення binary, що буде містити перетворення
            string binary = "0,";

            for (int i = 0; i < 12; i++)
            {
                n *= 2;
                if (n >= 1)
                {
                    binary += "1";
                    n -= 1;
                }
                else
                {
                    binary += "0";
                }
            }

            Console.WriteLine("Binary = " + binary + '\n');
        }

        static void Task2()
        {

            Console.Write("Enter value of x: ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of y: ");
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter value of z: ");
            double z = Convert.ToDouble(Console.ReadLine());

            double a = Math.Pow(x, 2) / 2 - Math.Pow(x, 4) / 24 + Math.Pow(x, 6) / 720;
            double b = Math.Sin(3 * Math.PI / 4) + x * Math.Cos(z) - z * Math.Cos(y) + y * Math.Cos(x);
            double c = 5 * (x * Math.Cos(z) - z * Math.Cos(y) + y * Math.Cos(x));

            double max = Math.Max(a, Math.Min(b, c));
            Console.WriteLine("Max(a, Min(b, c)) = " + max + '\n');
        }

        static void Task3()
        {
            // Створення матриці
            int rows = 7;
            int cols = 6;

            int[,] matrix = new int[rows, cols];
            Random rand = new Random();
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rand.Next(-5, 6);
                }
            }

            // Створення вектора b
            int[] b = new int[cols];
            for (int j = 0; j < cols; j++)
            {
                int count = 0;
                for (int i = 0; i < rows; i++)
                {
                    if (matrix[i, j] > 0)
                    {
                        count++;
                    }
                }
                b[j] = count;
            }

            // Виведення
            Console.WriteLine("Матриця A:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + " | ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.Write("Вектор b: ");
            for (int j = 0; j < cols; j++)
            {
                Console.Write(b[j] + " ");
            }
            Console.WriteLine();


            int maxIndex = 0;
            for (int j = 1; j < cols; j++)
            {
                if (b[j] > b[maxIndex])
                {
                    maxIndex = j;
                }
            }
            Console.WriteLine("Номер максимального елемента вектора b: " + maxIndex);
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Task 1: \n");
            Task1();

            Console.WriteLine("Task 2: \n");
            Task2();

            Console.WriteLine("Task 3: \n");
            Task3();
        }
    }
}
