namespace RepetitionLoopar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Hej! Välkommen till spelet.");

            int myNumber = 5;
            int attempts = 3;

            while (attempts > 0)

            {
                Console.WriteLine("Gissa ett nummer: ");
                Console.WriteLine($"Du har {attempts} försök kvar.");
                attempts--;

                int userInput = int.Parse(Console.ReadLine());

                if (userInput == myNumber)
                {
                    Console.WriteLine("Du gissade rätt!");
                    break;
                }

                else if (userInput > myNumber)
                {
                    if (userInput == myNumber +1)
                    {
                        Console.WriteLine("Nu bränns det, du gissade lite för högt bara.");
                    }
                    else
                    {
                        Console.WriteLine("Du gissade för högt");
                    }
                    
                }

                else if (userInput < myNumber)
                {
                    Console.WriteLine("Du gissade för lågt");
                }


            }
            Console.WriteLine("Spelet är slut.");


        }
    }
}