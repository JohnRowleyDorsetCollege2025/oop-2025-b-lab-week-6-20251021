using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_lab_week_6_20251021.Models
{
    public static class ComplexCheckoutDriver
    {
        public static void Run()
        {
            Console.WriteLine("Complex Checkout System with OOP Principles\n");
            var apple = new Product("Apple", "Fruit", 60);
            var orange = new Product("Orange", "Fruit", 25);

            // Initialize checkout with simple price calculator
            var priceCalculator = new SimplePriceCalculator();
            var checkout = new Checkout(priceCalculator);

            // Scan products (simulate till scan)
            var itemsToScan = new List<IProduct> { apple, apple, orange, apple };

            foreach (var item in itemsToScan)
            {
                checkout.Scan(item);
            }

            // Calculate total and print receipt
            int totalInPence = checkout.GetTotalPriceInPence();
            string totalFormatted = FormatToPounds(totalInPence);

            Console.WriteLine("Scanned items: " + string.Join(", ", checkout.GetScannedItems()));
            Console.WriteLine($"Total cost: {totalFormatted}");

        }

        static string FormatToPounds(int pence)
        {
            return $"£{(pence / 100.0):0.00}";
        }
    }
}
