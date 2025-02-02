using static LINQ.ListGenerator;
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

        //  var employee = new {  Id = 1 , Name = "Basseem" , salary = 9_000};
        //
        //  // the object that will be created from "anonymoustype" => is an imutable object  [ cant be changed]
        //
        //  employee = employee with { Id = 21 }; // syntax Sugar [ C# 10.0 ]
        //
        //  Console.WriteLine(employee.Id);
        //  int x = 10;
        //  Console.WriteLine(x.GetType().Name);
        //
        //  var employee02 = new { Id = 2, Name = "khaled", salary = 5_666 };
        //
        //  // the same AnonymousType As Long As:
        //  /// 1. the same properties Naming [case Sensitive]
        //  /// 2. the properties Oreder
        //  
        //  Console.WriteLine(employee.GetType().Name);
        //
        //
        //  var product = new { productName = "Chease", productPrice = 100 };
        //
        //  Console.WriteLine(product.GetType().Name);
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

            #region What is LINQ
            // LINQ : Stands for LAnguage_Integrated Query { C# 3.0 Feature }
            // LINQ :  +40 Extension Methods for the Built_in Interface "IEnumerable"
            //      :  Named As " LINQ Operators " Existed At Class Enumerable"
            //      :  Categoriezed int 13 Category 

            //  Use LINQ Operators Againest Data , Regardeless its Data Store ( File , DataBase Provider { SQL Server , Oracle , MySQL , and Etc .... )
            // Sequence : it an Object From Class Implemeting the built_in Interface " IEnumerable" Like List , HashSet , Dictionary , ArrayList , and Etc ...

            // 1. Local  Sequence : L20 L2XML
            // 2. Remote Sequence : L2EF

            // List<int> Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
            //
            // List<int> OddNumbers = Numbers.Where((N) => % 2 == 1 ).ToList();
            //
            // Numbers.AddRange([11, 12, 13, 14, 15]);
            //
            //
            // foreach(int odd in OddNumbers)
            //     Console.WriteLine(odd);
            #endregion

            #region LINQ Syntax

            //   List<int> Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            #region 1. Fluent Syntax

            /// 1. Fluent Syntax
            /// 1.1 Call "LINQ Operators" as => Static Method Through The " Enumerable" Class
            /// 
            //  var Odds = Enumerable.Where(Numbers, (N) => N % 2 == 1);

            /// 1.2 Call"LINQ Operators" as => Extension Method [recommended}
            #endregion
            #region 1. Query Sytnax [Query Expression]

            //2. Query Syntax [ Query Expression] : Like => SQLServer Style

            /*
             * Select N
             * From Numbers N
             * Where N % 2 = 1
             * 
             */

            //   var Odds = from N in Numbers
            //              where N % 2 == 1
            //              select N; 
            #endregion
            //  foreach(int odd in Odds)
            //      Console.WriteLine(odd);
            #endregion

            #region LINQ Introduction
            #region 1. Differed Executiom
            // 1. Differed Execution ( LAstest Version of Data)

            //  List<int> Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
            //
            //  var Result = Numbers.Where((N) => N % 2 == 1 );
            //
            //  Numbers.AddRange([11, 12, 13, 15]);
            //
            //  foreach( var number in Numbers )
            //      Console.WriteLine(number);
            #endregion

            #region 2. Immediate Execution

            // IMMEDIATE eXECUTION ( eLEMENT oPERATORS , cASTING oPERATORS , aGGERAGATE oPEARTORS  )

          //  List<int> Numbers = [1, 2, 3, 4, 5, 6, 7, 8, 9];
          //
          //  var Result = Numbers.Where((N) => N % 2 == 1).ToList(); // 1, 3 , 4 ,7 ,9
          //
          //  Numbers.AddRange([11, 12, 13, 15]);
          //
          //  foreach (var odd in Result)
          //      Console.WriteLine(odd);
            #endregion
            #endregion

            Console.WriteLine(ListGenerator.ProductList[10]);

        }
    }
}
