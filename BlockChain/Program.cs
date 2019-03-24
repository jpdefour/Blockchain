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
        const int Difficulty = 3;

        static void Main(string[] args)
        {
            Blockchain blockchain = new Blockchain(Difficulty);

            blockchain.AddBlock(blockchain.NewBlock("Cucumber"));
            blockchain.AddBlock(blockchain.NewBlock("Apple"));
            blockchain.AddBlock(blockchain.NewBlock("Banana"));

            Console.WriteLine("Blockchain valid? " + blockchain.IsValid());
            Console.WriteLine(blockchain);
            Console.ReadLine();

        }
    }
}
