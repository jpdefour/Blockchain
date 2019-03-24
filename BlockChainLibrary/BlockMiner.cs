using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    public static class BlockMiner
    {
        public static void Mine(Block block, int zeroes)
        {
            block.Nonce = 0;

            while (!HashHasStartingZeroes(block.Hash, zeroes))
            {
                block.Nonce++;
                block.Hash = BlockHashCalculator.CalculateHash(block);
            }
        }

        private static bool HashHasStartingZeroes(string hash, int startingZeroes)
        {
            return hash.Substring(0, startingZeroes).Equals(NumberOfZeroes(startingZeroes));
        }

        private static string NumberOfZeroes(int difficulty)
        {
            StringBuilder stringBuilder = new StringBuilder();
            for (var i = difficulty; i > 0; i--)
            {
                stringBuilder.Append('0');
            }
            return stringBuilder.ToString();
        }
    }
}
