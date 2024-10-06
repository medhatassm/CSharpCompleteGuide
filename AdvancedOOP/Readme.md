## Advanced OOP Keywords

### Interfaces

Another way to achieve abstraction in C#, is with interfaces.

An interface is a completely "**abstract class**", which can only contain abstract methods and properties (with empty bodies).

> It is considered good practice to start with the letter "I" at the beginning of an interface, as it makes it easier for yourself and others to remember that it is an interface and not a class.
> 

Abstract Class

```csharp
abstract class Shop 
{
    public abstract void Open();

    // Concrete
    public void Close()
    {
        Console.WriteLine("Shop Closing");
    }
}
```

Interface

```csharp
public interface IShop
{
		public void Open();
		public void Close();
}
```

- Interface Rules
    - you can’t set bodies to function in interface.
    - you have to implement all method you create in interface in base class (Parent).
    - you can inherit more than one interface to one class.
    - Interface members are by default abstract and public.
    - An interface cannot contain a constructor (as it cannot be used to create objects).
    - Interface can inherit from another interface (one or more).

```csharp
    public interface IShape
    {
        double CalculateArea();
    }

    public interface IColor
    {
        string GetColor();

        double CalculateArea();
    }
```

```csharp
 public class Rectangle : IShape, IColor
 {
     public double Length { get; set; }
     public double Width { get; set; }
     public double CalculateArea()
     {
         return Length * Width;
     }

     public string GetColor()
     {
         return "Red";
     }
 }
```

- Explicit interface implementation
    
    when you have multi interface that have same properties with same name, how you detected which interface you need to use it’s methods or fields and here come explicitly implementation.
    

```csharp
 public class Circle : IColorFulShape
 {
     public double Radius { get; set; }

     double IShape.CalculateArea()
     {
         return Radius * Radius * 3.14;
     }

     double IColor.CalculateArea()
     {
         return 0;
     }

     string IColor.GetColor()
     {
         return "Blue";
     }
 }
```

```csharp
    public interface IColorFulShape : IShape, IColor
    {

    }
```

```csharp
using AdvancedOOP.Classes;

Rectangle rectangle = new Rectangle();
rectangle.Length = 20.2;
rectangle.Width = 18.23;
rectangle.CalculateArea();
Circle circle = new Circle();
circle.Radius = 3.21;
IShape shape = circle;
Console.WriteLine(shape.CalculateArea());
IColor color = circle;
Console.WriteLine(color.CalculateArea());
```

---

### **Classes Other Type**

- **Structures**
    
    its value type whereas a class is reference type, more complex of simple type, and look exactly like class.
    
    - Create much more easily and quickly than heap type.
    - using structure it become easy to copy variables values into stack.
    
    ```csharp
        public struct Point
        {
            public int x { get; set; }
            public int y { get; set; }
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public void MovePoint()
            {
                x = x++;
            }
        }
    ```
    
    ```csharp
    Point p = new Point(2, 3);
    Console.WriteLine(p.x);
    p.MovePoint(); // x can't increment becuse structures is Value Type
    Console.WriteLine(p.x);
    ```
    
    ---
    
- **Enumeration**
    
    An `enum` is a special "class" that represents a group of **constants** (unchangeable/read-only variables).
    
    ```csharp
        enum DaysOfWeek
        {
            Monday = 2,
            Tuesday = 3,
            Wensday = 4,
            Thrusday = 5,
            Friday = 6,
            Satrday = 0,
            SunDay = 1
        }
    
        enum TraffecLight
        {
            Green = 1,
            Yellow = 2,
            Red = 3
        }
    ```
    
    ```csharp
    // Convert enum to int
    var m = (int)DaysOfWeek.Friday;
    Console.WriteLine(m);
    
    // Convert int to enum
    int x = 5;
    var z = (DaysOfWeek)x;
    Console.WriteLine(z);
    
    Console.Write("Enter The Light Number: ");
    int input = Convert.ToInt32(Console.ReadLine());
    
    var enumInput = (TraffecLight)input;
    
    switch (enumInput)
    {
        case TraffecLight.Red:
            {
                Console.WriteLine("Start");
                break;
            }
        case TraffecLight.Yellow:
            {
                Console.WriteLine("Prepare");
                break;
            }
        case TraffecLight.Green:
            {
                Console.WriteLine("Go");
                break;
            }
        default:
            {
                Console.WriteLine("Chose number between 1 - 3 in next time");
                break;
            }
    }
    ```
    

