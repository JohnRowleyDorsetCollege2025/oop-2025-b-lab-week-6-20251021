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
    }
}
