using System;
using System.Collections.Generic;

namespace Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> favoriteThings = new List<string>();
          


            Console.WriteLine("What is something that you would like to add to this list of favorite things");
            string response = Console.ReadLine();
            favoriteThings.Add(response);
            Console.WriteLine("Would you like anything else?");
            response = Console.ReadLine().ToLower();
            if (response == "yes")
            {
                do
                {
                    Console.WriteLine("What else would you like to add?.");
                    response = Console.ReadLine();
                    favoriteThings.Add(response);
                    Console.WriteLine("Would you like to add another item to the list?");
                    response = Console.ReadLine();
                }
                while (response != "no");
            }
            Console.WriteLine("Your list of favorite items are here:");
            foreach (string item in favoriteThings)
            {
                Console.WriteLine($"{item}");
            }
            Console.WriteLine("\n Your list of favorite items in reverse order are: ");
            for (int i = favoriteThings.Count-1;i >=0; i--)
                {
                    
                Console.WriteLine(favoriteThings[i]);
            }
            Console.WriteLine("\n Here is your list of items but skipping every other item. ");
             for (int i = 0; i < favoriteThings.Count; i+=2)
            {
                Console.WriteLine(favoriteThings[i]);
            }  

        }
    }
}
