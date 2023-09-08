namespace Number_guesser_1300
{
    internal class Program
    {


        static void Main(string[] args)
        {
            // Hilfe von anderen Schülern
            AnzahlVersuche gebrauchteVersuche = new AnzahlVersuche();
            
            // Inspiration von einem früheren Projekt
            Console.ForegroundColor = ConsoleColor.DarkBlue;


            int secretNumber = new Random().Next(1, 1001);
            int zahl = 0;

            do
            {


                try
                {
                    Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 1000 ein");
                    zahl = Convert.ToInt32(Console.ReadLine());
                    gebrauchteVersuche.gebrauchteVersuche++;

                    if (zahl >= 1 && zahl <= 1000)
                    {
                        if (zahl < secretNumber)
                        {
                            Console.WriteLine("Die gesuchte Zahl ist grösser");
                        }
                        else if (zahl > secretNumber)
                        {
                            Console.WriteLine("Die gesuchte Zahl ist kleiner");
                        }
                        else if (zahl == secretNumber)
                        {
                            Console.WriteLine("Herzlichen Glückwunsch! Sie haben die gesuchte Zahl in {0} Versuchen erraten!", gebrauchteVersuche.gebrauchteVersuche);
                        }




                    }
                    else
                    {
                        Console.WriteLine("Falsche Eingabe, es werden nur Zahlen zwischen 1 und 1000 akzeptiert.");
                        Thread.Sleep(1000);

                    }
                }
                catch (Exception ex)
                {


                    Console.WriteLine("Keine Buchstaben, nur Zahlen bitte.");
                    Thread.Sleep(1000);

                }









            } while (zahl != secretNumber);

            Console.WriteLine("Möchten Sie erneut eine Runde spielen? Ja/Nein");
            string neueRunde = Console.ReadLine();

            // if-Zeile von ChatGPT, der Rest gleich wie oben
            if ((neueRunde.Trim().Equals("Ja", StringComparison.OrdinalIgnoreCase)))
            {
                do
                {


                    try
                    {
                        Console.WriteLine("Bitte geben Sie eine Zahl zwischen 1 und 1000 ein");
                        zahl = Convert.ToInt32(Console.ReadLine());
                        gebrauchteVersuche.gebrauchteVersuche++;

                        if (zahl >= 1 && zahl <= 1000)
                        {
                            if (zahl < secretNumber)
                            {
                                Console.WriteLine("Die gesuchte Zahl ist grösser");
                            }
                            else if (zahl > secretNumber)
                            {
                                Console.WriteLine("Die gesuchte Zahl ist kleiner");
                            }
                            else if (zahl == secretNumber)
                            {
                                Console.WriteLine("Herzlichen Glückwunsch! Sie haben die gesuchte Zahl in {0} Versuchen erraten!", gebrauchteVersuche.gebrauchteVersuche);
                            }




                        }
                        else
                        {
                            Console.WriteLine("Falsche Eingabe, es werden nur Zahlen zwischen 1 und 1000 akzeptiert.");
                            Thread.Sleep(1000);

                        }
                    }
                    catch (Exception ex)
                    {


                        Console.WriteLine("Keine Buchstaben, nur Zahlen bitte.");
                        Thread.Sleep(1000);

                    }









                } while (zahl != secretNumber);
            }
            else
            {
                Console.WriteLine("Danke fürs Spielen! Schönen Tag noch und bis zum nächsten Mal!");
            }
        }
    }
}