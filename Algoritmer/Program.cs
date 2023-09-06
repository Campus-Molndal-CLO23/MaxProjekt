namespace Algoritmer
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true) //Kör förevigt
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
            Console.Clear();

            string[] nummer = {"Ett", "Två", "Tre", "Fyra", "Fem", "Sex", "Sju", "Åtta", "Nio", "Tio", "Elva", "Tolv"}; //Nummer i text format i en lista
            Console.Write("Tid på dygnet per heltimma (1-24): ");
            int tid = Convert.ToInt32(Console.ReadLine());
            string tidPåDagen = "ERROR";

            if (tid > 12 && tid < 25)  //Konverterar 24 -> 12, 22 -> 10 osv... om numret är över 12
                tidPåDagen = nummer[(tid - 12) - 1];
            else if(tid < 12 && tid > 0)
                tidPåDagen = nummer[tid - 1];




            switch (tid > 24 || tid < 1 ? "Ogiltligt" : // Högre än 24 eller mindre än 1 (Ogiltligt)
                    tid > 20 || tid < 7 ? "Natt" : // Högre än 20 eller mindre än 7 (21-06)
                    tid > 17 && tid < 21 ? "Kväll" : // Högre än 17 och mindre än 21 (18-20)
                    tid > 9 && tid < 18 ? "Dag" : "Morgon") // Högre än 9 och mindre än 18 (10-17) resten morgon (07-09)
            {
                case "Natt":
                    Console.WriteLine($"{tidPåDagen} på natten: Alla sover, dörrar låsta, lampor av, gräsklippare av osv");
                    break;
                case "Morgon":
                    Console.WriteLine($"{tidPåDagen} på morgonen: Kaffemaskinen på, lampor tända, lugn musik på");
                    break;
                case "Dag":
                    Console.WriteLine($"{tidPåDagen} på dagen: Kaffemaskinen av, alla lampor av, musik av, dörrar låsta, diskmaskin på, tvättmaskin på");
                    break;
                case "Kväll":
                    Console.WriteLine($"{tidPåDagen} på kvällen: Lampor på, musik av, TV på, gräsklippare på");
                    break;
                default:
                    Console.WriteLine("Ogiltligt tal");
                    break;
            }

            Console.WriteLine($"\nKlicka någon knapp när du är klar...");
            Console.ReadKey();
        }
        public static void TempConversion() //Omvandlar temperatur
        {
            Console.Clear();

            Console.Write("Ange Temperatur.\n" +
                              "Temperaturen avslutas med\n" +
                              "C för Celcius\n" +
                              "F för Fahrenheit\n" +
                              "K för Kelvin\n" +
                              "Ange Temperatur: ");

            string input = Console.ReadLine();
            string tempStr = input.Remove(input.Length - 1, 1);
            double temp = Convert.ToDouble(tempStr);
            string type;

            if(input.EndsWith('C'))
            {
                type = "Celcius";
                Console.WriteLine($"{type} till Farenheit: {(temp * 1.8) + 32}\n" +
                                  $"{type} till Kelvin: {temp + 273.15}\n");
            }
            else if(input.EndsWith('F'))
            {
                type = "Farenheit";
                Console.WriteLine($"{type} till Celcius: {(temp - 32) / 1.8}\n" +
                                  $"{type} till Kelvin: {(temp - 32) / 1.8 + 273.15}\n");
            }
            else if(input.EndsWith('K'))
            {
                type = "Kelvin";
                Console.WriteLine($"{type} till Farenheit: {(temp -273.15) * 1.8 + 32}\n" +
                                  $"{type} till Celcius: {temp - 273.15}\n");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }

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
                              "4. Temperaturomvandling\n" +
                              "----------------------------------------------");

            var input = Console.ReadKey(); //Registrerar vad du klickar på
            switch (input.Key)
            {
                case ConsoleKey.D1: //Om du har klickat på siffran 1...
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