using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexStringManipulations
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHexStringConversions hexStringConversions = new HexStringConversions();

            Console.WriteLine("Please Enter Current Hex String : ");
            string hexValue = Console.ReadLine();

            byte[] convertedValue = hexStringConversions.StringToByteArray(hexValue);

            Console.WriteLine("Converted Value : ");
            for(int index = 0; index < convertedValue.Length; index++)
            {
                Console.WriteLine("[" + index + "] " + ": " + convertedValue[index].ToString());
            }
            
        } 
    }
}
