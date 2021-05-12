using System;

namespace Taschenrechner
{

    class Program
    {
        static void Main(string[] args)
        {
            /**
             *  Als Benutzer möchte ich zwei Zahlen eingeben [Ganzahlen & Gleitkommazahlen], um deren Summe berechnen zu lassen
             **/








            Console.Write("Bitte geben den ersten Summanden ein:");
            double doubnum1 = double.Parse(Console.ReadLine());
            Console.Write("Bitte geben den zweiten Summanden ein:");
            double doubnum2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Das Ergebnis ist \t:{0} ",Addieren(doubnum1, doubnum2)+Environment.NewLine+"Bitte drücken sie die EnterTaste um das Programm zu beenden");

            Console.ReadKey();

        }

      

         public static double Addieren(double num1,double num2)
        {
            
            double result;
            return result= num1 + num2;
            

        }
    }
}
