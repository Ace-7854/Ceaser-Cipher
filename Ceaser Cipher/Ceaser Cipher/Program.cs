using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ceaser_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the key");
            int Key = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Enter the phrase");
            string plaintext = Console.ReadLine();

            string[] alphabet = "A B C D E F G H I J K L M N O P Q R S T U V W X Y Z"
                .Split(' ');

            string[] cipher = GetNewCipher(Key, alphabet);

            //DisplayArray(cipher);

            Console.WriteLine("Encrypt or Decrypt (E/D)");
            string Task = Console.ReadLine().ToUpper();

            if (Task == "D")
                ;//Decrypt method here
            else if (Task == "E")
                ;//Encrypt method here
        }

        static string[] GetNewCipher(int Key, string[] Alphabet)
        {
            string[] Cipher = new string[Alphabet.Length];
            int index = Key;
            string frontOfCipher = "";
            int AlphIndex = 0;
            do
            {
                if (index == 26)
                    index = 0;
                Cipher[index] = Alphabet[AlphIndex];
                index++;
                AlphIndex++;
            } while (index != Key);

            return Cipher;
        }

        static void DisplayArray(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"{i}: {arr[i]}");
            }
        }

        static void Encrypt(string[] Cipher, string[] Alphabet, string Plaintext)
        {
            string Encrypted = "";
            for (int i = 0; i < Plaintext.Length; i++)
            {
                string ItemToFind = Plaintext[i].ToString();

                if (ItemToFind != " ")
                {
                    
                }
            }
        }

        static void Decrypt(string[] Cipher, string[] Alphabet, string Plaintext)
        {
            
        }
    }
}
