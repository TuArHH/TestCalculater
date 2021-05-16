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

            //Ausgabe 
            Output();
            Console.ReadKey();

           

    }
    


        public static double Addieren(double num1,double num2)
        {
                
                return  num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {

            
            return  num1 - num2;

        }

        public static double Divided(double num1,double num2)
        {
            
            return  num1 / num2;
        }
        
        public static double Muliplication(double num1,double num2)
        {
            
            return  num1 * num2;
        }

        public static string Operation(string op)
        {
            Console.Write(op);
            string summand = Console.ReadLine();
            return summand;
        }

        public static void Output()
        {
            Console.Write("Bitte gebe die erste Zahl ein:");
            string summand1 = Console.ReadLine();

            Console.Write("Bitte gebe die zweite Zahl ein:");
            string summand2 = Console.ReadLine();

            string operation = Operation("Bitte gib die auszuführende Operation ein (+ , - , / oder *) : ");

            //Wandeln in einen Gleitkommazahl
            double dnum1 = Convert.ToDouble(summand1);
            double dnum2 = Convert.ToDouble(summand2);
            double result = 0;
            // Berechnung verschiedener Operationen
            if (operation == "+")
            {
                result = Addieren(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", result + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else if (operation == "-")
            {
                result = Subtract(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", result + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else if (operation == "/")
            {
                result = Divided(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", result + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else if (operation == "*")
            {
                result = Muliplication(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", result + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else
            {
                Console.WriteLine("Diese Operation existiert in diesem Kontext nicht");
            }

        }

    }
}
