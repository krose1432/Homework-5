using System;
using System.IO;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] names = new string[1000];
            double[] AccountBalances = new double[1000];

            string[] nameLines = File.ReadAllLines("CustomerNames.csv");
            string[] balanceLines = File.ReadAllLines("AccountBalances.csv");

            for (int i =1; i < nameLines.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(nameLines[i])== true)
                {
                    continue;
                }
                
                names[i - 1] = nameLines[i];
                string balance = balanceLines[i];
                balance = balance.Replace("$", "");
                AccountBalances[i - 1] = Convert.ToDouble(balance);

            }
            Console.WriteLine("Which account would you like to look at?");
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }
            string response = Console.ReadLine();

            for (int i=0; i < names.Length; i++)
            {
                if (response.ToLower() == names[i].ToLower())
                {
                    Console.WriteLine(response + " has a balance of " + AccountBalances[i].ToString("C"));
                }
            }
        }
    }
}
