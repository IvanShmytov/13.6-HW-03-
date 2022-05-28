using System;
using System.IO;
using System.Diagnostics;
namespace FinalTask
{
    class Program
    {        
        static List<string> StrList = new List<string>();
        static LinkedList<string> StrLinkList = new LinkedList<string>();
        static void Main(string[] args)
        {
            try
            {
                string Path = @"C:\Users\ivans\source\repos\13.6 (HW-03)\Text1.txt";
                string Text = File.ReadAllText(Path);
                char[] separators = new char[] { ' ', '.', ',', '-', '!', '?', ':', ';', '\n'};
                string[] subs = Text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
           
                var Watch = Stopwatch.StartNew();
                foreach (var item in subs)
                {
                    StrLinkList.AddLast(item);
                }
                Console.WriteLine($"Скорость вставки в связанный список: {Watch.Elapsed.TotalMilliseconds}  мс");

                Watch = Stopwatch.StartNew();
                foreach (var item in subs)
                {
                    StrList.Add(item);
                }
                Console.WriteLine($"Скорость вставки в список: {Watch.Elapsed.TotalMilliseconds}  мс");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Измените путь к файлу");
            }
        }
    }
}
