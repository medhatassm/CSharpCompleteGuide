## Functions (Methods)

### Functions Definitions And Types

is a block of code which only runs when its called, can return any datatype you want, used to perform certain actions and to reuse code **(define the code once, use it many time).**

- **Create Function**
    
    ```csharp
    ///  Using Static keyword here becuse we in Entery point of project (main class)
    /// 
    /// Void mean retrun Nothing.
    public static void MethodName()
    {
        // Block of Code
    }
    ```
    
- **Types of return**
    
    Can be any datatype.
    
    ```csharp
    // Main Method (Entery Point)
    static void Main(string[] args)
    {
    		// Call Methods
        Console.WriteLine(GetName()); // My Name
        Console.WriteLine(GetSum());  // 3
    }
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
    
    ```
    

---

### **Parameters (Arguments)**

you can pass data, know as arguments, into method and used it in your code of function.

> Parameters call to variables that declaring in method like this `(string name, int age)` , Arguments call to variables that passing to method like this `MyMethod(MyName,MyAge)` , its not a big different and call it whatever you want but just in case you need to know the different of naming.
> 

```csharp
static void Main(string[] args)
{
		// Passing Argument to Function
    GetMyName("Medhat");
}
// Function With Parameter
public static string GetMyName(string myName)
{
    return myName;
}
```

> You can make **(user / developer)** add dynamic length of parameter as array so make function take as many as argument it want .
> 
> 
> ```csharp
> static void Main(string[] args)
> {
> 		Equation(5 , 4 , 3 , 8, 9 , 10 , 2); // 41
> }
> 
> // Dynamic Parameters
> public static int Equation(int x, int y, params int[] arr)
> {
>     int total = 0;
>     foreach (int i in arr)
>     {
>         total += i;
>     }
> 
>     return x + y + total;
> }
> ```
> 

---

- **Named Parameters**
    
    You can path value to function using the name of variable not order in method.
    
    ```csharp
    static void Main(string[] args)
    {
        //Named Arguments
        GetText(text1: "Hello", text2: "Welcome to C# Guide");
    }
    
    public static string GetText(string text1, string text2)
    {
        return text1 + "\n" + text2;
    }
    ```
    
    ---
    
- **Optional Parameters**
    
    you can use optional parameters by initialize variable while define it, and that make this parameter is optional, if (developer / user) not (insert / initialize) it with any value, it will use the default value of it.
    
    ```csharp
    static void Main(string[] args)
    {
        //Optional Parameters
        Sum(4); // 4 + 5 = 9
        Sum(4 , 2); // 4 + 2 = 6
    }
    
    public static int Sum(int x, int y = 5)
    {
        return x + y;
    }
    ```
    
    ---
    
- **Reference Parameters**
    
    `ref` is used to state that the parameter passed my be modified y the method.
    
    ```csharp
    static void Main(string[] args)
    {
    		//Reference Parameters
        string Name = "Ahmed";
        bool isActive = true;
        StudentInfo(ref Name , ref isActive);
        Console.WriteLine(Name + "\n" + isActive); // Name = Medhat , isAtive = true
    }
    ```
    
    > Reference Parameter is tell the compiler that variable using inside the method i will use it outside the method.
    > 
    
    ---
    
- **Inner Parameters**
    
    `in` is used to state that the parameters passed can’t modified by the method.
    
    ```csharp
    static void Main(string[] args)
    {
        //Inner Method
        bool isEnrolled = false;
        Enroll(isEnrolled);
    }
    
    public static void Enroll(in bool isEnrolled)
    {
        // Syntax Error That Variable Can't modify
        // inside method because its inner parameter
        // isEnrolled = true;
    }
    ```
    
    ---
    
- **Outer Parameters**
    
    `out` is used to state that the parameter passed must be modified by method, sam as reference but can’t leave variable without modify it in method.
    
    ```csharp
    static void Main(string[] args)
    {
        //Outer Method
        string name = "Mostafa";
        bool isactive = false;
        Studentinfo(out name, out isactive);
        Console.WriteLine(name + "\n" + isactive); // name = Ali , isactive = true
    }
    
    public static void Studentinfo(out string Name, out bool isAvtive)
    {
        Name = "Ali";
        isAvtive = true;
    }
    ```