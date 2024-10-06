using System.IO;

namespace AdvancedOOP.Classes;

public class FileIOLibrary
{
    #region Stream



    public void ReadFileWithStream()
    {

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

    }

    public void WriteFileWithStream()
    {
        // Write file with Stream Writer

        string FilePath = @"/Users/medhat/Desktop/files/newFile.txt";

        StreamWriter streamWriter = new StreamWriter(FilePath);
        streamWriter.WriteLine("File Input Video");
        streamWriter.Close();
    }

    #endregion

    #region File Class

    public void ReadFileWithFileClass()
    {
        // Read file with File static class

        string[] starr = File.ReadAllLines(@"/Users/medhat/Desktop/files/testFile.txt");

        foreach (var i in starr)
        {
            System.Console.WriteLine(i);
        }
    }


    public void WriteFileWithFileClass()
    {
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
    }

    #endregion
}
