namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetName());
            Console.WriteLine(GetSum());

            // Passing Argument to Function
            GetMyName("Medhat");

            //Dynamic Parameters
            Equation(5, 4, 3, 8, 9, 10, 2); // 41

            //Named Arguments
            GetText(text1: "Hello", text2: "Welcome to C# Guide");

            //Optional Parameters
            Sum(4); // 4 + 5 = 9
            Sum(4, 2); // 4 + 2 = 6

            //Reference Parameters
            string Name = "Ahmed";
            bool isActive = true;
            StudentInfo(ref Name, ref isActive);
            Console.WriteLine(Name + "\n" + isActive); // Name = Medhat , isAtive = true

            //Inner Method
            bool isEnrolled = false;
            Enroll(isEnrolled);

            //Outer Method
            string name = "Mostafa";
            bool isactive = false;
            Studentinfo(out name, out isactive);
            Console.WriteLine(name + "\n" + isactive); // Name = Medhat , isAtive = true
        }



        #region Create Function

        /// <summary>
        ///  Using Static keyword here becuse we in Entery point of project (main class)
        /// </summary>
        /// 
        /// Void mean retrun Nothing.
        public static void MethodName()
        {
            // Block of Code
        }

        #endregion

        #region Types of return

        // Return string
        public static string GetName()
        {
            return "My Name";
        }

        // Return Integer
        public static int GetSum()
        {
            return 1 + 2;
        }

        #endregion

        #region Parameters (Arguments)

        // Function With Parameter
        public static string GetMyName(string myName)
        {
            return myName;
        }

        // Dynamic Parameters
        public static int Equation(int x, int y, params int[] arr)
        {
            int total = 0;
            foreach (int i in arr)
            {
                total += i;
            }

            return x + y + total;
        }

        #endregion

        #region Named Parameters

        public static string GetText(string text1, string text2)
        {
            return text1 + "\n" + text2;
        }

        #endregion

        #region Optional Paramenters

        public static int Sum(int x, int y = 5)
        {
            return x + y;
        }

        #endregion

        #region Reference Parameters

        public static void StudentInfo(ref string Name, ref bool isActive)
        {
            Name = "Medhat";
        }
        #endregion

        #region Inner Method

        public static void Enroll(in bool isEnrolled)
        {
            // Syntax Error That Variable Can't modify
            // inside method because its inner parameter
            // isEnrolled = true;
        }

        #endregion

        #region Outter Method
        public static void Studentinfo(out string Name, out bool isAvtive)
        {
            Name = "Ali";
            isAvtive = true;
        }
        #endregion
    }
}