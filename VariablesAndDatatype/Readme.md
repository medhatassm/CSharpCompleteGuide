## Variables And Datatype

Variable are containers for storing data values.

in C#, there are different types of variables (defined with different keyword)

### Declaring Variables

to create variable, you have to specify the type and assign it a value.

```csharp
// type variableName = value;
string Name = "Medhat";
```

### Type of Datatype

1. **Value Datatype**: directly store the variable value in memory and it will also accept both signed and unsigned literals
2. **Reference Datatype**: ****contain a memory address of variable value because reference type won’t store the value directly in memory

| Datatype | Description | Type |
| --- | --- | --- |
| int | Store number (4 byte) Example: 42 | Numeric Datatype |
| float | Store number (4 byte) Example: 10.23 | Numeric Datatype |
| double | Store number (8 byte) Example: 231.2313 | Numeric Datatype |
| decimal | Store number (16 byte) Example: 1413.445.2123 | Numeric Datatype |
| char | Store character (16 byte) Example: ‘F’ | Text based Datatype |
| string | Store Collection of character, Example “Nemo” | Text based Datatype |
| bool | Store 1 : 0 (True : False) | Boolean Datatype |

Example:

```csharp
int number = 10;
double doubleNumber = 3123.3123d;
float floatNumber = 32.41f;
decimal decimalNumber = 321.413m;
Console.WriteLine($"Numerical Datatype: {number} - {doubleNumber} - {floatNumber} - {decimalNumber}");
string text = "someText";
char character = 'L';
Console.WriteLine($"Text Base Datatype: {text} - {character}");
```

### Type Casting

when you assign a value of one datatype to another type.

there are tow types of casting

1. Implicit Casting
2. Explicit Casting

**Implicit Casting** (Automatically): Convert a smaller type to a larger type size.

```csharp
// char -> int -> long -> float -> double
int smallType = 20;
double largeType = smallType; // Automatic Casting
Console.WriteLine(largeType);
```

Explicit Casting (Manually): Converting a larger type to a smaller size type.

```csharp
// double -> float -> long -> int -> char
double largerType = 40.32; // Convert it to int
int smallerType;
// Solution One
smallerType = (int)largerType;
// Solution Two
smallerType = Convert.ToInt32(largerType);
```

> **Parse Method :** Help you to handle error if casting fail at runtime by using `int.TryParse()` this function take two arguments first one is value you want to cast it, second one is outer parameter that value will store in it if casting success at runtime
> 

```csharp
// Solution Three Of Convert it to int question
string textType = "10";
int Number;
if (int.TryParse(textType, out Number))
{
smallerType = Number; // assign the parsed value to smallerType
}
```

### Mathematic Operator

| Operation | Symbol | Example |
| --- | --- | --- |
| Addition | + | `x = x + y;` |
| Subtraction | - | `x = y - x;` |
| Division | / | `x = y / x;` |
| Multiplication | * | `x = y * x;` |
| Reminder | % | `x = y % x;` |
| increment | ++ | `x++` Get Value then Increment
++`y` Increment then Get Value |
| Decrement | -- | `x--` Get Value then Decrement
`--y` Decrement then Get Value |

> **Math Class:** Have many methods that allows you to perform mathematical tasks on methods.
> 

Example:

```csharp
Math.Max(5, 10); // The Math.Max(x,y) method can be used to find the highest value of x and y
Math.Min(5, 10); // The Math.Min(x,y) method can be used to find the lowest value of of x and y
Math.Sqrt(64); // The Math.Sqrt(x) method returns the square root of x
Math.Abs(-4.7); // The Math.Abs(x) method returns the absolute (positive) value of x
Math.Round(9.99); // Math.Round() rounds a number to the nearest whole number
```

### Keywords

are the words in a language that are used for some internal process or represent some predefined actions.

- **Var Keyword**
    
    is a keyword, it’s used to declare and implicit type variable, that specifies the type of variables based on initial value.
    
    ```csharp
    var variable = "Text"; // variable is string
    var variable = 20; // variable is int
    ```
    
- **Const Keyword**
    
    if you don’t want others (or yourself) to overwrite value, you can add the const keyword in front of the variable type.
    
    ```csharp
    const float PI = 14.3f;
    //PI = 13.2; // Error Becuse you can't overwrite a constant value.
    ```