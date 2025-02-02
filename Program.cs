using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Intrinsics.X86;
using System.Text.RegularExpressions;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

            #region Q .6 \ .7 Use ListGenerators.cs & Customers.xml
            //   6.Sort a list of products, first by category, and then by unit price, from highest to lowest.
            //   7.Sort first by word length and then by a case -insensitive descending sort of the words in an array.
            //   string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };



            //   var sortedProducts = from product in ListGenerator.ProductList
            //                        orderby product.Category, product.UnitPrice descending
            //                        select new { product.Category, product.ProductName, product.UnitPrice };
            //
            //   Console.WriteLine("Products sorted by category, then by unit price (highest to lowest):");
            //   foreach (var product in sortedProducts)
            //   {
            //       Console.WriteLine($"{product.Category} - {product.ProductName} - ${product.UnitPrice}");
            //   }
            //
            //
            //   string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //
            //   var sortedWords = from word in Arr
            //                     orderby word.Length, word.ToLower() descending
            //                     select word;
            //
            //   Console.WriteLine("\nWords sorted by length, then case-insensitively in descending order:");
            //   foreach (var word in sortedWords)
            //   {
            //       Console.WriteLine(word);
            //   }





            #endregion

            #region Q 8. Create a list of all digits in the array whose second letter is 'i' that is reversed from the order in the original array.
            // string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };


            //  string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //
            //  var filteredReversedDigits = (from word in Arr
            //                                where word.Length > 1 && word[1] == 'i'
            //                                select word).Reverse();
            //
            //  Console.WriteLine("Digits whose second letter is 'i', reversed order:");
            //  foreach (var word in filteredReversedDigits)
            //  {
            //      Console.WriteLine(word);
            //  }
            //


            #endregion

            #region Q 1. 2. LINQ – Transformation Operators

            // Use ListGenerators.cs & Customers.xml
            // 1.Return a sequence of just the names of a list of products.                                                           2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //  string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //2.Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).



            //  var productNames = from product in ListGenerator.ProductList
            //                     select product.ProductName;
            //
            //  Console.WriteLine("Product Names:");
            //  foreach (var name in productNames)
            //  {
            //      Console.WriteLine(name);
            //  }
            //
            //  string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //
            //  var wordTransformations = from word in words
            //                            select new
            //                            {
            //                                Upper = word.ToUpper(),
            //                                Lower = word.ToLower()
            //                            };
            //
            //  Console.WriteLine("\nUppercase and Lowercase versions of words:");
            //  foreach (var word in wordTransformations)
            //  {
            //      Console.WriteLine($"Upper: {word.Upper}, Lower: {word.Lower}");
            //  }


            #endregion

            #region Q.3 4. Use ListGenerators.cs & Customers.xml
            //3.Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //4.Determine if the value of ints in an array match their position in the array.
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };


            //      var productInfo = from product in ListGenerator.ProductList
            //                        select new
            //                        {
            //                            product.ProductName,
            //                            Price = product.UnitPrice, 
            //                            product.Category
            //                        };
            //
            //      Console.WriteLine("Product Info:");
            //      foreach (var product in productInfo)
            //      {
            //          Console.WriteLine($"Name: {product.ProductName}, Price: {product.Price}, Category: {product.Category}");
            //      }
            //
            //
            //
            //      int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //
            //      var numberMatch = from index in Enumerable.Range(0, Arr.Length)
            //                        select new
            //                        {
            //                            Number = Arr[index],
            //                            InPlace = Arr[index] == index
            //                        };
            //
            //      Console.WriteLine("\nNumber: In-place?");
            //      foreach (var item in numberMatch)
            //      {
            //          Console.WriteLine($"{item.Number}: {item.InPlace}");
            //      }



            #endregion

            #region Q 5.Returns all pairs of numbers from both arrays such that the number from numbersA is less than the number from numbersB.
            //  int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //  int[] numbersB = { 1, 3, 5, 7, 8 };




                //  int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
                //  int[] numbersB = { 1, 3, 5, 7, 8 };
                //
                //
                //
                //  var pairsQuery =
                //      from a in numbersA
                //      from b in numbersB
                //      where a < b
                //      select new { A = a, B = b };
                //
        



            #endregion

            #region Q 6. 7. Use ListGenerators.cs & Customers.xml
            // 6.Select all orders where the order total is less than 500.00.
            //    7.Select all orders where the order was made in 1998 or later.


            //  var ordersUnder500 = Orders.Where(order => order.OrderTotal < 500.00m);
            //
            //
            //  var ordersFrom1998Query =
            //      from order in orders
            //      where order.OrderDate.Year >= 1998
            //      select order;
            //
            #endregion
        }


    }
    }
