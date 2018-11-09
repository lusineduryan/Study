﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FixedIncome
{
    class FixedIncome
    {
        public double InterestRate { get; set; }
        public int Maturity { get; set; }
        public string Rating { get; set; }
        public string Currency { get; set; }
        public string CountryOfIncorporation { get; set; }
        private int volume = 0;
        public void Volume(int numberOfTrades)
        {
            volume += numberOfTrades / 1000;
        }
        public FixedIncome()
        {
            Console.WriteLine("New instrument added!");
        }
        public FixedIncome(double rate, int mat, string rat, string cur,string country)
        {
            InterestRate = rate;
            Maturity = mat;
            Rating = rat;
            Currency = cur;
            CountryOfIncorporation = country;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            FixedIncome bond = new FixedIncome(5.5, 7, "AA", "EUR", "Austria");
            FixedIncome note = new FixedIncome(1, 1, "AAA", "USD", "USA");
            bond.Maturity = 6;
            bond.Volume(1000);
            note.Volume(1500000);
            Console.WriteLine(note.Currency);
        }
    }
}
