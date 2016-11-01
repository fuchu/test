using System;
namespace HelloWorldApplication
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            int a;
            a=1;
            Console.WriteLine(a>2 ? "This is One.":"This is not One.");
            Console.WriteLine("HelloWorld!123456");
            System.Console.WriteLine(a);
            System.Console.WriteLine(1 + 2);
            String c="3";
            c="6";
            System.Console.WriteLine(a + c);
            System.Console.WriteLine("输入前：");
            string input = Console.ReadLine();
            System.Console.WriteLine("输入后。");
            System.Console.WriteLine(input);
            System.Console.WriteLine("1\t2\t3\t4\t5");
            System.Console.WriteLine("111\t222\t333\t444\t555\t");
            string str = @"C:\Windows";
            System.Console.WriteLine(str);
            a = 1;
            int b;
            b = a++;
            System.Console.WriteLine("a= {0}",a);
            System.Console.WriteLine("b={0}",b);
            Console.ReadLine();
            a = 1;
            b = ++a;
            System.Console.WriteLine("a={0}",a);
            System.Console.WriteLine("b={0}",b);
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
