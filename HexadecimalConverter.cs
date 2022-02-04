using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1__DataSecurityEncodingEncryptionPrivacy.Model
{
    internal class HexadecimalConverter
    {
        //Converting String Value to Hexadecimal Value
        public string StringToHexadecimal(string option)
        {
            string hexastring = "";
            for(int i = 0; i < option.Length; i++)  //Modification
            {
                int x = (int)option[i];   //Modification
                string hexavalue = "";
                while (x != 0)
                {
                    if ((x % 16) < 10)
                        hexavalue = x % 16 + hexavalue;
                    else
                    {
                        string temp = "";
                        switch (x % 16)
                        {
                            case 10: temp = "A"; break;
                            case 11: temp = "B"; break;
                            case 12: temp = "C"; break;
                            case 13: temp = "D"; break;
                            case 14: temp = "E"; break;
                            case 15: temp = "F"; break;
                        }
                        hexavalue = temp + hexavalue;
                    }
                    x /= 16;
                }
                hexastring += hexavalue;
            }
            Console.WriteLine($"   Hexadecimal Value for {option} is: {hexastring}");
            return hexastring;
        }
        //Converting Hexadecimal Value to String Value
        public string HexadecimalToString(string hexa)
        {
            string stringvalue = "";
            for (int j = 0; j < hexa.Length; j += 2)
            {
                var first2_bits = hexa.Substring(j, 2);
                var number = Convert.ToInt32(first2_bits, 16);
                stringvalue += (char)number;
            }
            Console.WriteLine($"   String Value for {hexa} is: " + stringvalue);
            return stringvalue;
        }
    }
}
