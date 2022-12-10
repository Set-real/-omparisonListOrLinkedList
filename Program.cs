using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace СomparisonListOrLinkedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Запустим таймер
            var watchOne = Stopwatch.StartNew();

            // Колекция List
            List<string> list = new List<string>();
            string[] fileContent = File.ReadAllLines(@"C:\Users\maest\Downloads\Text1.txt");
            list.AddRange(fileContent);

            // Выполняю вставку на рандомную строку
            list.Insert(1589, "Майкл Джексон");

            // Вывожу время на консоль
            Console.WriteLine($"Время выполнения вставка List: {watchOne.ElapsedMilliseconds}");

            // Запустим таймер еще раз
            var watchTwo = Stopwatch.StartNew();

            // Коллекция LinkedList
            string[] newfileContent = File.ReadAllLines(@"C:\Users\maest\Downloads\Text1.txt");
            LinkedList<string> linkedList = new LinkedList<string>();
            foreach (var lines in newfileContent)
            {
                linkedList.AddFirst(lines);
            }
            // Выполняю вставку 
            var celebriti = linkedList.AddFirst("Микки Рурк");
            linkedList.AddAfter(celebriti, "Железный Арни");

            // Вывожу время на консоль
            Console.WriteLine($"Время выполнения вставки LinkedList: {watchTwo.ElapsedMilliseconds}");
        }
    }
}
