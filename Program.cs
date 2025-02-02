namespace LINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
