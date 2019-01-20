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

            //var someString = "hello";
            //var someBlock = new Block(someString);

            //Stopwatch timer = new Stopwatch();
            //Console.WriteLine("I'm trying to calculate a new block for string \"" + someString + "\" with difficulty " + difficulty);
            //timer.Start();
            //BlockMiner.Mine(someBlock, difficulty);
            //timer.Stop();
            //Console.WriteLine("We got this hash: " + someBlock.Hash);
            //Console.WriteLine("It took this long: " + timer.Elapsed.TotalMilliseconds + " milliseconds");
            //timer.Reset();
            //someString = "goodbye";
            //var anotherBlock = new Block(someString);
            //difficulty = 6;
            //Console.WriteLine("I'm trying to calculate a new block for string \"" + someString + "\" with difficulty " + difficulty);
            //timer.Start();
            //BlockMiner.Mine(anotherBlock, difficulty);
            //timer.Stop();
            //Console.WriteLine("We got this hash: " + anotherBlock.Hash);
            //Console.WriteLine("It took this long: " + timer.Elapsed.TotalMilliseconds + " milliseconds");
            Console.ReadLine();

        }
    }
}
