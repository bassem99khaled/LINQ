namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Featrues Need To Be Known Before LINQ

            #region Implicitly Typed Local Variable


            #region Var

            // var : is a C# Keyword { C# 3.0 Feature ]

            // var Name = "Bassem";

            // Compiler Can Detect the type of Variable DataType Based on its Initial Value at Compilation Time
            // Must Be Initialized
            // Can't Be Initlaized With Null ;
            // After Inilization , U cant't Change the Variable DataType


            #endregion

            #region dynamic

            // Dynamic : is a C# Keyward { C# 4.0 }

            // dynamic data;

            /// Compiler will Skip type checking at Compilation Time ;
            /// CLR will Resolve the actual type of a DynamicType Variable at Run Time and will be changed Based on tje assigned Value,
            /// Does not need to be Intialized
            /// Can Be inilaized With Null
            /// After Intiailziation U can Change its DataType

            #endregion



            #endregion

            #region AnonymousType

            var employee = new {  Id = 1 , Name = "Basseem" , salary = 9_000};

            // the object that will be created from "anonymoustype" => is an imutable object  [ cant be changed]

            employee = employee with { Id = 21 }; // syntax Sugar [ C# 10.0 ]

            Console.WriteLine(employee.Id);
            int x = 10;
            Console.WriteLine(x.GetType().Name);

            var employee02 = new { Id = 2, Name = "khaled", salary = 5_666 };

            // the same AnonymousType As Long As:
            /// 1. the same properties Naming [case Sensitive]
            /// 2. the properties Oreder
            
            Console.WriteLine(employee.GetType().Name);


            var product = new { productName = "Chease", productPrice = 100 };

            Console.WriteLine(product.GetType().Name);
            #endregion

            #region Extension Method

            //  int X = 12345;
            //
            //  int Y = IntExtensions.Reverse(X);
            //
            //  Y = X.Reverse();
            //
            //  Console.WriteLine(Y);

            #endregion

            #endregion
        }
    }
}
