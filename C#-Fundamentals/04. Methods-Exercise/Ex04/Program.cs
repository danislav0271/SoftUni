using System;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int passwordMinLength = 6;
            const int passwordMaxLength = 10;
            const int passwordMinDigitsCount = 2;

            string password = Console.ReadLine();

            bool isPasswordValid = PasswordValidator(password, passwordMinLength, passwordMaxLength, passwordMinDigitsCount);

            if (isPasswordValid)
            {
                Console.WriteLine("Password is valid");
            }
        }

        static bool PasswordValidator(string password, int passwordMinLength, int passwordMaxLength, int passwordMinDigitsCount)
        {
            bool isPasswordValid = true;
            if (!ValidatePasswordLength(password, passwordMinLength, passwordMaxLength))
            {
                Console.WriteLine($"Password must be between {passwordMinLength} and {passwordMaxLength} characters");
                isPasswordValid = false;
            }

            if (!ValidatePasswordIsAlphaNumerical(password))
            {
                Console.WriteLine("Password must consist only of letters and digits");
                isPasswordValid = false;
            }

            if (!ValidatePasswordDigitsMinCount(password, passwordMinDigitsCount))
            {
                Console.WriteLine($"Password must have at least {passwordMinDigitsCount} digits");
                isPasswordValid = false;
            }

            return isPasswordValid;
        }

        static bool ValidatePasswordLength(string password, int minLength, int maxLength)
        {
            if (password.Length >= minLength && password.Length <= maxLength)
            {
                return true;
            }

            return false;
        }

        static bool ValidatePasswordIsAlphaNumerical(string password)
        {
            foreach (char ch in password)
            {
                if (!Char.IsLetterOrDigit(ch))
                {
                    return false;
                }
            }

            return true;
        }

        static bool ValidatePasswordDigitsMinCount(string password, int minDigitsCount)
        {
            int digitCount = 0;

            foreach (char ch in password)
            {
                if (Char.IsDigit(ch))
                {
                    digitCount++;
                }
            }

            return digitCount >= minDigitsCount;
        }
    }
}
