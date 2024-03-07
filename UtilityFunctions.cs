
namespace FlowControl
{
    internal class UtilityFunctions
    {
        // Method to get the age price
        internal static void GetAgePrice()
        {
            PrintOutput("Ange ålder:"); // Prompt user to enter age
            if (int.TryParse(GetInput(), out int age)) // Try parsing user input to integer
            {
                int price = CheckAge(age); // Get price based on age
                PrintOutput($"Pris: {price} kr" + "\n"); // Print the price
            }
            else
            {
                PrintOutput("Felaktig ålder. Var god ange ålder i siffror." + "\n"); // Error message for invalid age input
            }
        }

        // Method to calculate group price
        internal static void CalculateGroupPrice()
        {
            PrintOutput("Ange antal personer:"); // Prompt user to enter number of people
            if (int.TryParse(GetInput(), out int numPeople)) // Try parsing user input to integer
            {
                int totalPrice = 0;
                for (int i = 0; i < numPeople; i++)
                {
                    PrintOutput($"Ålder på person {i + 1}:"); // Prompt user to enter age for each person
                    if (int.TryParse(GetInput(), out int age)) // Try parsing user input to integer
                    {
                        totalPrice += CheckAge(age); // Add price based on age to total price
                    }
                    else
                    {
                        PrintOutput($"Felaktig ålder för person {i + 1}. Ålder måste anges i siffror." + "\n"); // Error message for invalid age input
                        i--; // Reset loop index to allow user to enter age again
                    }
                }
                PrintOutput($"Antal personer: {numPeople}\nTotalkostnad: {totalPrice} kr" + "\n"); // Print total number of people and total price
            }
            else
            {
                PrintOutput("Felaktigt antal personer. Var god ange antal personer i siffror." + "\n"); // Error message for invalid number of people input
            }
        }

        // Method to repeat text ten times
        internal static void RepeatText()
        {
            PrintOutput("Ange en text som ska upprepas:"); // Prompt user to enter text
            string text = GetInput(); // Get text input from user
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {text}, "); // Print text ten times
            }
            PrintOutput("\n"); // Add newline after repeating text
        }

        // Method to find the third word in a sentence
        internal static void ThirdWord()
        {
            PrintOutput("Ange en mening med minst 3 ord:"); // Prompt user to enter a sentence
            string input = GetInput(); // Get sentence input from user

            string[] words = input.Split(' '); // Split sentence into words

            if (words.Length > 2) // Check if there are at least 3 words in the sentence
            {
                PrintOutput($"Det tredje ordet är: {words[2].Trim()}" + "\n"); // Print the third word
            }
            else
            {
                PrintOutput("För få ord angivna. Var god ange minst 3 ord." + "\n"); // Error message for insufficient words
            }
        }

        // Method to check age and determine price
        private static int CheckAge(int age)
        {
            int price;

            if (age < 5 || age > 100)
            {
                price = 0; // Free for children under five and seniors over 100
            }
            else if (age < 20)
            {
                price = 80; // Youth price: 80 SEK
            }
            else if (age > 64)
            {
                price = 90; // Senior price: 90 SEK
            }
            else
            {
                price = 120; // Standard price: 120 SEK
            }
            return price;
        }

        // Method to print output to console
        internal static void PrintOutput(string input)
        {
            Console.WriteLine(input);
        }

        // Method to get input from console
        internal static string GetInput()
        {
            return Console.ReadLine();
        }
    }
}