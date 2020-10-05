using System;
using System.Windows.Markup;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

namespace HocKteam
{
    
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Nhap duong dan: ");
            string filePath = @"D:\baitap.txt";
            List<string> lines = File.ReadAllLines(filePath).ToList();
            for(int i=0;i<lines.Count;i++)
            {
                Console.WriteLine(lines[i]);
            }

            Person person = new Person();
            person.Name = lines[0];
            Console.WriteLine(person.Name);
            string[] entries = lines[0].Split(",");
            Console.WriteLine(entries[1]);
            Console.ReadLine();
            
            
        }
    }
}
