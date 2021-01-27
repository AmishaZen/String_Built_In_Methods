using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConStringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str, str1;
            int choice;
            Console.WriteLine("Enter your Choice\n1 for Compare strings\n2 for Concat Strings\n3 for Split string\n4 for check equality\n5 for Replace\n6 for exit");
            do
            {
                Console.WriteLine("Enter Your Choice");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter string 1 to Compare");
                        str = Console.ReadLine();
                        Console.WriteLine("Enter string 2 to Compare");
                        str1 = Console.ReadLine();
                        Console.WriteLine(string.Compare(str, str1));
                        break;
                    case 2:
                        Console.WriteLine("Enter string 1 to Concat");
                        str = Console.ReadLine();
                        Console.WriteLine("Enter string 2 to Concat");
                        str1 = Console.ReadLine();
                        Console.WriteLine(string.Concat(str, str1));
                        //str = str + str1;
                        //Console.WriteLine(str);
                        break;
                    case 3:
                        Console.WriteLine("Enter String to split");

                        str = Console.ReadLine();
                        string[] s2 = str.Split(' ');
                        foreach (string str2 in s2)
                        {
                            Console.WriteLine(str2);
                        }
                        break;
                    case 4:
                        Console.WriteLine("Enter String 1 to check equality");
                        str = Console.ReadLine();
                        Console.WriteLine("Enter String 2 to check equality");
                        str1 = Console.ReadLine();
                        Console.WriteLine(str.Equals(str1));
                        break;
                    case 5:
                        Console.WriteLine("Enter String to Replace");
                        str = "Hello C# welcome";
                        Console.WriteLine(str.Replace("C#", "DotNet"));
                        break;

                    default:
                        Console.WriteLine("wrong choice");
                        break;

                }
            } while (choice > 0 && choice<=5);
        }
    }
}
