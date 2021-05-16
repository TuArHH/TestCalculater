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

            //Berechne ausführen
            RechnerModel model = new RechnerModel();
            model.Berechne();
            
            //Ausgabe 
            Console.ReadKey();

           

    }
    



        

    }
}
