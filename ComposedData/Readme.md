## Composed Data

### Arrays

- **Array Definition**
    - Array
        
        its reference datatype, used to store multiple values in a single variables, instead of declaring separate variables for each value.
        
    - To declare array
    
    ```csharp
    string[] arr = new string[];
    ```
    
    - To initialize value to array
    
    ```csharp
    // First Way:
    string[] arrOfName = { "Ahmed", "Medhat", "Samier" };
    
    // Second Way:
    string[] arr = new string[];
    stringArr[0] = "Medhat";
    stringArr[1] = "Samier";
    ```
    
    - Get array value
        - Get single value
        
        ```csharp
        stringArr[0] = "Medhat";
        stringArr[1] = "Samier";
        
        Console.WriteLine(stringArr[0]);
        Console.WriteLine(stringArr[1]);
        ```
        
        - Get all array data **(Using Foreach)**
        
        ```csharp
        string[] arrOfName = { "Ahmed", "Medhat", "Samier" };
        
        foreach (var item in arrOfName)
        {
            Console.WriteLine(item);
        }
        ```
        
        - Get all array data **(Using Index)**
        
        ```csharp
        string[] arrOfName = { "Ahmed", "Medhat", "Samier" };
        
        for (int i = 0; i < arrOfName.Length; i++)
        {
            Console.WriteLine(arrOfName[i]);
        }
        
        ```
        

---

- **Array Methods**
    - Array sorting
        
        sorts an array alphabetically or in an ascending order.
        
        ```csharp
        // Sort a string
        string[] cars = {"Volvo", "BMW", "Ford", "Mazda"};
        Array.Sort(cars);
        foreach (string i in cars)
        {
          Console.WriteLine(i);
        }
        
        // Sort an int
        int[] myNumbers = {5, 1, 8, 9};
        Array.Sort(myNumbers);
        foreach (int i in myNumbers)
        {
          Console.WriteLine(i);
        }
        ```
        
    - Array reversal
        
        reverses the sequence of a subset of the elements in a one-dimensional array.
        
        ```csharp
        string[] spamLetters = {"S", "P", "A", "M"};
        
        Array.Reverse(spamLetters);
        ```
        
    - Array clearing
        
        used to clear the contents of an array, returning each element to its default value.
        
        ```csharp
        int[] myArray = {0, 1, 2, 3, 4};
        
        Array.Clear(myArray, 0, myArray.Length);
        ```
        
    - Array IndexOf
        
        searches for the specified object and returns the index of the first occurrence within the entire one-dimensional Array.
        
        ```csharp
        int[] arr = { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 };
        
        int a = Array.IndexOf(arr, 800);
        ```
        

---

- **2 Dimensional Array**
    
    if you want to store data as a tabular form, like a table with rows and columns, you need to get familiar with **multidimensional arrays**.
    
    > Array can have any number of dimensions. the most common are two-dimensional array (2D)
    > 
    - Create 2D Array
    
    ```csharp
    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
    ```
    
    |  | Column 0 | Column 1 | Column 2 |
    | --- | --- | --- | --- |
    | Row 0 | 1 | 4 | 2 |
    | Row 1 | 3 | 6 | 8 |
    - 2D Array Access Element
    
    ```csharp
    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
    Console.WriteLine(numbers[0, 2]);  // Outputs 2
    ```
    
    - 2D Array Change Elements
    
    ```csharp
    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
    numbers[0, 0] = 5;  // Change value to 5
    Console.WriteLine(numbers[0, 0]); // Outputs 5 instead of 1
    ```
    
    - Loop Through a 2D Array
    
    ```csharp
    int[,] numbers = { {1, 4, 2}, {3, 6, 8} };
    
    for (int i = 0; i < numbers.GetLength(0); i++) 
    { 
      for (int j = 0; j < numbers.GetLength(1); j++) 
      { 
        Console.WriteLine(numbers[i, j]); 
      } 
    }
    ```
    

---

### Lists

- **Lists Definition**
    
    to create a collection of different types like integers, strings etc. List<T> class also provides the methods to search, sort, and manipulate lists.
    
    > It is different from the arrays. A **List<T> can be resized dynamically**, can accept null as valid value for reference type, also allows duplicate element.
    > 
- **Declaring And Get List**
    
    ```csharp
    List<int> firstlist = new List<int>() { 1, 2, 3, 4 };
    
    firstlist.Add(5);
    firstlist.Add(6);
    firstlist.Add(7);
    
    foreach (var i in firstlist)
    {
        Console.WriteLine(i);
    }
    ```
    
- **Lists Methods**

| Method | Definition | Example |
| --- | --- | --- |
| Capacity | Gets or sets the total number of elements the internal data structure can hold without resizing. | `Console.WriteLine("Capacity Is: " + firstlist.Capacity);` |
| Count | Gets the number of elements contained in the List<T>. | `Console.WriteLine("Count Is: " + firstlist.Count);` |
| Sort | Sorts the elements or a portion of the elements in the List<T> using either the specified or default IComparer<T> implementation or a provided Comparison<T> delegate to compare list elements. | `firstlist.Sort();` |
| Reverse | Reverses the order of the elements in the List<T> or a portion of it. | `firstlist.Reverse();` |
| listName[index] | Gets or sets the element at the specified index. | `Console.WriteLine("Item Is:" + firstlist[2]);` |
| Add | Adds an object to the end of the List<T>. | `firstlist.Add(6);` |
| AddRange | Adds the elements of the specified collection to the end of the List<T>. | `firstlist.AddRange(firstlist);` 
 |
| AsReadOnly | Returns a read-only ReadOnlyCollection<T> wrapper for the current collection. | `IList<**int**> readlist = firstlist.AsReadOnly();` |
| BinarySearch | Uses a binary search algorithm to locate a specific element in the sorted List<T> or a portion of it. | `int index = firstlist.BinarySearch(7);
Console.WriteLine(index);` |
| Clear | Removes all elements from the List<T>. | `firstlist.Clear();` |
| Contains | Determines whether an element is in the List<T>. | `bool isContain = firstlist.Contains(4));` |

---

### Dictionary

used to store key/value pairs, the advantage of Dictionary is, it is generic type, it is dynamic in nature means the size of the dictionary is growing according to the need.

> its like lists but you have unique key to each element so you can’t access element without this key
> 
- **Declaring Dictionary**
    
    ```csharp
    Dictionary<int, string> dictionary = new Dictionary<int, string>(){
    {1,"Medhat"} ,
    {2, "Ahmed"}
    };
    ```
    
- **Get Dictionary value**
    - Get single element
        
        ```csharp
         Dictionary<int, string> dictionary = new Dictionary<int, string>(){
        {1,"Medhat"} ,
        {2, "Ahmed"}
        };
        
         Console.WriteLine(dictionary[1]); //[Key] not index
        ```
        
    - Get all data in dictionary
        
        ```csharp
        Dictionary<int, string> dictionary = new Dictionary<int, string>(){
        {1,"Medhat"} ,
        {2, "Ahmed"}
        };
        
        foreach (KeyValuePair<int, string> item in dictionary)
        {
            Console.WriteLine(item.Key);
            Console.WriteLine(item.Value);
        }
        ```