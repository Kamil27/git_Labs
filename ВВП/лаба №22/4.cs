using System;
using System.IO;
class Program
{
    static void Main()
    {
        string file = @"C:\Users\KAMA\source\repos\22\22-4\TextFile4.txt";
        string line = File.ReadAllText(file);
        string str = "";
        for (int i = 1; i < line.Length; i++)
        {
            if (i != line.Length - 1)
            {
                if (line[i] == ' ')
                {
                    str += line[i];
                    while (line[i] == ' ') i++;
                }
            }
            if (line[i] != ' ') str += line[i];
        }
        File.WriteAllText(@"C:\Users\KAMA\source\repos\22\22-4\TextFile4.txt", string.Empty);
        File.WriteAllText(@"C:\Users\KAMA\source\repos\22\22-4\TextFile4.txt", str);
        Console.Write(str);
        Console.ReadKey();
    }
}
