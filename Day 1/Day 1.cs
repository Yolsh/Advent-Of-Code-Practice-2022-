using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Day_1
{
    internal class Program
    {
        static int PerElfCals(string[] cals)
        {
            int total = 0;
            for (int i = 0; i < cals.Length; i++)
            {
                total += int.Parse(cals[i]);
            }
            return total;
        }

        static void find(List<int> list)
        {
            int largest = 0;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] > largest)
                {
                    largest = list[i];
                }
            }
            Console.WriteLine(largest);
            Console.ReadKey();
        }

        static void Main(string[] args)
        {
            List<int> totalCals = new List<int>();
            using (StreamReader sr = new StreamReader("input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    List<string> elf = new List<string>();
                    string line = sr.ReadLine();
                    while (line != "")
                    {
                        elf.Add(line);
                    }
                    totalCals.Add(PerElfCals(elf.ToArray()));
                }
                find(totalCals);
            }

        }
    }
}
