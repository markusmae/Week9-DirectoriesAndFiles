using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MyShoppingListItems
{
    class Program
    {
        static void Main(string[] args)
        {
            string fileLocation = @"C:\Users\...\samples\ShoppingList";
            string fileName = @"\\shoppinglist.txt";

            string[] arrayFromFile = File.ReadAllLines($"{fileLocation}{fileName}");
            List<string> shoppinglist = arrayFromFile.ToList<string>();


            bool loopActive = true;
            while(loopActive)
            {
                Console.WriteLine("Kas soovid sisestada ostusoovi? Y/N:");
                char userInput = Convert.ToChar(Console.ReadLine().ToLower());

                if (userInput == 'y')
                {
                    Console.WriteLine("Sisesta oma soov:");
                    string userWish = Console.ReadLine();
                    shoppinglist.Add(userWish);
                }
                else
                {
                    loopActive = false;
                    Console.WriteLine("Tundub, et rohkem soove Teil hetkel ei ole.");
                }
                foreach (string wish in shoppinglist)
                {
                    Console.WriteLine($"Sinu soovid olid: {wish}");
                }

                File.WriteAllLines($"{fileLocation}{fileName}", shoppinglist);

            }
            
        }
    }
}
