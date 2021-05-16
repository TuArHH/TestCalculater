using System;

namespace Taschenrechner
{

    class Program
    {

        

        static void Main(string[] args)
        {
            /**
             *  Als Benutzer möchte ich zwei Zahlen eingeben [Ganzahlen & Gleitkommazahlen], um deren Summe,Diffzerenz, Division und Mulitpliaktion berechnen zu lassen
             **/

            //Objekte declariert und initalisiert
            RechnerModel model = new RechnerModel();
            AnwendungsController controller = new AnwendungsController(model);

            //Ausgabe
            controller.Ausfuehren();
            Console.ReadKey();

           

    }
    



        

    }
}
