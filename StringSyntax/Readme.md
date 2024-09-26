## String Syntax

### Path Value Into String

- **String Concatenation**
    
    concatenate strings to each other use `+` symbol
    
    ```csharp
    Console.WriteLine("My Name is" + " Medhat" + " Assem");
    ```
    
- **String formatting**
    
    use to path a value into string without concatenation symbol
    
    ```csharp
    string Name = "Medhat";
    int Age = 25;
    Console.WriteLine("Hello my name is {0} my age is {1}", Name, Age);
    ```
    
- **Numeric formatting**
    
    used to format common numeric type
    
    ```csharp
    double Numeric = 81.0372771474878D;
    Console.WriteLine(string.Format("{0}", Numeric)); // Normal Formating
    Console.WriteLine(string.Format("{0:0.00}", Numeric)); // 81.04 (floor the number)
    Console.WriteLine(string.Format("{0:0.0}", Numeric)); // 81.0
    Console.WriteLine(string.Format("{0:0}", Numeric)); // 81
    // if # represent number equal to zero it will n't display
    Console.WriteLine(string.Format("{0:0.#}", Numeric));
    ```
    
    - Currency Format
        
        Some method to show currency beside the value
        
        - `ToString(”C”)` get currency of your culture
            - `“C0”` Normal Value
            - `“C1”` Display First Decimal number
            - `“C2”` Display Two Decimal number only
            
            ```csharp
            decimal money = 21.23M;
            
            Console.WriteLine(money.ToString("C")); // equal to "C0"
            Console.WriteLine(money.ToString("C1"));
            Console.WriteLine(money.ToString("C2"));
            ```
            
        - CultureInfo Class: To specify which culture currency you want it to display using this method:
            - `CultureInfo.CurrentCulture()`
            - `CultureInfo.CreateSpecificCulture("en-GB")`  England Currency, Use this Link to get more culture  currency string info [CultureInfo Class Doc](https://learn.microsoft.com/en-us/dotnet/api/system.globalization.cultureinfo.createspecificculture?view=net-8.0)
            
            ```csharp
            deciaml money = 46.89M;
            
            Console.WriteLine(money.ToString("C", CultureInfo.CurrentCulture));
            Console.WriteLine(money.ToString("C",
             CultureInfo.CreateSpecificCulture("en-us")));
            ```
            
- **String Interpolation**
    
    concatenate strings to each other use `$` symbol
    
    ```csharp
    string Name = "Medhat";
    int Age = 25;
    Console.WriteLine($"My Name is {Name} and my age is {Age}");
    ```
    
- **Verbatim string literal**
    
    To indicate that string literal is to be interpreted verbatim
    
    ```csharp
    Console.WriteLine(@"My Name is Medhat
                And my Age is 25
                Email: /* MedhatAssm@gmail.com */");
    // Output
    // My Name is Medhat
    //             And my Age is 25
    //             Email: /* MedhatAssm@gmail.com */
    ```
    

### String Methods

- **string.Empty**
    
    it used to represent Empty quotation mark `“”` , in clean code you should make your code readable for any one work on project after you so let’s ask you which is better and understandable easier:
    
    ```csharp
    if(Name == ""){
    
    	// Block of code
    
    }
    ```
    
    ```csharp
    if(Name == string.Empty){
    
    	// Block of Code
    
    }
    ```
    
    > This Up to you but best practice try use `string.Empty()` more in your project.
    > 
- **string.Equals**
    
    it used to represent `==` symbol like string.Empty for clean code and make your code more readable for other programmer.
    
    ```csharp
    if(Name.Equals("Medht")){
    
    	// Block of code
    
    }
    ```
    
    ```csharp
    if(Name == "Medhat"){
    
    	// Block of Code
    
    }
    ```
    
    > Also up to you to chose but which is better for read do you think ?
    > 
- **string.IsNullOrEmpty**
    
    it is used to check whether the specified string is null or and empty string. A string will be **Null** if it hasn’t been assigned value
    
    ```csharp
    if (string.IsNullOrEmpty(Name))
    {
    
        // Block of code
    
    }
    ```
    
- **String Iteration looping**
    
    > String is Array of Characters
    > 
    
    treat your string as array with characters type so you can loop on it write loop statement and you can search on it for specify characters using `.Contain()` method that return bool type and with `.IndexOf()` method that return address of your characters and now you can get it easily.
    
    ```csharp
    string txt = "Hello My Name is Medhat Assem And this Simpal Task for iteration looping";
    
    for (int i = 0; i < txt.Length; i++)
    {
        Console.Write(txt[i]);
        Thread.Sleep(150); // That line make compiler stop For 150 Millisecond and work again
    }
    
    ```