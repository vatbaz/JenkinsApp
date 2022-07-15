using System;
using newdll; 

namespace JenkinsApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("welcome to jenkins");
            Console.ReadLine();
             MyMath myMath = new MyMath();

            Console.WriteLine("The sum is : ", myMath.add(10, 20));
            
            Console.WriteLine("The sum is : ", myMath.multiply(10, 20));
        }
    }
}
