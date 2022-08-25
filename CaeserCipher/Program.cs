using System;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j',
            'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

            Console.WriteLine("Please insert your secret message here:");
            string userMessage = Console.ReadLine();
            string lowerUserMessage = userMessage.ToLower();

            char[] secretMessage = lowerUserMessage.ToCharArray();

            char[] encryptedMessage = new char[secretMessage.Length];

            for (int i = 0; i < secretMessage.Length; i++)
            {
                char letter = secretMessage[i];
                int charIndex = Array.IndexOf(alphabet, letter);
                int letterPosition = (charIndex += 3) % 26;
                char encryptedCharacter = alphabet[letterPosition];
                encryptedMessage[i] = encryptedCharacter;
            }

            string decryptedMessage = String.Join("", encryptedMessage);
            Console.WriteLine(encryptedMessage);

        }
    }

}