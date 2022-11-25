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
                        Console.WriteLine($"De oppervlakte van de cirkel is {circle.Area}");
                        break;
                    case ConsoleKey.D3:
                    case ConsoleKey.NumPad3:
                        Console.WriteLine($"De omtrek van de cirkel is {circle.Circumference}");
                        break;
                    case ConsoleKey.D4:
                    case ConsoleKey.NumPad4:
                        Console.WriteLine($"De kleur van de cirkel is {circle.Color}");
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
            Console.WriteLine("1. Maak circel aan");
            Console.WriteLine("2. Geef oppervlakte");
            Console.WriteLine("3. Geef omtrek");
            Console.WriteLine("4. Geef kleur");
            Console.WriteLine("0. STOP");
            return Console.ReadKey().Key;
        }


        /// <summary>Creates the circle.</summary>
        static void CreateCircle()
        {
            Console.WriteLine("Geef de gewenste grootte van de cirkel op als d:4 of s:4");
            string? size = Console.ReadLine();
            circle = new Circle(size);
        }
    }
}