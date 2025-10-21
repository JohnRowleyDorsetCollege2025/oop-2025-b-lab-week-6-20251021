using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_lab_week_6_20251021.Models
{
    public static class DictionaryDemoDriver
    {
        public static void Run()
        {
            CapitalCities();
            FruitCounts();
        }

        public static void CapitalCities()
        {
            Dictionary<string, string> countryCapitals = new Dictionary<string, string>
        {
            { "FRANCE", "PARIS" },
            { "IRELAND", "DUBLIN" },
            { "UK", "LONDON" }
        };

            foreach (var entry in countryCapitals)
            {
                Console.WriteLine($"{entry.Key} -> {entry.Value}");
            }
        }

        public static void FruitCounts()
        {
            Dictionary<string, int> fruitBasket = new Dictionary<string, int>
        {
            { "apple", 2 },
            { "orange", 3 }
        };

            // Incoming list of fruits (e.g., someone adds these to the basket)
            List<string> incomingFruits = new List<string> { "apple", "banana", "apple", "orange", "banana", "kiwi" };

            // Update the dictionary counts
            foreach (string fruit in incomingFruits)
            {
                if (fruitBasket.ContainsKey(fruit))
                {
                    fruitBasket[fruit]++;
                }
                else
                {
                    fruitBasket[fruit] = 1;
                }
            }

            // Display updated fruit counts
            foreach (var kvp in fruitBasket)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

        }
    }
}
