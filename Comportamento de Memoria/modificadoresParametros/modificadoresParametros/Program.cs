﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace modificadoresParametros
{
    class Program
    {
        static void Main(string[] args)
        {
            int s1 = Calculator.Sum(2, 3);
            int s2 = Calculator.Sum(2, 4, 3);
            int a = 10;
            int b = 10;
            int triple;

            Calculator.Tiple(ref a);
            Calculator.Tiple(b, out triple);

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(a);
            Console.WriteLine(triple);


        }
    }
}
