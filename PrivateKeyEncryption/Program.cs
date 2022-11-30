using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateKeyEncryption
{
   
     class Program
    {
        static void Main(string[] args)
        {
            RsaEncryption rsa = new RsaEncryption();
            string cypher = string.Empty;
            Console.WriteLine($"Klucz publiczny {rsa.GetPublicKey()}");

            Console.WriteLine("Proszę podaj twój text do zaszyfrowania:");
            var text = Console.ReadLine();
            if (!string.IsNullOrEmpty(text))
            {
                cypher = rsa.Encrypt(text);
                Console.WriteLine($"Encrypted Text: {cypher}");
            }

            Console.WriteLine("Nacisnij klawisz aby odszyfrować twój tekst");
            Console.ReadLine();
            var plainText = rsa.Decrypt(cypher);

            Console.WriteLine($"Decrypted Message: {plainText}");
            Console.ReadLine();
        }
    }
}
