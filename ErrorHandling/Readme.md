## Error Handling

### Error

- **Syntax Error**
    
    an error in the syntax of a sequence of characters that is intended to be written in a particular programming language
    
- **Logic Error**
    
    ones where you don’t get the result were excepting, **you wan’t see any red color wavy line,** and the Program generally won’t **“but out”** on you, in other words, you have made an error in your programming logic (show at run time).
    
    ---
    

### Exceptions

- **Handle Exception (Try / Catch)**
    
    the `try` statement allow you to define a block of code to be tested for errors while its being executed.
    
    the `catch` statement allows you to define a block of code to be executed, if an error occurs in the try block.
    
    > **The try and catch keywords come in pairs.**
    > 
    - Without using Try Catch
        
        ```csharp
        string number = "10.34MD";
        int cast;
        
        cast = Convert.ToInt32(number);
        ```
        
        ![Screenshot 2024-09-29 at 1 08 15 AM](https://github.com/user-attachments/assets/2e34778b-3a84-485d-be58-fe166a694142)

    - Using Try Catch
        
        ```csharp
        string number = "10.34MD";
        int cast;
        
        try
        {
            cast = Convert.ToInt32(number);
        }
        catch
        {
        	  Console.WriteLine("Invaid Cast");
        }
        ```
        
    
    ---
    
- **Exception Class**
    
    using exception class as base class for which exception inherit to represent an error.
    
    ```csharp
    string number = "10.34MD";
    int cast;
    
    try
    {
        cast = Convert.ToInt32(number);
    }
    catch (InvalidCastException ex)
    {
        Console.WriteLine(ex.Message);
    }
    catch (Exception e)
    {
        Console.WriteLine(e.Message);
    }
    ```
    
    ---
    
- **Built-in Exception**
    
    C# .Net includes built-in exception classes for every possible error, the exception class is the base of all the exception classes.
    
    ---
    
- Custom Exception
    
    create a custom exception for user-defined exception.
    
    ```csharp
    using System;
    
    public class EmployeeListNotFoundException : Exception
    {
        public EmployeeListNotFoundException()
        {
        }
    
        public EmployeeListNotFoundException(string message)
            : base(message)
        {
        }
    
        public EmployeeListNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
    ```
    
    ---
    
- **Exception Filter**
    
    used it based on requirement you define for the exception, these handlers use the catch statement with the `when` keyword.
    
    ```csharp
    try
    {
        //block of code
    }
    catch (Exception ex) when (ex.Message.Contains("404"))
    {
        //block of code
    }
    ```
    
    ---
    
- **Swallow & Duck Exception**

**Swallow Exception :** The practice of catching an error or exception, and then continuing without logging, processing, or reporting the error to other parts of the software.

**Ducking Exception :** Avoiding your code from getting hit by any exception
