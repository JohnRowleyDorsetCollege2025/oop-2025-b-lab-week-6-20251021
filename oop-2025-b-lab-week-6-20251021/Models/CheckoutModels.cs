using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_b_lab_week_6_20251021.Models
{
    public interface IProduct
    {
        string Name { get; }
        string Category { get; }
        int PriceInPence { get; }
    }

    public interface IPriceCalculator
    {
        int CalculateTotalPrice(IEnumerable<IProduct> products);
    }

    public class Product : IProduct
    {
        public string Name { get; private set; }
        public string Category { get; private set; }
        public int PriceInPence { get; private set; }

        public Product(string name, string category, int priceInPence)
        {
            Name = name;
            Category = category;
            PriceInPence = priceInPence;
        }

        public override string ToString()
        {
            return Name;
        }
    }

    public class SimplePriceCalculator : IPriceCalculator
    {
        public int CalculateTotalPrice(IEnumerable<IProduct> products)
        {
            return products.Sum(p => p.PriceInPence);
        }
    }

    public class Checkout
    {
        private readonly IPriceCalculator _priceCalculator;
        private readonly List<IProduct> _scannedItems;

        public Checkout(IPriceCalculator priceCalculator)
        {
            _priceCalculator = priceCalculator;
            _scannedItems = new List<IProduct>();
        }

        public void Scan(IProduct product)
        {
            _scannedItems.Add(product);
        }

        public int GetTotalPriceInPence()
        {
            return _priceCalculator.CalculateTotalPrice(_scannedItems);
        }

        public List<IProduct> GetScannedItems()
        {
            return _scannedItems;
        }
    }
}
