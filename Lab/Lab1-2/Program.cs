﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_2
{
    class BubbleSortFunction
    {
        
        static void Main(string[] args)
        {
            // input
            // int[] input = { 4, 5, 2, 8, 9, 1, 2, 4, 3, 1 };

            // get input
            int size;
            Console.WriteLine("Enter size: ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] input = new int[size];
            for(int i = 0;i < size;i++)
            {
                Console.WriteLine("Enter {0}: ", i+1);
                input[i] = Convert.ToInt32(Console.ReadLine());
            }
            process(input);
            display(input);
        }

        
     

        // process
        static void process(int[] input)
        {
            bool flag = true;
            while (flag)
            {
                flag = false;
                for (int i = 0; i != input.Length - 1; i++)
                {
                    if (input[i] > input[i + 1])
                    {
                        int temp = input[i];
                        input[i] = input[i + 1];
                        input[i + 1] = temp;
                        flag = true;
                    }
                }
            }
        }
        // output
        static void display(int[] input)
        {
            for (int i = 0; i != input.Length; i++)
            {
                Console.Write(input[i]);
                Console.Write(" ");
            }
            Console.ReadKey();
        }
    }
}
