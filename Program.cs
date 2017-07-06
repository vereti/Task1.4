using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Words
{
    class Program
    {
        static void Main(string[] args)
        {
            string s, sub;
            s = Console.ReadLine();
            sub = Console.ReadLine();
            for (int i = 0; i < s.Length; ++i)
            {
                if (sub.IndexOf(s[i]) == -1)
                {
                    Console.Write("нет ");
                }
                else
                {
                    Console.Write("да ");
                }
            }
        }
    }
}
