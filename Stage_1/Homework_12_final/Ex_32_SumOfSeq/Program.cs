﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_32_sumOfSeq1
{
    class Program
    {
        static double ReverseFactorial(int number)
        {
            if (number == 1) return 1;
            return ReverseFactorial(number - 1) * (1.0 / number);
        }
        static double SumOfSeq(int number)
        {
            double sum = 1;
            for (int i = 1; i <= number; i++)
            {
                sum += ReverseFactorial(i);
            }
            Console.WriteLine(sum);
            return sum;
        }
        static void Main(string[] args)
        {
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            double sumOfSeq = SumOfSeq(inputNumber); 
            Console.ReadKey();
        }
    }
}
