
namespace Bio
{
    internal class UtilityFunctions
    {

        public static void CheckAge()
        {
            PrintMethod("Ange ålder:");
            if (int.TryParse(getInput(), out int age))
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
                PrintMethod($"Pris: {price} kr" + "\n");
            }
            else
            {
                PrintMethod("Felaktig ålder. Var god ange ålder i siffror." + "\n");
            }
        }

        public static void CalculateGroupPrice()
        {
            PrintMethod("Ange antal personer:");
            if (int.TryParse(getInput(), out int numPeople))
            {
                int totalPrice = 0;
                for (int i = 0; i < numPeople; i++)
                {
                    PrintMethod($"Ålder på person {i + 1}:");
                    if (int.TryParse(getInput(), out int age))
                    {
                        if (age < 5 || age > 100)
                        {
                            continue; // Gratis för barn under fem och pensionärer över 100
                        }
                        else if (age < 20)
                        {
                            totalPrice += 80; // Ungdomspris: 80kr
                        }
                        else if (age > 64)
                        {
                            totalPrice += 90; // Pensionärspris: 90kr
                        }
                        else
                        {
                            totalPrice += 120; // Standardpris: 120kr
                        }
                    }
                    else
                    {
                        PrintMethod($"Felaktig ålder för person {i + 1}. Ålder måste anges i siffror." + "\n");
                        i--; // Återställ loopindex för att låta användaren ange åldern igen.
                    }
                }
                PrintMethod($"Antal personer: {numPeople}\nTotalkostnad: {totalPrice} kr" + "\n");
            }
            else
            {
                PrintMethod("Felaktigt antal personer. Var god ange antal personer i siffror." + "\n");
            }
        }

        public static void RepeatText()
        {
            PrintMethod("Ange en text som ska upprepas:");
            string text = getInput();
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"{i + 1}. {text}, ");
            }
            PrintMethod("\n");
        }

        public static void ThirdWord()
        {
            PrintMethod("Ange en mening med minst 3 ord:");
            string input = getInput();

            // Hantera flera mellanslag i rad genom att dela på alla mellanslag
            //string[] words = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string[] words = input.Split(' ');


            if (words.Length > 2)
            {
                PrintMethod($"Det tredje ordet är: {words[2].Trim()}" + "\n");
            }
            else
            {
                PrintMethod("För få ord angivna. Var god ange minst 3 ord." + "\n");
            }
        }

        public static void PrintMethod(string input)
        {
            Console.WriteLine(input);
        }

        public static string getInput()
        {
            return Console.ReadLine();
        }

    }
}
