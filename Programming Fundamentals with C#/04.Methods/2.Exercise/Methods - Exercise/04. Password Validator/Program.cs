using System;

namespace _04._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string password = Console.ReadLine();

            bool isCharaktersLenghttrue = CharaktersLEnght(password);
            bool isLettersAndDigitsTrue = OnlyCharaktersAndDigits(password);
            bool isDigitsLenghtTrue = DigitsLenght(password);

            if (!isCharaktersLenghttrue)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!isLettersAndDigitsTrue)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!isDigitsLenghtTrue)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }

            if (isCharaktersLenghttrue && isLettersAndDigitsTrue && isDigitsLenghtTrue)
            {
                Console.WriteLine("Password is valid");
            }
        }

        private static bool DigitsLenght(string password)
        {
            int count = 0;

            foreach (char symbol in password)
            {
                if (char.IsDigit(symbol))
                {
                    count++;
                }
            }

            return count >= 2;
        }

        private static bool OnlyCharaktersAndDigits(string password)
        {
            foreach (char symbol in password)
            {
                if (!char.IsLetterOrDigit(symbol))
                {
                    return false;
                }
            }
            return true;
        }

        private static bool CharaktersLEnght(string password)
        {
            return password.Length >= 6 && password.Length <= 10;
        }
    }
}
