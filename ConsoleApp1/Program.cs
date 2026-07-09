namespace ConsoleApp1;

class Program
{
    static void Main(string[] args)
    {
        
        Example2();
    }

    static void Example1()
    {
        string path = "sample.txt";

        using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
        {
            Console.WriteLine($"Lenght:   {fs.Length} Bytes");
            Console.WriteLine($"Position: {fs.Position}");
            Console.WriteLine($"CanRead: {fs.CanRead}");
            Console.WriteLine($"CanWrite: {fs.CanWrite}");
            Console.WriteLine($"CanSeek: {fs.CanSeek}");
            Console.WriteLine($"CanTimeout: {fs.CanTimeout}");

            // fs.Read()
            
        }
    }

    static void Example2()
    {
        string path = "sample.txt";
        // using (StreamWriter sw = new StreamWriter(path))
        // {
        //     sw.WriteLine("This");
        //     sw.WriteLine("is");
        //     sw.WriteLine("C#");
        // }

        StreamReader sr = new StreamReader(path);
        var content = sr.ReadToEnd();
        var by = File.ReadAllBytes(path);
        // Console.WriteLine(by.Length);
        // Console.WriteLine(content.Length);
        int line = 0;
        foreach (var i in content)
        {
            if (i == '\n')
            {
                line++;
            }
        }
        Console.WriteLine(line);
        Console.WriteLine(content);
        // content.Cou
    }
}

