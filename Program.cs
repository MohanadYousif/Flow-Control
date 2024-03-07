
namespace FlowControl
{
    internal class Program
    {
        // Main method, the entry point of the program
        public static void Main(string[] args)
        {
            bool running = true; // Boolean variable to control the main loop

            // Main loop to keep the program running until the user decides to exit
            while (running)
            {
                // Display the main menu to the user
                UtilityFunctions.PrintOutput("Välkommen till huvudmenyn!"
                + "\n" + "Välj en funktion genom att ange dess nummer:"
                + "\n" + "1. Ungdom eller pensionär"
                + "\n" + "2. Räkna ut pris för ett helt sällskap"
                + "\n" + "3. Upprepa en text tio gånger"
                + "\n" + "4. Det tredje ordet"
                + "\n" + "0. Avsluta programmet");

                // Get user input
                string input = UtilityFunctions.GetInput();

                // Switch statement to handle user input and execute corresponding functions
                switch (input)
                {
                    case "1":
                        UtilityFunctions.GetAgePrice();
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
                        running = false; // Set running to false to exit the loop
                        break;
                    default:
                        UtilityFunctions.PrintOutput("Felaktig input. Var god försök igen." + "\n");
                        break;
                }
                Environment.Exit(0); // Exit the program after executing the chosen function
            }
        }
    }
}