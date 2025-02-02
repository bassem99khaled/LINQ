using System.Runtime.ConstrainedExecution;
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

        #region

        #endregion


        #region


        #endregion



        #region



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
