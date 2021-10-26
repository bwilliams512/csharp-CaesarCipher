/*
In this project, I write a cipher: a tool to encrypt text, making it unreadable to others. 
I implement the Caesar Cipher, which was used by the Roman Empire to encode military secrets.
*/

using System;

namespace CaesarCipher
{
  class Program
  {
    static void Main(string[] args)
    {
      char[] alphabet = new char[] {'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z'};

      // Ask the user fof a secret message
      Console.Write("Enter a message to encrypt: ");
      string message = Console.ReadLine();
      
      // Convert the captured string to an array
      char[] secretMessage = message.ToCharArray();
      // Create a new, empty array of characters to hold the encrypted message
      char[] encryptedMessage = new char[secretMessage.Length];

      // Perform encryption for every letter in the message
      int i;
      for (i = 0; i < secretMessage.Length; i++) 
      {
        char secretItem = secretMessage[i];
        int index = Array.IndexOf(alphabet, secretItem);
        int letterPosition = (index += 3) % 26;
        
        // Find the new encrypted character by getting the character in the alphabet array with that new position 
        char encryptedCharacter = alphabet[letterPosition];
        encryptedMessage[i] = encryptedCharacter;
      }
      
      string superSecretMessage = String.Join("", encryptedMessage);
      Console.Write(superSecretMessage);
    }
  }
}
