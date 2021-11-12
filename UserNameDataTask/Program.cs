using System;

namespace UserNameDataTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta sinu eesnimi: ");
            string userName = Console.ReadLine();

            Console.WriteLine("Sisesta numbrit (1-3): ");
            int userNumber = Convert.ToInt32(Console.ReadLine());

            switch (userNumber)
            {
                case 1:
                    nameReversed(userName);
                    break;
                case 2:
                    nameFirstLetter(userName);
                    break;
                case 3:
                    nameLength(userName);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }

        }

        public static void nameReversed(string userInput)
        {
            for (int i = userInput.Length - 1; i >= 0; i--)
            {
                Console.Write(userInput[i]);
            }
        }

        public static void nameFirstLetter(string userInput)
        {
            Console.WriteLine($"Sinu eesnime esimene täht on {userInput[0]}");
        }

        public static void nameLength(string userInput)
        {
            Console.WriteLine($"Sinu eesnime sees on {userInput.Length} sümbolit");
        }
    }
}
