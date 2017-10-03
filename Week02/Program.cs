using System;

namespace Week02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            
            int getal;
            getal = 10;

            // variable wordt in het zelfde lijn beschrijen (groen underlijn alst het nog niet gebruikt is)
            int getall = 5;
            // WriteLine om ze onder elkaar te tonen
            Console.WriteLine(getal);
            Console.WriteLine(getall);

            byte byteWaarde1 = 200;      // decimal
            byte byteWaarde2 = 0x00C8;  // hexadecimal
            byte byteWaarde3 = 0b100_1000;  // binair
            
            // aanvragen waar de getal plaats mag vinden
            Console.WriteLine("decimaal: {0}; hexadecimaal {1}; binair {2}", byteWaarde1, byteWaarde2, byteWaarde3);
            
            // max en min waarde van een byte
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);

            // vragen welke type type van data het is
            Console.WriteLine(typeof(byte));
            Console.WriteLine(typeof(Byte));
            // waarde zal 0 zijn by default
            Console.WriteLine(default(byte));

            // wat zal er gebeuren als we bytes optellen?
            // twee bytes maken met comma seperation
            byte a = 15, b = 10;
            // wij moeten meegeven dat het byte moet zijn
            byte som = (byte)(a + b);
            Console.WriteLine(som);

            // INT
            Console.WriteLine("Hier start INT");
            Console.WriteLine(int.MaxValue); // 2147483647
            Console.WriteLine(int.MinValue); // -2147483648

            Console.WriteLine(typeof(int)); // system.Int32
            // Console.WriteLine(typeof(Int)); werkt niet
            Console.WriteLine(default(int)); // 0

            int aint = 15, bint = 10;
            int somint = aint+bint;
            Console.WriteLine(somint);
            
            // EXAMEN: welke classe is int? INT32
            // sequentie == opeenvolging van data
            
            Console.WriteLine("Geef een getal in");
            int getal2 = Convert.ToInt32(Console.ReadLine());

            if(getal2 < 10){
                Console.WriteLine("Getal is kleiner dan 10.");
                    // geneste
                    if(getal2 == 2){
                        Console.WriteLine("Getal is twee.")
                    },
            } else if(getal2 > 10 ) {
                Console.WriteLine("Getal is groter dan 10.");
            } else {
                Console.WriteLine("Getal is gelijk aan 10.");
            }


        }
    }
}
