using System;

namespace method_overloading
{
    public class override_ex
    {
        public int Add(int a,int b)
        {
            int result1 = a + b;
            return result1;
        }
         public int Add(int a,int b,int c)
        {
            int result = a + b+c;
            return result;
        }
        
    }
   public  class Program
    {
        static void Main(string[] args)
        {
            override_ex e = new override_ex();
            e.Add(23, 4);
            e.Add(4, 5, 6);
            // Console.WriteLine("Hello World!");
            Console.ReadLine();
        }
    }
}
