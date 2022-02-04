using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1__DataSecurityEncodingEncryptionPrivacy.Model
{
    internal class BinaryConverter
    {
        //Converting String Value to Binary Value
        public string StringToBinary(string option) // Option might be full name or birth month
        {
            string binaryvalue = "";
            for (int i=0; i < option.Length; i++)  // Modification in the for loop
            {
                string binarycollector = "";
                int number = (int)option[i];           // Used stringarray for indexing instead of character
                while(number > 1)
                {
                    binarycollector = Convert.ToString(number % 2) + binarycollector;
                    number = number/2;
                }
                binarycollector = Convert.ToString(number) + binarycollector;
                binaryvalue = binaryvalue + binarycollector.PadLeft(8, '0');
            }
            Console.WriteLine($"   Binary Value for {option} is: {binaryvalue}");
            return binaryvalue.ToString();
        }
        //Converting Binary Value to String Value
        public string BinaryToString(string binaryvalue)
        {
            string stringvalue = "";
            for (int i = 0; i < binaryvalue.Length; i += 8)
            {
                var first8_bits = binaryvalue.Substring(i, 8);
                var number = Convert.ToInt32(first8_bits, 2);
                stringvalue += (char)number;
            }
            Console.WriteLine($"   String Value for {binaryvalue} is :{stringvalue}");
            return stringvalue;
        }
    }
}
