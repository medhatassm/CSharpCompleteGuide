namespace VariablesAndDatatype
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Declaring Variables

            // type variableName = value;
            string Name = "Medhat";
            Console.WriteLine(Name);

            #endregion

            #region Type of Datatype

            /// Value Datatype: directly store the variable value in memory
            /// and it will also accept both signed and unsigned literals
            /// (int, float, char, double, decimal)
            /// Reference Datatype: contain a memory address of variable value
            /// because reference type won’t store the value directly in memory
            /// (string, object)

            int number = 10;
            double doubleNumber = 3123.3123d;
            float floatNumber = 32.41f;
            decimal decimalNumber = 321.413m;
            Console.WriteLine($"Numerical Datatype: {number} - {doubleNumber} - {floatNumber} - {decimalNumber}");
            string text = "someText";
            char character = 'L';
            Console.WriteLine($"Text Base Datatype: {text} - {character}");

            #endregion

            #region Type Casting

            /// Implicit Casting (Automatically): Convert a smaller type to a larger type size.

            // char -> int -> long -> float -> double
            int smallType = 20;
            double largeType = smallType; // Automatic Casting
            Console.WriteLine(largeType);

            /// Explicit Casting (Manually): Converting a larger type to a smaller size type

            // double -> float -> long -> int -> char
            double largerType = 40.32; // Convert it to int
            int smallerType;
            // Solution One
            smallerType = (int)largerType;
            // Solution Two
            smallerType = Convert.ToInt32(largerType);
            // Solution Three
            string textType = "10";
            int Number;
            if (int.TryParse(textType, out Number))
            {
                smallerType = Number; // assign the parsed value to smallerType
            }

            #endregion

            #region Mathematic Operator
            int x = 2, y = 5;
            // Addition
            x = x + y;
            // Subtraction
            x = y - x;
            // Division
            x = y / x;
            // Multiplication
            x = y * x;
            // Reminder
            x = y % x;
            // increment
            x++; // Get Value then Increment
            ++y; // increment then Get Value
            // Decrement
            x--; // Get Value then Decrement
            --y; // Decrement then Get Value

            /// Math Class: Have many methods that allows you to perform mathematical tasks on methods.

            Math.Max(5, 10); // The Math.Max(x,y) method can be used to find the highest value of x and y
            Math.Min(5, 10); // The Math.Min(x,y) method can be used to find the lowest value of of x and y
            Math.Sqrt(64); // The Math.Sqrt(x) method returns the square root of x
            Math.Abs(-4.7); // The Math.Abs(x) method returns the absolute (positive) value of x
            Math.Round(9.99); // Math.Round() rounds a number to the nearest whole number

            #endregion

            #region Keywords

            /// Keywords:  are the words in a language that are used for some internal process or represent some predefined actions.
            /// Var Keyword: is a keyword, it’s used to declare and implicit type variable, that specifies the type of variables based on initial value.
            var variable = "Text"; // variable is string
            var variable2 = 20; // variable is int
            /// Const Keyword: if you don’t want others (or yourself) to overwrite value, you can add the const keyword in front of the variable type.
            const float PI = 14.3f;
            //PI = 13.2; // Error Becuse you can't overwrite a constant value.

            #endregion
        }
    }
}