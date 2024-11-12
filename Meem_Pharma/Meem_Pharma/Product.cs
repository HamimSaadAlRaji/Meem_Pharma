using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace Meem_Pharma
{
    public class Product
    {
        public string BrandName { get; set; }
        public string DosageForm { get; set; }
        public string Generic { get; set; }
        public string Strength { get; set; }
        public string Manufacture { get; set; }
        public string PackageContainer { get; set; }
        public decimal Price { get; set; }

        public List<Product> ReadCsvFile(string filePath)
        {
            List<Product> products = new List<Product>();

            // Read all lines from the CSV file
            var lines = File.ReadAllLines(filePath);

            // Skip the header line
            foreach (var line in lines.Skip(1))
            {
                var values = line.Split(',');

                // Ensure there are enough columns to avoid IndexOutOfRangeException
                if (values.Length < 10)
                    continue;

                // Attempt to clean and parse the price
                string priceString = values[4].Trim(); // Get the price column
                decimal price = 0m;  // Default value

                try
                {
                    // If the price string contains commas, replace them with periods (if needed)
                    priceString = priceString.Replace(",", ".");

                    // Remove any currency symbols or other non-numeric characters
                    priceString = new string(priceString.Where(c => Char.IsDigit(c) || c == '.').ToArray());

                    // Try to parse the price string
                    price = Convert.ToDecimal(priceString);
                }
                catch (FormatException)
                {
                    // Handle the case where the price format is invalid
                    Console.WriteLine($"Invalid price format: {priceString}");
                    continue; // Skip this product or handle the error as needed
                }

                // Create a new Product object and populate its properties
                var product = new Product
                {
                    BrandName = values[6],
                    DosageForm = values[7],
                    Generic = values[1],
                    Strength = values[2],
                    Manufacture = values[5],
                    PackageContainer = values[3],
                    Price = price
                };

                products.Add(product);
            }

            return products;
        }

    }
}
