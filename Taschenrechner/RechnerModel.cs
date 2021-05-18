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

        //public void GetNumber()
        //{
        //    double result;
        //    Console.Write("Bitte gebe die erste Zahl ein:");
        //    string summand1 = Console.ReadLine();
        //    string operation = Operation("Bitte gib die auszuführende Operation ein (+ , - , / oder *) : ");
        //    Console.Write("Bitte gebe die zweite Zahl ein:");
        //    string summand2 = Console.ReadLine();

        //    // Wanden in Zahlen
        //    double dnum1 = double.Parse(summand1);
        //    double dnum2 = double.Parse(summand2);
        //}

        public void Berechne()
        {
            //double result;
            //Console.Write("Bitte gebe die erste Zahl ein:");
            //double summand1 = double.Parse(Console.ReadLine());
            //string operation = Operation("Bitte gib die auszuführende Operation ein (+ , - , / oder *) : ");
            //Console.Write("Bitte gebe die zweite Zahl ein:");
            //double  summand2 = double.Parse(Console.ReadLine());

            // Wanden in Zahlen
            //double dnum1 = double.Parse(summand1);
            //double dnum2 = double.Parse(summand2);

            


            try
            {
                
                Console.Write("Bitte gebe die erste Zahl ein:");
                double summand1 = double.Parse(Console.ReadLine());
                string operation = Operation("Bitte gib die auszuführende Operation ein (+ , - , / oder *) : ");
                Console.Write("Bitte gebe die zweite Zahl ein:");
                double summand2 = double.Parse(Console.ReadLine());


                // Berechnung verschiedener Operationen
                if (operation == "+")
                {
                    Resultat = Addieren(summand1, summand2);
                    Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                    "Bitte drücke die EnterTaste um das Programm zu beenden");
                }
                else if (operation == "-")
                {
                    Resultat = Subtract(summand1, summand2);
                    Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                    "Bitte drücke die EnterTaste um das Programm zu beenden");
                }
                else if (operation == "/" || operation == ":")
                {
                    Resultat = Divided(summand1, summand2);
                    Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                    "Bitte drücke die EnterTaste um das Programm zu beenden");
                }
                else if (operation == "*")
                {
                    Resultat = Muliplication(summand1, summand2);
                    Console.WriteLine("Das Ergebnis ist \t:{0} ", Resultat + Environment.NewLine +
                    "Bitte drücke die EnterTaste um das Programm zu beenden");
                }
                else
                {
                    Console.WriteLine("Diese Operation existiert in diesem Kontext nicht");
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Bitte gebe nur (primitve) Zahlen ein");
            }

        }

        
    }
}
