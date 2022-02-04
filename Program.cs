using Assignment1__DataSecurityEncodingEncryptionPrivacy.Model;
using System.Text;
string yesNo;
do
{ 
    Console.WriteLine("                                                  Assignment 1 BDAT 1001-01 Shubham Chawla 200493036");

    //------------------------------------------------- Task 1 - Take Input from User--------------------------------------------------------------------//
    // Ask the User to enter their Full Name
    Console.Write("\nPlease enter your full name: ");
    string name = Console.ReadLine();

    // Ask user to enter their birth Month as well
    Console.Write("Please enter your birth month: ");
    string month = Console.ReadLine();

    // Give the user a choice to convert from
    string opt,choice;
    Console.Write("What would you like to convert? Enter '1' for name and '2' for birth month: ");
    choice = Console.ReadLine();

    // Converting User's Choice into int
    if (int.Parse(choice) == 1)
        opt = name;
    else
        opt = month;

    //------------------------------------------------- Task 2 - Binary Encode Decode -------------------------------------------------------------------//
    Console.Write("\n1. Binary Encoding and Decoding\n");
    BinaryConverter base2 = new BinaryConverter();
    string BinaryData = base2.StringToBinary(opt);
    base2.BinaryToString(BinaryData);

    //------------------------------------------------- Task 3 - Hexadecimal Encode Decode --------------------------------------------------------------//
    Console.Write("\n2. Hexadecimal Encoding and Decoding\n");
    HexadecimalConverter base16 = new HexadecimalConverter();
    string HexaData = base16.StringToHexadecimal(opt);
    base16.HexadecimalToString(HexaData);

    //------------------------------------------------- Task 4 - Base64 Encode Decode -------------------------------------------------------------------//
    Console.Write("\n3. Base64 Encoding and Decoding\n");
    Base64Converter base64 = new Base64Converter();
    string Base64Data = base64.StringToBase64(opt);
    base64.Base64ToString(Base64Data);

    //------------------------------------------------- Task 5 - Encryption Decryption ------------------------------------------------------------------//
    string plaintext = opt;
    int encryptionDepth = 15; //Edited the encryption depth to 15 times.
    Console.Write("\n4. Encryption and Decryption\n");
    int[] key = Encoding.Unicode.GetBytes(plaintext).Select(x => Convert.ToInt32(x)).ToArray(); //Used Unicode here

    for (int i = 0; i < key.Length; i++)
    {
    }
    string cipherasString = String.Join(",", key.Select(x => x.ToString())); //For display purposes
    EncryptDecrypt encrypter = new EncryptDecrypt(plaintext, key, encryptionDepth);
    //Single Level Encryption
    Console.WriteLine("\n   This is the single level encryption: ");
    string nameEncryptWithCipher = EncryptDecrypt.EncryptWithCipher(plaintext, key);
    Console.WriteLine($"\n   Encrypted once using the cipher {{{cipherasString}}} {nameEncryptWithCipher}");
    string nameDecryptWithCipher = EncryptDecrypt.DecryptWithCipher(nameEncryptWithCipher, key);
    Console.WriteLine($"   Decrypted once using the cipher {{{cipherasString}}} {nameDecryptWithCipher}");
    //Deep Encryption
    Console.WriteLine("\n   This is the deep level encryption: ");
    string nameDeepEncryptWithCipher = EncryptDecrypt.DeepEncryptWithCipher(plaintext, key, encryptionDepth);
    Console.WriteLine($"\n   Deep Encrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepEncryptWithCipher}");
    string nameDeepDecryptWithCipher = EncryptDecrypt.DeepDecryptWithCipher(nameDeepEncryptWithCipher, key, encryptionDepth);
    Console.WriteLine($"   Deep Decrypted {encryptionDepth} times using the cipher {{{cipherasString}}} {nameDeepDecryptWithCipher}");
    Console.Write("\nPress any key to exit or 'y' to perform another conversion: ");
    yesNo = Console.ReadLine().ToLower();

} while (yesNo.Equals("y"));