---

### Important Keywords

- **Static Keyword**
    
    ****is a modifier in C# which is applicable for the following:
    
    - Classes
    - Variables
    - Methods
    - Constructor
    
    its Utility for use in code not to store data, and can’t make instant of static class.
    
    ```csharp
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
    ```
    
    ```csharp
    Family.FatherName = "Ziad";
    Family.MotherName = "Ola";
    Console.WriteLine(Family.HasFamily());
    
    Vichel car = new Vichel();
    Vichel car2 = new Vichel();
    Vichel.NumberOfCalls = 5;
    Vichel.Drive();
    ```
    

---

- **NameSpace**
    
    Used to organize the classes. it helps to control the scope of methods and classes in larger projects.
    
    ```csharp
    namespace name_of_nameSpace
    {
    
        // Nested NameSpace
        namespace name_of_nestedNameSpace
        {
    
        }
    
        //Classes
        class class_name
        {
    
        }
    
        //Interfaces
        interface interface_name
        {
    
        }
    
        //Structures
        struct struct_name
        {
    
        }
    
        //Delegates
        delegate void delegate_name(); // Talk Bout it later
    
    }
    ```
    

---

### Files I/O Library

we have two class we can use to deal with files and each include into **Files I/O Library.**

- **Stream (Reader & Writer) class**
    
    stream is a wrapper or an abstract class that provides the required methods to read, write, and perform other relevant operations with bytes.
    
    - Stream Reader: is designed for character input in a particular encoding.
    - Stream Writer: is designed for output in a particular encoding.
    
    ```csharp
    // Read file with Stream Reader
    
    StreamReader stream = new StreamReader(@"/Users/medhat/Desktop/files/testFile.txt");
    string? Line = stream.ReadLine();
    string? Line2 = stream.ReadLine();
    
    string? line;
    while ((line = stream.ReadLine()) != null)
    {
        foreach (char c in line)
        {
            Console.Write(c);
            Thread.Sleep(250);
        }
        Console.Write(" ");
    
    }
    ```
    
    ```csharp
    // Write file with Stream Writer
    
    string FilePath = @"/Users/medhat/Desktop/files/newFile.txt";
    
    StreamWriter streamWriter = new StreamWriter(FilePath);
    streamWriter.WriteLine("File Input Video");
    streamWriter.Close();
    ```
    
- **File Class**
    
    provide some static method to perform most file operation, such as creating file, copying and moving a files, deleting files, and work with “File Stream” to read and write stream.
    
    ```csharp
    // Read file with File static class
    
    string[] starr = File.ReadAllLines(@"/Users/medhat/Desktop/files/testFile.txt");
    
    foreach (var i in starr)
    {
        System.Console.WriteLine(i);
    }
    ```
    
    ```csharp
    // Write file with File static class
    
    string FilePath = @"/Users/medhat/Desktop/files/newFile.txt";
    
    string message =
    @"Hello Every One
    This text from C# program 
    this simulation of log file in any C# project using File static class.";
    
    string newContent = "\nThis is New Line";
    
    if (File.Exists(FilePath))
    {
        Console.WriteLine("File Already Exist");
    }
    else
    {
        //Create New text
        File.WriteAllText(FilePath, message);
    
        //Add to exist text
        File.AppendAllText(FilePath, newContent);
    }
    ```