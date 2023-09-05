namespace Algoritmer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true) 
            {
                Menu();
            }
        }

        public static void Calc() //Miniräknar metod. Räknar ut summan produkten differensen och kvoten av två tal
        {
            Console.Clear();
            Console.WriteLine("Skriv in 2 tal för att se summan, produkten, differensen och kvoten av talen.");

            Console.Write("Tal 1: ");
            double tal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Tal 2: ");
            double tal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Summan av talen är: {tal1 + tal2}\n" +
                              $"Produkten av talen är: {tal1 * tal2}\n" +
                              $"Differensen av talen är: {tal1 - tal2}\n" +
                              $"Kvoten av talen är: {tal1 / tal2}\n");

            Console.WriteLine($"\nKlicka någon knapp när du är klar...");
            Console.ReadKey();
        }

        public static void MagicNumbers() //Gör något konstigt med numrena
        {
            Console.Clear();

            Random rnd = new Random();

            Console.Write("Skriv in din skostorlek: ");
            int skoStorlek = Convert.ToInt32(Console.ReadLine());

            Console.Write("Skriv in ditt födelseår: ");
            int födelseÅr = Convert.ToInt32(Console.ReadLine());

            int slumpNr = rnd.Next(10);
            födelseÅr -= slumpNr;
            Console.WriteLine($"\nDitt födelseår minus {slumpNr} är {födelseÅr}");

            slumpNr = rnd.Next(2, 6);
            skoStorlek *= slumpNr;
            Console.WriteLine($"Din skostorlek gånger {slumpNr} är lika med {skoStorlek}");

            slumpNr = rnd.Next(30, 70);
            skoStorlek += slumpNr;
            Console.WriteLine($"Plus {slumpNr} är lika med {skoStorlek}");

            slumpNr = rnd.Next(10, 30);
            skoStorlek *= slumpNr;
            Console.WriteLine($"Gånger {slumpNr} är lika med {skoStorlek}");

            slumpNr = rnd.Next(600, 2000);
            skoStorlek += slumpNr;
            Console.WriteLine($"Plus {slumpNr} är lika med {skoStorlek}");
            Console.WriteLine($"Din skostorlek och ålder: {skoStorlek + födelseÅr}");

            Console.WriteLine($"\nKlicka någon knapp när du är klar...");
            Console.ReadKey();

        }

        public static void AutoHome()
        {

            Console.WriteLine($"\nKlicka någon knapp när du är klar...");
            Console.ReadKey();
        }
        public static void TempConversion()
        {

            Console.WriteLine($"\nKlicka någon knapp när du är klar...");
            Console.ReadKey();
        }

        public static void Menu() //Huvudmeny för programmet
        {
            Console.Clear();
            Console.WriteLine("Klicka på siffran för funktionen du vill testa\n" +
                              "----------------------------------------------\n" +
                              "1. Miniräknaren\n" +
                              "2. Magic numbers\n" +
                              "3. Automatic home\n" +
                              "4. Tempraturomvandling");

            var input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.D1:
                    Calc();
                    break;
                case ConsoleKey.D2:
                    MagicNumbers();
                    break;
                case ConsoleKey.D3:
                    AutoHome();
                    break;
                case ConsoleKey.D4:
                    TempConversion();
                    break;
                default:
                    break;
            }
        }
    }
}