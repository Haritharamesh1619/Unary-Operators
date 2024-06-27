using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unary_Operators
{
     class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int ans = a++; // post - increment example: 
            Console.WriteLine("a is {0} and ans is {1}",a,ans);
            ans = a--;// post-decrement example:
            Console.WriteLine("a is {0} and ans is {1}", a, ans);
            ans = ++a;// pre-decrement example:
            Console.WriteLine("a is {0} and ans is {1}", a, ans);
            ans = --a;// pre-decrement example:
            Console.WriteLine("a is {0} and ans is {1}", a, ans);
            Console.ReadLine();
        }
    }
}
