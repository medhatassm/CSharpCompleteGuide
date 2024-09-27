namespace ComposedData
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Array

            #region Get Start With Array

            // Declare
            string[] stringArr = new string[3];

            // Initialize Value to Array

            // First Way:
            string[] arrOfName = { "Ahmed", "Medhat", "Samier" };
            // Second Way:
            stringArr[0] = "Medhat";
            stringArr[1] = "Samier";

            // Get Array Value

            //Get Single Value
            Console.WriteLine(stringArr[0]);
            Console.WriteLine(stringArr[1]);

            // Get All Data
            foreach (var item in arrOfName)
            {
                Console.WriteLine(item);
            }

            // Get All Data using index
            for (int i = 0; i < arrOfName.Length; i++)
            {
                Console.WriteLine(arrOfName[i]);
            }

            #endregion

            #region Array Methos

            // Sorting

            // Sort a string
            string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };
            Array.Sort(cars);
            foreach (string i in cars)
            {
                Console.WriteLine(i);
            }

            // Sort an int
            int[] myNumbers = { 5, 1, 8, 9 };
            Array.Sort(myNumbers);
            foreach (int i in myNumbers)
            {
                Console.WriteLine(i);
            }

            // Reverse
            string[] spamLetters = { "S", "P", "A", "M" };

            Array.Reverse(spamLetters);

            // Clearing
            int[] myArray = { 0, 1, 2, 3, 4 };

            Array.Clear(myArray, 0, myArray.Length);

            // IndexOf
            int[] arr = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };

            int a = Array.IndexOf(arr, 800);

            #endregion

            #region 2D Array 

            /// if you want to store data as a tabular form,
            /// like a table with rows and columns, you need to get
            /// familiar with multidimensional arrays.

            // Create 2D Array
            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            // Access Element in 2D array
            Console.WriteLine(numbers[0, 2]);  // Outputs 2

            // 2D Array Change Elements
            numbers[0, 0] = 5;  // Change value to 5
            Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1

            //Loop Through a 2D Array
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            #endregion

            #endregion

            #region Lists

            #region Lists Definition
            /// Lists is to create a collection of different types like integers,
            /// strings etc. List<T> class also provides the methods to search,
            /// sort, and manipulate lists.

            // Creating a List of integers
            List<int> firstlist = new List<int>() { 1, 2, 3, 4 };

            firstlist.Add(5);
            firstlist.Add(6);
            firstlist.Add(7);

            foreach (var i in firstlist)
            {
                Console.WriteLine(i);
            }

            #endregion

            #region  Lists Methods

            // Printing the Capacity of firstlist
            Console.WriteLine("Capacity Is: " + firstlist.Capacity);

            // Printing the Count of firstlist
            Console.WriteLine("Count Is: " + firstlist.Count);

            // Sort List
            firstlist.Sort();

            // Reverse List
            firstlist.Reverse();


            //Gets or sets the element at the specified index.
            Console.WriteLine("Item Is:" + firstlist[2]);

            //Add Range
            firstlist.AddRange(firstlist);

            foreach (var i in firstlist)
            {
                Console.WriteLine(i);
            }

            //Read Only
            IList<int> readlist = firstlist.AsReadOnly();

            //Binary Search
            int index = firstlist.BinarySearch(7);
            Console.WriteLine(index); //if element not in the list it will return nagative number;

            //Clear
            firstlist.Clear();

            //Contains
            Console.WriteLine(firstlist.Contains(9));

            #endregion

            #endregion

            #region  Dictionary

            // Declaring And Initilize 
            Dictionary<int, string> dictionary = new Dictionary<int, string>(){
            {1,"Medhat"} ,
            {2, "Ahmed"}
            };

            Console.WriteLine(dictionary[1]); //[Key] not index

            // Get Dictionary Value
            foreach (KeyValuePair<int, string> item in dictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            #endregion

        }
    }
}