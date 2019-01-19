using System;

namespace ConsoleApp4
{
    class Program
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
            SayHello("srividya");
            static void SayHello(string name1)
            {
                Console.WriteLine(" hii " + name1);

            }
        // Console.WriteLine(GetMax(10, 20));
        static void Main(string[] args)
        {
            int num1, num2;
            num1 = 20;
            num2 = 30;
            if (num1 > num2)
            {
                Console.WriteLine(num1);
            }
            else
            {
                Console.WriteLine(num2);
            }
            Console.ReadLine();
        }


        /*  static int GetMax(int num1,int num2)
          {
              int result;
              if(num1>num2)
              {
                  result = num1;
              }
              else
              {
                  result = num2;
              }
          }*/
    }
}
        
    

