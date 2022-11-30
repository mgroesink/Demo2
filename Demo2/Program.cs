namespace Demo2
{
    public class Program
    {
        static Circle? circle = null;
        static void Main(string[] args)
        {
            ConsoleKey choise= ConsoleKey.D0;
            do
            {
                choise = ShowMenu();
                switch(choise)
                {
                    case ConsoleKey.D0:
                    case ConsoleKey.NumPad0:
                        Environment.Exit(0);
                        break;
                    case ConsoleKey.D1:
                    case ConsoleKey.NumPad1:
                        CreateCircle();
                        break;
                    case ConsoleKey.D2:
                    case ConsoleKey.NumPad2:
                        GetArea();
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        GetCircumference();
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        GetColor();
                        break;

                }
            } while (choise != ConsoleKey.D0 && choise != ConsoleKey.NumPad0);
            Console.ReadKey();
        }

        /// <summary>Shows the menu.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        private static ConsoleKey ShowMenu()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("\t1. Maak circel aan");
            Console.WriteLine("\t2. Geef oppervlakte");
            Console.WriteLine("\t3. Geef omtrek");
            Console.WriteLine("\t4. Geef kleur");
            Console.WriteLine("\t0. STOP");
            Console.WriteLine();
            Console.Write("\tGeef je keuze [ ]");
            Console.CursorLeft = 23;
            return Console.ReadKey().Key;
        }


        /// <summary>Creates the circle.</summary>
        static void CreateCircle()
        {
            try
            {
                Console.Clear();
                Console.WriteLine();
                Console.Write("\tGeef de gewenste grootte van de cirkel op als d:4 of s:4 en bevestig met [Enter] : ");
                string? size = Console.ReadLine();
                circle = new Circle(size);
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"\tEr is een cirkel gemaakt met de kleur {circle.Color}" +
                    $" en met een straal van {circle.Radius}");
                Console.WriteLine("\tDruk op een toets om terug te keren naar het menu ...");
                Console.ReadKey();
            }
            catch (ArgumentException ex)
            {
                Console.Clear();
                Console.WriteLine();
                ConsoleColor oldColor= Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\t" + ex.Message);
                Console.ForegroundColor = oldColor;
                Console.WriteLine();
                Console.WriteLine("\tDruk op een toets om terug te keren naar het menu ...");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Gets the color.
        /// </summary>
        private static void GetColor()
        {
            if (circle == null)
            {
                ShowNoCircleError();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"\tDe kleur van de cirkel is {circle.Color}");
                Console.WriteLine("\tDruk op een toets om terug te keren naar het menu ...");
                Console.ReadKey();
            }
        }

        private static void ShowNoCircleError()
        {
            Console.Clear();
            Console.WriteLine();
            ConsoleColor oldColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\tEr is nog geen cirkel aangemaakt. Kies eerst optie 1 om een cirkel te maken");
            Console.ForegroundColor = oldColor;
            Console.WriteLine();
            Console.WriteLine("\tDruk op een toets om terug te keren naar het menu ...");
            Console.ReadKey();
        }

        /// <summary>
        /// Gets the circumference.
        /// </summary>
        private static void GetCircumference()
        {
            if (circle == null)
            {
                ShowNoCircleError();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"\tDe omtrek van de cirkel is {circle.Circumference}");
                Console.WriteLine("\tDruk op een toets om terug te keren naar het menu ...");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Gets the area.
        /// </summary>
        private static void GetArea()
        {
            if (circle == null)
            {
                ShowNoCircleError();
            }
            else
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine($"\tDe oppervlakte van de cirkel is {circle.Area}");
                Console.WriteLine("\tDruk op een toets om terug te keren naar het menu ...");
                Console.ReadKey();
            }
        }
    }
}