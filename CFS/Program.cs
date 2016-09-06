using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CFS
{
    class Program
    {
        static void Main(string[] args)
        {
            var password = "1234";
            var result = Cryptography.CFS(password);
            Console.WriteLine(result);
        }

    }
}
