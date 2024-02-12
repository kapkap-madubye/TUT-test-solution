using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TUT1_Question3
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("enter the main member name: ");
            string main1 = Console.ReadLine();
            Console.WriteLine("enter the main member age: ");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Adult dependents: ");
            int adultnum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of children dependents:");
            int childnum1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter main Member monthly Income: ");
            int income = int.Parse(Console.ReadLine());
            Console.WriteLine($"1.{main1} ({age} yrs old) have {adultnum1} adult dependent(s) and {childnum1} children");


            Console.WriteLine("------------------------person 2----------------------");


            Console.WriteLine("enter the main member name: ");
            string main2 = Console.ReadLine();
            Console.WriteLine("enter the main member age: ");
            int age2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Number of Adult dependents: ");
            int adultnum2= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number of children dependents:");
            int childnum2= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter main Member monthly Income: ");
            int income2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"2.{main2} ({age2} yrs old) have {adultnum2} adult dependent(s) and {childnum2} children");




            Console.ReadKey();
        }
    }
}
