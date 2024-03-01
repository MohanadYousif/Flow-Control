

using System.Reflection.Metadata.Ecma335;

namespace FlowControl
{
    internal class UtilityFunctions
    {

        internal void getAgePrice()
        {
            PrintOutput("Ange ålder:");
            if (int.TryParse(getInput(), out int age))
            {
                int price = CheckAge(age);
                PrintOutput($"Pris: {price} kr" + "\n");
            }
            else
            {
                PrintOutput("Felaktig ålder. Var god ange ålder i siffror." + "\n");
            }
        }

        internal void CalculateGroupPrice()
        {
            PrintOutput("Ange antal personer:");
            if (int.TryParse(getInput(), out int numPeople))
            {
                int totalPrice = 0;
                for (int i = 0; i < numPeople; i++)
                {
                    PrintOutput($"Ålder på person {i + 1}:");
                    if (int.TryParse(getInput(), out int age))
                    {
                        totalPrice += CheckAge(age);
                    }
                    else
                    {
                        PrintOutput($"Felaktig ålder för person {i + 1}. Ålder måste anges i siffror." + "\n");
                        i--; // Återställ loopindex för att låta användaren ange åldern igen.
                    }
                }
                PrintOutput($"Antal personer: {numPeople}\nTotalkostnad: {totalPrice} kr" + "\n");
            }
            else
            {
                PrintOutput("Felaktigt antal personer. Var god ange antal personer i siffror." + "\n");
            }
        }

        internal void RepeatText()
        {
            PrintOutput("Ange en text som ska upprepas:");
            string text = getInput();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {text}, ");
            }
            PrintOutput("\n");
        }

        internal void ThirdWord()
        {
            PrintOutput("Ange en mening med minst 3 ord:");
            string input = getInput();

            // Hantera flera mellanslag i rad genom att dela på alla mellanslag
            //string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] words = input.Split(' ');


            if (words.Length > 2)
            {
                PrintOutput($"Det tredje ordet är: {words[2].Trim()}" + "\n");
            }
            else
            {
                PrintOutput("För få ord angivna. Var god ange minst 3 ord." + "\n");
            }
        }

        private int CheckAge(int age)
        {
            int price;

            if (age < 5 || age > 100)
            {
                price = 0; // Gratis för barn under fem och pensionärer över 100
            }
            else if (age < 20)
            {
                price = 80; // Ungdomspris: 80kr
            }
            else if (age > 64)
            {
                price = 90; // Pensionärspris: 90kr
            }
            else
            {
                price = 120; // Standardpris: 120kr
            }
            return price;
        }

        internal void PrintOutput(string input)
        {
            Console.WriteLine(input);
        }

        internal string getInput()
        {
            return Console.ReadLine();
        }
    }
}
