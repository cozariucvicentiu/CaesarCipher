using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CeasarCipher();
        }

        private static void CeasarCipher()
        {
            Console.WriteLine("Introduceti textul pentru criptare:");
            string plainText = Console.ReadLine();
            int shift = 3;
            string cipherText = CaesarEncrypt(plainText, shift);
            Console.WriteLine("Encrypted:" + cipherText);
            string decryptedText = CaesarDecrypt(cipherText, shift);
            Console.WriteLine("Decrypted: " + decryptedText);
            Console.ReadKey();
        }

        private static string CaesarDecrypt(string cipherText, int shift)
        {
            string plainText="";
            foreach(char c in cipherText)
            {
                if(char.IsLetter(c))
                {
                    char lowerC = char.ToLower(c);
                    char shifted = (char)(((lowerC - shift - 'a' + 26) % 26) + 'a');
                    plainText += shifted;
                }
                else
                {
                    plainText += c;
                }
            }
            return plainText;
        }

        private static string CaesarEncrypt(string plainText, int shift)
        {
            string cipherText = "";
            foreach (char c in plainText)
            {
                if(char.IsLetter(c))
                {
                    char lowerC=char.ToLower(c);
                    char shifted = (char)(((lowerC + shift - 'a') % 26) + 'a');
                    cipherText += shifted;
                }
                else
                {
                    cipherText += c;
                }
            }
            return cipherText;
        }
    }
}
