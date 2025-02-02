using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Xml.Linq;

namespace LINQ
{
    internal class Program
    {
       

        static void Main(string[] args)
        {
            #region Q.1 Use ListGenerators.cs & Customers.xml
            //   1.Find all products that are out of stock.
            //  2.Find all products that are in stock and cost more than 3.00 per unit.
            //  3.Returns digits whose name is shorter than their value.




            //      List<Product> products = ListGenerators.GetProducts();
            //
            //    
            //      var outOfStockProducts = products.Where(p => p.UnitsInStock == 0);
            //      Console.WriteLine("Products out of stock:");
            //      foreach (var product in outOfStockProducts)
            //      {
            //          Console.WriteLine(product.ProductName);
            //      }
            //
            //    
            //
            //      var expensiveInStockProducts = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00m);
            //      Console.WriteLine("\nIn-stock products costing more than $3.00:");
            //      foreach (var product in expensiveInStockProducts)
            //      {
            //          Console.WriteLine(product.ProductName);
            //      }
            //
            //      Dictionary<int, string> digitNames = new Dictionary<int, string>
            //      {
            //  { 1, "One" }, { 2, "Two" }, { 3, "Three" }, { 4, "Four" },
            //  { 5, "Five" }, { 6, "Six" }, { 7, "Seven" }, { 8, "Eight" }, { 9, "Nine" }
            //        };
            //
            //      var shortNamedDigits = digitNames.Where(d => d.Value.Length < d.Key);
            //      Console.WriteLine("Digits whose name is shorter than their value:");
            //      foreach (var digit in shortNamedDigits)
            //      {
            //          Console.WriteLine(digit.Value);
            //      }





            #endregion

            #region Q .2 LINQ - Ordering Operators

            // Use ListGenerators.cs & Customers.xml
            // 1.Sort a list of products by name
            // 2.Uses a custom comparer to do a case -insensitive sort of the words in an array.



            //     var sortedProducts = ListGenerator.ProductList
            //         .OrderBy(p => p.ProductName)
            //         .Select(p => p.ProductName);
            //
            //     Console.WriteLine("Products sorted by name:");
            //     foreach (var product in sortedProducts)
            //     {
            //         Console.WriteLine(product);
            //     }
            //
            //     string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //
            //     var sortedWords = Arr.OrderBy(word => word, StringComparer.OrdinalIgnoreCase);
            //
            //     Console.WriteLine("Words sorted case-insensitively:");
            //     foreach (var word in sortedWords)
            //     {
            //         Console.WriteLine(word);
            //     }






            #endregion


            #region Q .3\.4 Use ListGenerators.cs & Customers.xml
            //  3.Sort a list of products by units in stock from highest to lowest.
            //  4.Sort a list of digits, first by length of their name, and then alphabetically by the name itself.
            //  string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };



            //      var sortedByStock = ListGenerator.ProductList
            //          .OrderByDescending(p => p.UnitsInStock)
            //          .Select(p => new { p.ProductName, p.UnitsInStock });
            //
            //      Console.WriteLine("Products sorted by units in stock (highest to lowest):");
            //      foreach (var product in sortedByStock)
            //      {
            //          Console.WriteLine($"{product.ProductName} - {product.UnitsInStock} units");
            //      }
            //
            //      
            //      string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //
            //      var sortedDigits = Arr.OrderBy(word => word.Length).ThenBy(word => word);
            //
            //      Console.WriteLine("\nDigits sorted by length and then alphabetically:");
            //      foreach (var word in sortedDigits)
            //      {
            //          Console.WriteLine(word);
            //      }


            #endregion



            #region Q .5 Sort first by word length and then by a case-insensitive sort of the words in an array.

            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };


       
        //       string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //
        // 
        //       var sortedWords = from word in words
        //                         orderby word.Length, word.ToLower()
        //                         select word;
        //
        //       Console.WriteLine("Words sorted by length and then case-insensitively:");
        //       foreach (var word in sortedWords)
        //       {
        //           Console.WriteLine(word);
        //       }
            




    #endregion


    #region



    #endregion


    #region


    #endregion



}

private class ListGenerators
        {
            internal static List<Product> GetProducts()
            {
                throw new NotImplementedException();
            }
        }
    }
    }
