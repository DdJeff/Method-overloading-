using System;

namespace MethodOverLoad
{
    class Program
    {
            static int Add(int num1, int num2)
            {
                return num1 + num2;
            }

            static decimal Add(decimal num1, decimal num2)
            {
                return num1 + num2;
            }

        static string Add(int num1, int num2, bool check)
        {
            var str = "";

            if (check && num1 + num2 == 1) {  str = $"{num1 + num2} dollar ";}
            else { str = $"{num1 + num2} dollars "; }

            return str;
        }


        static void Main(string[] args)
        {


           
            Console.WriteLine("Hello World!");
        }
    }
}
