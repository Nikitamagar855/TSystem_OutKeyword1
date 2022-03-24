using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSystem_OutKeyword
{
    class Program
    {
       
          static void Calculation(int n1,int n2, out int add,out int sub,out int multiply)
            {
            add = n1 + n2;
            sub = n1 - n2;
            multiply = n1 * n2;

           
            }
        static void Main(string[] args)
        {
            int a = 10;
            int b = 30;
            int add, sub, multiply;
           Calculation(a,b,out add,out sub,out multiply);
            Console.WriteLine(add);
            Console.WriteLine(sub);
            Console.WriteLine(multiply);
            Console.ReadLine();
        }
       
        }
    }

