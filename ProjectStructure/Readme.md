## Project Structure

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