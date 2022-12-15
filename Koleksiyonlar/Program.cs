using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> { "Tuğrul", "Batuhan", "Enes" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            isimler.Add("Mehmet");
            Console.WriteLine(isimler[3]);
            Console.WriteLine(isimler[0]);

            Console.ReadLine();
        }
    }
}
