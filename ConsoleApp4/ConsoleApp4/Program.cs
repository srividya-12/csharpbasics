using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string farmer = " backbone of india ";
            Console.WriteLine(farmer.Length + farmer.ToUpper());
            Console.WriteLine(farmer.Contains("of"));
            Console.WriteLine(farmer[5]);
            Console.WriteLine(farmer.IndexOf('i'));
            Console.WriteLine(farmer.IndexOf('z'));
            Console.WriteLine(farmer.Substring(farmer.IndexOf("of")));
            Console.WriteLine(Math.Exp(9));
            Console.Write("enter your name:");
            string name = Console.ReadLine();
            Console.WriteLine(" hello " + name);
            int[] arr = { 34, 8765, 98 };
            Console.WriteLine(arr[2]);
            SayHello("sri vidya");

        }
        static void SayHello(string name1)
        {
            Console.WriteLine(" hii " + name1);
            Console.ReadLine();
        }
    }
}
        
    

