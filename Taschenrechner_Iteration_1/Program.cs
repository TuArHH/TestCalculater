using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner_Iteration_1
{

    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  Als Benutzer möchte ich zwei Zahlen eingeben, um deren Summe berechnen lassen
             **/

            
           
            
            try
            {
                Console.Write("Bitte geben den ersten Summanden ein:");
                double doubnum1 = double.Parse(Console.ReadLine());
                Console.Write("Bitte geben den zweiten Summanden ein:");
                double doubnum2 = double.Parse(Console.ReadLine());

                
                double resultdouble = AddierenDouble(doubnum1, doubnum2);
                Console.WriteLine("Das Ergebnis lautet \t:{0} ", resultdouble);
               
                
            }
            catch (Exception)
            {
                Console.WriteLine("Bitte geben Sie eine Zahl ein ");

            }
           
            

            
            
            

         
            Console.ReadKey();

        }

        public static int Addieren(int num1,int num2)
        {   int result; 
            return result = num1 + num2;
        }

         public static double AddierenDouble(double num1,double num2)
        {   double result; 
            return result = num1 + num2;
        }
    }
}
