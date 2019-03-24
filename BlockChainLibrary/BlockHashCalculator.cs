using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    public static class BlockHashCalculator
    {
        public static String CalculateHash(Block block)
        {
            if (block?.CombinedString != null)
            {
                SHA256Managed crypto;

                try
                {
                    crypto = new SHA256Managed();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine(e.InnerException);
                    Console.ReadLine();
                    return null;
                }

                var txt = block.CombinedString;
                byte[] bytes = crypto.ComputeHash(Encoding.ASCII.GetBytes(txt));
                StringBuilder builder = new StringBuilder();

                foreach (byte b in bytes)
                {
                    var hex = (0xff & b).ToString("x");

                    if (hex.Count() == 1)
                    {
                        builder.Append('0');
                    }

                    builder.Append(hex);
                }

                return builder.ToString();
            }

            return null;
        }
    }
}
