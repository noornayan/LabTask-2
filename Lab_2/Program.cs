using System;


namespace LabTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.Write a program to print all even numbers from 1 to n using for loop.
            int n = 100;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("even : " + i);
            }
            //2.Write a program to print the following pattern using loop.
            for (int j = 1; j <= 2; j++)
            {
                Console.WriteLine("X0X0X0");
                Console.WriteLine("0X0X0X");
            }
            //3.Write a program to print the given number pattern using loop.
            int rows = 5;
            int cols = 5;
            int k;
            int m;
            for (k = 1; k <= rows; k++)
            {
                for (m = k; m < k + cols; m++)
                {
                    Console.Write(m);
                }

                Console.WriteLine("\n");
            }
            /*4.Write a program to print the sum of odd and even numbers starting from
            1 to 100.*/
            int i1, odd_sum = 0, even_sum = 0, num = 100;

            for (i1 = 1; i1 <= num; i1++)
            {
                if (i1 % 2 == 0)
                    even_sum = even_sum + i1;
                else
                    odd_sum = odd_sum + i1;
            }
            Console.WriteLine("Sum of all odd numbers  = " + odd_sum + "\n");
            Console.WriteLine("Sum of all even numbers = " + even_sum + "\n");
            /*5.Write a program to print the given number pattern using loop.
              1
               2
                3
                 4
                  5
                */
            int i5, j5, rows5 = 5;
            for (i5 = 1; i5 <= rows5; ++i5)
            {
                for (j5 = 1; j5 <= i5; ++j5)
                {
                    if (j5 == i5)
                    {
                        for (int t = 1; t <= j5; t++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(j5);
                    }
                }
                Console.WriteLine("\n");
            }
            /*6.Write a program to find out factorial of a number. Example factorial of
             5 is 1 * 2 * 3 * 4 * 5
            */
            int num6 = 5, sum6 = 1;
            for (int i6 = 1; i6 <= num6; i6++)
            {
                sum6 = sum6 * i6;
            }
            Console.WriteLine("Factorial : " + sum6);
            /*7. Print the pattern below.
               *
               **
               ***
               ****
               *****
               ****
               ***
               **
               *
             */
            int i7, j7, N7 = 5;
            for (i7 = 1; i7 <= N7; i7++)
            {
                for (j7 = 1; j7 <= i7; j7++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (i7 = N7 - 1; i7 >= 1; i7--)
            {
                for (j7 = 1; j7 <= i7; j7++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
