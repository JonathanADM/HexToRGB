using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexToRGB
{
    public class HexToRGBClass
    {
        public int[] ConvertToRGB(string hex)
        {
            if (hex.Length !=6)
            {
                throw new ArgumentException("Debe contener 6 digitos");
            }

            hex = hex.ToUpper();
            int[] RGB = new int[3];
            int j = 0;

            for (int i = 0; i < hex.Length; i++)
            {
                int hexChar = CharToInt(hex[i]);
                int hexChar2 = CharToInt(hex[i + 1]);
                RGB[j] = (hexChar * 16) + hexChar2;
                i++;
                j++;
            }
            return RGB;
        }

        public int CharToInt(char c)
        {
            try
            {
                if (c == 'A') return 10;
                else if (c == 'B') return 11;
                else if (c == 'C') return 12;
                else if (c == 'D') return 13;
                else if (c == 'E') return 14;
                else if (c == 'F') return 15;
                else return int.Parse(c.ToString());
            }
            catch (Exception)
            {
                throw new ArgumentException("Algun caracter no pertenece al formato hexadecimal");
            }
            
        }
    }
}
