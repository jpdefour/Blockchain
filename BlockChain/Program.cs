using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace BlockChain
{
    class Program
    {
        const int Difficulty = 6;

        static void Main(string[] args)
        {
            Console.WriteLine("Creating blockchain with genesis block");
            Blockchain blockchain = new Blockchain(Difficulty);
            Console.WriteLine("Created blockchain with genesis block");

            CreateBlockInBlockchain(blockchain, "Cucumber");
            CreateBlockInBlockchain(blockchain, "Apple");
            CreateBlockInBlockchain(blockchain, "Banana");

            Console.WriteLine("Blockchain valid? " + blockchain.IsValid());
            Console.WriteLine(blockchain);
            Console.ReadLine();
        }

        private static void CreateBlockInBlockchain(Blockchain blockchain, string data)
        {
            Console.WriteLine("Creating block with data: " + data);
            blockchain.AddBlock(blockchain.NewBlock(data));
            Console.WriteLine("Created block with data: " + data);
        }
    }
}
