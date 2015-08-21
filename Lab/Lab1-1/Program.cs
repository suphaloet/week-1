using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_1
{
    class BubbleSort
    {
        // use flag variable
        /*
        static void Main(string[] args)
        {
            bool flag = true;
            // check how many times at line 24
            int check = 0;

            // input
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

            // process
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    // larger to smaller
                    if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                        check++;
                    }
                    // smaller to larger
                    /*                  if (input[i] > input[i + 1])
                                      {
                                          int temp = input[i];
                                          input[i] = input[i + 1];
                                          input[i + 1] = temp;
                                          flag = true;
                                          check++;
                                      }*//*
                }
            }

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.WriteLine("\nAt line 24 will be executed: {0} times", check);
            Console.ReadKey();
        }*/

        // don't use flag variable
        static void Main(string[] args)
        {
            //bool flag = true;
            // check how many times at line 24
            int check = 0;
            int j = 0;
            // input
            int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

            // process
            while (j == 0)
            {
                j = 1;
                for (int i = 0; i != input.Length - 1; i++)
                { 
                    // larger to smaller
                    if (input[i] < input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        j = 0;
                        check++;
                    }
                    // smaller to larger
                    /*                  if (input[i] > input[i + 1])
                                      {
                                          int temp = input[i];
                                          input[i] = input[i + 1];
                                          input[i + 1] = temp;
                                          flag = true;
                                          check++;
                                      }*/
                }
            }

            // output
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.WriteLine("\nAt line 24 will be executed: {0} times", check);
            Console.ReadKey();
        }
    }
}
