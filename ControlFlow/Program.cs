namespace ControlFlow
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Conditional Statements
            /// specify a block of C# code to be executed if a condition is true

            // if statement or switch statement

            int x = 10, y = 20;
            if (x < y)
            {
                Console.WriteLine($"x:{x} is less than y:{y}");
            }
            else if (x == y)
            {
                Console.WriteLine($"x:{x} is equal y:{y}");
            }
            else
            {
                Console.WriteLine($"x:{x} is grater than y:{y}");
            }

            // Switch Statement
            switch (x)
            {
                case 2:
                    Console.WriteLine("x = 2");
                    break;
                case 5:
                    Console.WriteLine("x = 5");
                    break;
                case 10:
                    Console.WriteLine("x = 10");
                    break;
                default:
                    {
                        Console.WriteLine("No Conditon Role Success");
                        break;
                    }

            }

            #endregion

            #region Loop Statement

            /// For Loop: When you know exactly how many times you want to loop through a block of code.
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine(i);
            }

            int j = 10;

            /// While Loop: Loops can executed a block of code. as long as a specified condition is true.
            while (j != 0)
            {
                Console.WriteLine(j);
                j--;
            }

            /// Do While Loop: This loop will execute the code block once, before checking if condition is true or not.
            do
            {
                Console.WriteLine(2);
            } while (3 > 4); // This condition is false but do will print 'd' variable once


            #endregion

        }
    }
}