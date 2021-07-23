using System;

namespace MethodOverLoad
{
    class Program
    {       
        //defining a simple adding method
           int Add(int num1, int num2)
            {
                return num1 + num2;
            }

        //overloading the method to accept decimals
             decimal Add(decimal num1, decimal num2)
            {
                return num1 + num2;
            }

        //overloading the method to accepts bools and return a string
           static string Add(bool check,int first, int second )
                {
                    var str = "";

                    if (check && first + second == 1) {  str = $"{first + second} dollar ";}
                    else { str = $"{first + second} dollars "; }

                    return str;
                }


        static void Main(string[] args)
        {
            //calling test
            Add(2, 3);
            Add(2.3m, 4.5m);
            Add(true, 30, 40);
           
            Console.WriteLine("Hello World!");
        }
    }
}
