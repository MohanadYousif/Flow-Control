using Bio;

namespace FlowControl
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            bool running = true;

            // Huvudmeny
            while (running)
            {
                UtilityFunctions.PrintMethod("Välkommen till huvudmenyn!"
                + "\n" + "Välj en funktion genom att ange dess nummer:"
                + "\n" + "1. Ungdom eller pensionär"
                + "\n" + "2. Räkna ut pris för ett helt sällskap"
                + "\n" + "3. Upprepa en text tio gånger"
                + "\n" + "4. Det tredje ordet"
                + "\n" + "0. Avsluta programmet");

                string input = UtilityFunctions.getInput();

                switch (input)
                {
                    case "1":
                        UtilityFunctions.CheckAge();
                        break;
                    case "2":
                        UtilityFunctions.CalculateGroupPrice();
                        break;
                    case "3":
                        UtilityFunctions.RepeatText();
                        break;
                    case "4":
                        UtilityFunctions.ThirdWord();
                        break;
                    case "0":
                        running = false;
                        break;
                    default:
                        UtilityFunctions.PrintMethod("Felaktig input. Var god försök igen." + "\n");
                        break;
                }
            }
        }
    }
}

