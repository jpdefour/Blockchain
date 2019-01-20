using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    public static class BlockValidator
    {
        public static bool IsFirstBlockValid(this List<Block> blocks)
        {
            Block firstBlock = blocks[0];

            if (firstBlock.Index != 0)
            {
                return false;
            }

            if (firstBlock.PreviousHash != null)
            {
                return false;
            }

            if (IsBlockHashNotNullAndHashValid(firstBlock))
            {
                return false;
            }

            return true;
        }

        public static bool IsValidNewBlock(this Block newBlock, Block previousBlock)
        {
            if (BlocksAreNotNull(newBlock, previousBlock))
            {
                if (previousBlock.Index + 1 != newBlock.Index)
                {
                    return false;
                }

                if (newBlock.PreviousHash == null ||
                    !newBlock.PreviousHash.Equals(previousBlock.Hash))
                {
                    return false;
                }

                if (IsNewBlockPreviousHashNotNullAndPreviousHashValid(newBlock, previousBlock))
                {
                    return false;
                }

                return true;
            }

            return false;
        }

        public static bool IsBlockHashNotNullAndHashValid(Block block)
        {
            return block.Hash == null || !BlockHashCalculator.CalculateHash(block).Equals(block.Hash);
        }

        public static bool IsNewBlockPreviousHashNotNullAndPreviousHashValid(Block newBlock, Block previousBlock)
        {
            return newBlock.PreviousHash == null || !newBlock.PreviousHash.Equals(previousBlock.Hash);
        }

        public static bool BlocksAreNotNull(Block firstBlock, Block secondBlock)
        {
            return firstBlock != null && secondBlock != null;
        }
    }
}
