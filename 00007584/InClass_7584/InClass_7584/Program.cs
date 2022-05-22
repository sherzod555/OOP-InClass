using System;
using System.Collections.Generic;

namespace InClass_7584
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"________________________________________________________________
                    BIKE   STORE
________________________________________________________________");

            Store str = Store.GetStore();
            str.PopulateBikesForTest();

            repeatActions(str);
        }

        public static void repeatActions(Store str)
        {
            Console.Write(@"
What do you want to do?
[1] Search Bikes
[2] Show all Bikes
>> select a number: ");

            string step1 = Console.ReadLine();

            if (step1 == "1")
            {
                string selection = GetSelection();
                string search = GetSearch();

                Console.WriteLine("Enter a request: ");
                string request = Console.ReadLine();

                if (selection == "1")
                {
                    displayAsTable(str.SearchNew(str, search, request));
                }
                else
                {
                    displayAsTable(str.SearchUsed(str, search, request));
                }
            }
            else if (step1 == "2")
            {
                displayAsTable(str.GetAllBikes());
            }
            else
            {
                Console.WriteLine("\nWRONG SELECATOIN, PLEASE TRY AGAIN!");
            }

            Console.WriteLine("________________________________________________________________");
            repeatActions(str);
        }

        private static void DisplayAsTable(List<Bike> bikes)
        {
            throw new NotImplementedException();
        }


        // get list and display as table
        public static void displayAsTable(List<Bike> bikes)
        {
            if (bikes.Count <= 0)
            {
                Console.WriteLine("\nNOT FOUND, PLEASE TRY AGAIN!");
                return;
            }


            Console.WriteLine();
            Console.Write("Brand".PadRight(20, ' '));
            Console.Write('|');
            Console.Write("Model".PadRight(20, ' '));
            Console.Write('|');
            Console.Write("Price".PadRight(15, ' '));
            Console.Write('|');
            Console.Write("Rating".PadRight(15, ' '));
            Console.Write('|');
            Console.Write("Year".PadRight(15, ' '));
            Console.Write('|');
            Console.WriteLine("Type".PadRight(20, ' '));
            Console.WriteLine("—".PadRight(105, '—'));

            foreach (Bike bike in bikes)
            {
                Console.Write(bike.Brand.PadRight(20, ' '));
                Console.Write('|');
                Console.Write(bike.Model.PadRight(20, ' '));
                Console.Write('|');
                Console.Write(bike.Price.ToString().PadRight(15, ' '));
                Console.Write('|');
                Console.Write(bike.Rating.PadRight(15, ' '));
                Console.Write('|');
                Console.Write(bike.Year.ToString().PadRight(15, ' '));
                Console.Write('|');
                Console.WriteLine(bike.GetType().ToString().PadRight(20, ' '));
            }

            Console.WriteLine();
        }


        static string GetSelection()
        {
            Console.Write(@"
Choose the type of bike!: 
[1] New Bike
[2] Used Bike

>>");
            string request = Console.ReadLine();

            if (request != "1" && request != "2")
            {
                Console.WriteLine("WRONG INPUT!");
                return GetSelection();
            }
            else
            {
                return request;
            }
        }

        static string GetSearch()
        {
            Console.Write(@"
Search by: 
[1] Brand
[2] Model
[3] Price

>>");
            string request = Console.ReadLine();

            if (request != "1" && request != "2" && request != "3")
            {
                Console.WriteLine("WRONG INPUT!");
                return GetSearch();
            }
            else
            {
                return request;
            }
        }
    }
}
