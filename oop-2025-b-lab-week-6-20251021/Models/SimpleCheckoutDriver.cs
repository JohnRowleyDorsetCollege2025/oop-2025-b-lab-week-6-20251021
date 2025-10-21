using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_lab_week_6_20251021.Models
{
    public static class SimpleCheckoutDriver
    {
        private const int ApplePrice = 60;    // 60 pence
        private const int OrangePrice = 25;   // 25 pence
        public static void Run()
        {
            Console.WriteLine("Simple Checkout System\n");
            List<string> items = new List<string> { "Apple", "Apple", "Orange", "Apple" };

            // Calculate total cost
            int totalCostInPence = CalculateTotalCost(items);

            // Convert to pounds
            string totalCostFormatted = FormatToPounds(totalCostInPence);

            // Output the result
            Console.WriteLine($"Scanned items: {string.Join(", ", items)}");
            Console.WriteLine($"Total cost: {totalCostFormatted}");

            
        }

        static int CalculateTotalCost(List<string> items)
        {
            int total = 0;

            foreach (var item in items)
            {
                switch (item.Trim().ToLower())
                {
                    case "apple":
                        total += ApplePrice;
                        break;
                    case "orange":
                        total += OrangePrice;
                        break;
                    default:
                        Console.WriteLine($"Unknown item ignored: {item}");
                        break;
                }
            }

            return total;
        }

        static string FormatToPounds(int pence)
        {
            return $"£{(pence / 100.0):0.00}";
        }
    }
}
