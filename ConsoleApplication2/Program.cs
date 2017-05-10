using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入第一个数");
            int first;
            first = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入第二个数");
            int second;
            second = int.Parse(Console.ReadLine());
            Console.WriteLine("{0}加{1}的和是:{2}", first, second, first + second);

        }
    }
}
