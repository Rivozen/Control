using System;
using System.IO;
using System.Text;
using System.Threading;

namespace GreenTea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Thread Word = new Thread(WordThread);            
            Word.Start();
            Console.ReadKey();
        }
        static void WordThread()
        {
            string path;
            path = Directory.GetCurrentDirectory();
            Console.WriteLine($"В данной директории: {path} должен быть файл words.txt");
            FileCheck(ref path);
        }
        static void FileCheck(ref string path)
        {
            string currentFile = path + "/words.txt";
            if (File.Exists(currentFile))
            {
                Console.WriteLine("Файл присутствует");
                Processing(ref currentFile, path);
            } else 
            {
                Console.WriteLine("Файл отсутсвует");
            }
        }
        static void Processing(ref string currentFile, string path)
        {
            int m = 0, n = 0;
            char space = ' ';            
            Console.Write("Сколько обработать последних слов:");
            m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Сколько обработать последних строк:");
            n = Convert.ToInt32(Console.ReadLine());
            StreamReader sr = new StreamReader(currentFile);
            StreamWriter sw = new StreamWriter(currentFile);
            Console.WriteLine(sr.ReadToEnd());
            int total_strings = File.ReadAllLines(currentFile).Length;
            Console.WriteLine(total_strings);
            string newFile = path + "/result.txt";
            string test;
            FileInfo fileDC = new FileInfo(newFile);
            if (File.Exists(newFile))
            {
                fileDC.Delete();
                fileDC.Create();
                Console.WriteLine("Результат был удалён и создан");
            }
            else
            {
                fileDC.Create();
                Console.WriteLine("Результат был создан");
            }
            int currentLine = total_strings;
            for (int i = total_strings; i > n; i--)
            {
                
            }
            Console.ReadKey();
        }
    }
}