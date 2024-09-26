using System.Globalization;

namespace StringSyntax
{
    class Program
    {
        static void Main(string[] args)
        {
            #region String Concatentaion

            /// concatenate strings to each other use + symbol
            Console.WriteLine("My Name is" + " Medhat" + " Assem");

            #endregion

            #region  String formatting

            string Name = "Medhat";
            int Age = 25;

            /// use to path a value into string without concatenation symbol
            Console.WriteLine("Hello my name is {0} my age is {1}", Name, Age);

            #endregion

            #region Numeric Formating

            double Numeric = 81.0372771474878D;
            Console.WriteLine(string.Format("{0}", Numeric)); // Normal Formating
            Console.WriteLine(string.Format("{0:0.00}", Numeric)); // 81.04 (floor the number)
            Console.WriteLine(string.Format("{0:0.0}", Numeric)); // 81.0
            Console.WriteLine(string.Format("{0:0}", Numeric)); // 81
            Console.WriteLine(string.Format("{0:0.#}", Numeric)); // if # represent number equal to zero it will n't display

            /// Currency Format
            decimal money = 21.23M;

            Console.WriteLine(money.ToString("C")); // equal to "C0"
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));

            // CultureInfo Class
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-us")));

            #endregion

            #region  String Interpolation

            /// concatenate strings to each other use $ symbol


            Console.WriteLine($"My Name is {Name} and my age is {Age}");

            #endregion

            #region Verbatim string literal

            /// To indicate that string literal is to be interpreted verbatim

            Console.WriteLine(@"My Name is Medhat
            And my Age is 25
            Email: /* MedhatAssm@gmail.com */");

            #endregion

            #region String Methods

            // string.Empty
            if (Name == string.Empty)
            {

                // Block of Code

            }

            // string.Equals
            if (Name.Equals("Medht"))
            {

                // Block of code

            }

            // string.IsNullOrEmpty
            if (string.IsNullOrEmpty(Name))
            {

                // Block of code

            }
            #endregion

            #region String Iteration Looping

            string txt = "Hello My Name is Medhat Assem And this Simpal Task for iteration looping";

            for (int i = 0; i < txt.Length; i++)
            {
                Console.Write(txt[i]);
                Thread.Sleep(150); // That Line Make Compliler Puse For 150 Milisecound 
            }

            #endregion
        }
    }
}