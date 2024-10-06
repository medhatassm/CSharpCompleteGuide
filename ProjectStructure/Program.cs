#region Stream

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

// Write file with Stream Writer

string FilePath = @"/Users/medhat/Desktop/files/newFile.txt";

StreamWriter streamWriter = new StreamWriter(FilePath);
streamWriter.WriteLine("File Input Video");
streamWriter.Close();


#endregion

#region File Class

// Read file with File static class

string[] starr = File.ReadAllLines(@"/Users/medhat/Desktop/files/testFile.txt");

foreach (var i in starr)
{
    System.Console.WriteLine(i);
}




// Write file with File static class

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

#endregion
