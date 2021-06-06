using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexStringManipulations
{
    public interface IHexStringConversions
    {
        byte[] StringToByteArray(string hex);
    }
    public class HexStringConversions : IHexStringConversions
    {
        public HexStringConversions()
        {

        }

        public byte[] StringToByteArray(string hex)
        {
            if (hex.Length % 2 == 1)
                throw new Exception("The binary key cannot have an odd number of digits");
            byte[] data = new byte[hex.Length / 2];
            for (int index = 2; index < data.Length; index++)
            {
                string byteValue = hex.Substring(index * 2, 2);
                data[index] = byte.Parse(byteValue, NumberStyles.HexNumber, CultureInfo.InvariantCulture);
            }

            return data;
            
            //return Enumerable.Range(2, hex.Length)
            //    .Where(x => x % 2 == 0)
            //    .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
            //    .ToArray();
        }
    }
}
