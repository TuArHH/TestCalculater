using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taschenrechner
{
    class RechnerModel
    {
        

        public double Resultat { get; private set; }

        public void Rechnermodel()
        {
            Resultat = 0;
        }



        

        public static double Addieren(double num1, double num2)
        {

            return num1 + num2;
        }

        public static double Subtract(double num1, double num2)
        {


            return num1 - num2;

        }

        public static double Divided(double num1, double num2)
        {

            return num1 / num2;
        }

        public static double Muliplication(double num1, double num2)
        {

            return num1 * num2;
        }

        public static string Operation(string op)
        {
            Console.Write(op);
            string summand = Console.ReadLine();
            return summand;
        }

        public void Berechne()
        {

            Console.Write("Bitte gebe die erste Zahl ein:");
            string summand1 = Console.ReadLine();
            string operation = Operation("Bitte gib die auszuführende Operation ein (+ , - , / oder *) : ");
            Console.Write("Bitte gebe die zweite Zahl ein:");
            string summand2 = Console.ReadLine();
           

            // Wanden in Zahlen
            double dnum1 = Convert.ToDouble(summand1);
            double dnum2 = Convert.ToDouble(summand2);

            // Berechnung verschiedener Operationen
            if (operation == "+")
            {
                Resultat = Addieren(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else if (operation == "-")
            {
                Resultat = Subtract(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else if (operation == "/")
            {
                Resultat = Divided(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else if (operation == "*")
            {
                Resultat = Muliplication(dnum1, dnum2);
                Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                "Bitte drücke die EnterTaste um das Programm zu beenden");
            }
            else
            {
                Console.WriteLine("Diese Operation existiert in diesem Kontext nicht");
            }
        }

        
    }
}
