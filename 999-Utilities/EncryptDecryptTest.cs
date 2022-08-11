using System;

namespace CSharpSeleniumTraining {
    public class EncryptDecryptTest {
        static void Main (string[] args) {
            Console.WriteLine("Please enter a string for encryption");  
            var userName = Console.ReadLine();  

            string encryptedUserName = EncryptDecrypt.Encrypt (userName );

            string decryptedUserName = EncryptDecrypt.Decrypt (encryptedUserName);

            if (decryptedUserName.Equals (userName)) {
                Console.WriteLine ("User Name Matches");
                Console.WriteLine (decryptedUserName);
            }
        }

    }
}