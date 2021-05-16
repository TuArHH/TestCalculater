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
                string summand1 = Console.ReadLine();

                Console.Write("Bitte geben den zweiten Summanden ein:");
                string summand2 = Console.ReadLine();

                // Wandeln in einen Ganzzahle
                int num1 = Convert.ToInt32(summand1);
                int num2 = Convert.ToInt32(summand2);

                //Ausgabe
                Console.WriteLine("Das Ergebnis ist \t:{0} ", Addieren(num1, num2) + Environment.NewLine + 
                "Bitte drücken sie die EnterTaste um das Programm zu beenden");

                Console.ReadKey();

           

    }
    


        public static double Addieren(double num1,double num2)
        {
                
                double result;
                return result = num1 + num2;
           
        }

        public static double Subtract(double num1, double num2)
        {

            double result;
            return result = num1 - num2;

        }


    }
}
