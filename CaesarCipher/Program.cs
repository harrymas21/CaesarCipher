using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaesarCipher.Utils;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            CipherUtility cipherUtility = new CipherUtility();

            Console.WriteLine("Type a string to encrypt: ");
            string userInput = Console.ReadLine();
            Console.WriteLine("\n");

            Console.Write("Enter your Key: ");
            int key = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Encrypted Data");

            string cipherText = cipherUtility.Encipher(userInput, key);
            Console.WriteLine(cipherText);
            Console.Write("\n");

            Console.WriteLine("Decrypted Data: ");

            string t = cipherUtility.Decipher(cipherText, key);
            Console.WriteLine(t);
            Console.Write("\n");

            Console.ReadKey();
        }
    }
}
