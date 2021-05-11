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
            Console.Write("Bitte geben den ersten Summanden ein:");
            //int num1=int.Parse(Console.ReadLine());
            double doubnum1= double.Parse(Console.ReadLine());

            Console.Write("Bitte geben den zweiten Summanden ein:");
            //int num2= int.Parse(Console.ReadLine());
            double doubnum2= double.Parse(Console.ReadLine());
            //int result=Addieren(num1, num2);

            double resultdouble= AddierenDouble(doubnum1,doubnum2);
            
            //Console.WriteLine("Das Ergebnis lautet \t:{0} ", result);
            Console.WriteLine("Das Ergebnis lautet \t:{0} ", resultdouble);

         
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
