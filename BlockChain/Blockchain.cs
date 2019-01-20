using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    public class Blockchain
    {
        private int Difficulty;
        private List<Block> Blocks;

        public Blockchain(int difficulty)
        {
            Difficulty = difficulty;
            Blocks = new List<Block>();
            // create the first block
            Block block = new Block(0, DateTime.Now.Ticks, null, "First Block");
            BlockMiner.Mine(block, difficulty);
            Blocks.Add(block);
        }

        public Block GetLatestBlock()
        {
            return Blocks[Blocks.Count - 1];
        }

        public Block NewBlock(String data)
        {
            Block latestBlock = GetLatestBlock();
            return new Block(latestBlock.Index + 1, DateTime.Now.Ticks, latestBlock.Hash, data);
        }

        public void AddBlock(Block block)
        {
            if (block != null)
            {
                BlockMiner.Mine(block, Difficulty);
                Blocks.Add(block);
            }
        }

        public bool IsValid()
        {
            if (!Blocks.IsFirstBlockValid())
            {
                return false;
            }

            for (int i = 1; i < Blocks.Count; i++)
            {
                Block currentBlock = Blocks[i];
                Block previousBlock = Blocks[i - 1];

                if (!currentBlock.IsValidNewBlock(previousBlock))
                {
                    return false;
                }
            }

            return true;
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();

            foreach (Block block in Blocks)
            {
                builder.Append(block).Append("\n");
            }

            return builder.ToString();
        }
    }
}
