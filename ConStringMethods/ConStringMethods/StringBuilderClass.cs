using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConStringMethods
{
    class StringBuilderClass
    {
        static void Main()
        {
            StringBuilder str = new StringBuilder();
            int option;
            Console.WriteLine("Enter your Choice\n1 for Append\n2 for AppendLine\n3 for Replace\n4 for Length\n5 for Capacity\n6 for exit");
            do
            {
                Console.WriteLine("Enter your choice to execute");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Console.WriteLine("Enter String to Append");
                        string address = Console.ReadLine();
                        Console.WriteLine(str.Append(address)); //Append at the end of current string
                        break;
                    case 2:
                        Console.WriteLine("Enter String 1 to Append in new Line");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter string 2 to Append ");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Appended strings are:");
                        Console.WriteLine(str.AppendLine(name)); //Append string in new line
                        Console.WriteLine(str.AppendLine(surname)); //Append string in new line
                        break;
                    case 3:
                        Console.WriteLine("Enter String");
                        string str1 = Console.ReadLine();
                        Console.WriteLine("Enter string to replace ");
                        string oldStr = Console.ReadLine();
                        Console.WriteLine("Enter string to replace the previous entered string ");
                        string newStr = Console.ReadLine();
                        Console.WriteLine($"New String is {str1.Replace(oldStr, newStr)}");
                        break;
                    case 4:
                        Console.WriteLine("Enter String to check Length");
                        string addressStr = Console.ReadLine();
                        Console.WriteLine(addressStr.Length);
                        break;
                    case 5:
                        Console.WriteLine(str.Capacity);
                        string strr = Console.ReadLine();
                        str.Append(strr);
                        Console.WriteLine(str.Capacity);
                        break;
                    default: Console.WriteLine("wrong choice"); break;
                }
            } while (option>0 && option<=5);
        }
    }
}
