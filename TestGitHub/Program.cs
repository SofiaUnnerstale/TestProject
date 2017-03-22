using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestGitHub
{
    class Program
    {
        static void Main(string[] args)
        {
            // Sofias program

            List<int> test = new List<int>();
            for (int i = 0; i < 10; i++)
            {
                test.Add(i);
                Console.WriteLine("Hej");
            }
            test.ForEach(x => Console.WriteLine(x));
        }
    }
}
