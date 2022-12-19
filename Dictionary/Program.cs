using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int,string> dictionary1 = new MyDictionary<int,string>();
            dictionary1.Add(54, "Sakarya");
            dictionary1.Add(52, "Ordu");
            dictionary1.Add(45, "Manisa");

            Console.WriteLine(dictionary1.Count);

            Console.ReadLine();
        }
    }
}
