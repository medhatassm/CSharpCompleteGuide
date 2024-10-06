using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvancedOOP.Classes
{
    // Can't make instant of static class.
    // Static Class ===> Utilitys for use in code not to store data.
    public static class Family
    {
        public static string? FatherName;
        public static string? MotherName;

        public static bool HasFamily()
        {
            if (!string.IsNullOrEmpty(FatherName) && !string.IsNullOrEmpty(MotherName))
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    // Static Faild into Non-Static Class

    public class Vichel
    {
        // Shared State
        public static int NumberOfCalls = 0;

        public Vichel() // Constructor
        {
            System.Console.WriteLine("Normal Constructor Called");
            NumberOfCalls++;
        }

        // Call with first Instant only (one time only).
        // Access static members (faild , method) make static constructer called (first members only).
        static Vichel()
        {
            Console.WriteLine("Static Constructor Called");
        }

        public static void Drive()
        {
            Console.WriteLine(NumberOfCalls);
        }
    }
}
