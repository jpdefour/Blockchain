using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockChain
{
    public class Block
    {
        public int Index { get; }
        public long Timestamp { get; }
        public string Hash { get; set; }
        public string PreviousHash { get; }
        public string Data { get; }
        public int Nonce { get; set; }
        public string CombinedString {
            get 
            {
                return Index + Timestamp + PreviousHash + Data + Nonce; 
            }
        }

        //public Block(string data) 
        //{
        //    Index = 0;
        //    Timestamp = DateTime.Now.Ticks;
        //    PreviousHash = null;
        //    Data = data;
        //    Nonce = 0;
        //    Hash = BlockHashCalculator.CalculateHash(this);
        //}

        public Block(int index, long timestamp, string previousHash, string data)
        {
            Index = index;
            Timestamp = timestamp;
            PreviousHash = previousHash;
            Data = data;
            Nonce = 0;
            Hash = BlockHashCalculator.CalculateHash(this);
        }

        public override string ToString()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Block #").Append(Index).Append(" [previousHash : ").Append(PreviousHash).Append(", ").
            Append("timestamp : ").Append(new DateTime(Timestamp).ToLongDateString()).Append(", ").Append("data : ").Append(Data).Append(", ").
            Append("hash : ").Append(Hash).Append("]");
            return builder.ToString();
        }

    }
}
