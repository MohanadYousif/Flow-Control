
namespace FlowControl
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;
            UtilityFunctions utilityFunctions = new UtilityFunctions();

            // Huvudmeny
            while (running)
            {
                utilityFunctions.PrintOutput("Välkommen till huvudmenyn!"
                + "\n" + "Välj en funktion genom att ange dess nummer:"
                + "\n" + "1. Ungdom eller pensionär"
                + "\n" + "2. Räkna ut pris för ett helt sällskap"
                + "\n" + "3. Upprepa en text tio gånger"
                + "\n" + "4. Det tredje ordet"
                + "\n" + "0. Avsluta programmet");

                string input = utilityFunctions.getInput();

                switch (input)
                {
                    case "1":
                        utilityFunctions.getAgePrice();
                        break;
                    case "2":
                        utilityFunctions.CalculateGroupPrice();
                        break;
                    case "3":
                        utilityFunctions.RepeatText();
                        break;
                    case "4":
                        utilityFunctions.ThirdWord();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        utilityFunctions.PrintOutput("Felaktig input. Var god försök igen." + "\n");
                        break;
                }
                Environment.Exit(0);
            }
        }
    }
}

