using System;

namespace Blockchain
{
    public interface IBlock
    {
        byte[] Data { get; }
        byte[] Hash { get; set; }
        int Nonce { get; set; }
        byte[] PrevHash { get; set; }
        DateTime TimeStamp { get; }
    }


    public class Block : IBlock
    {
        public byte[] Data { get; }

        public byte[] Hash { get; set; }
        public int Nonce { get; set; }
        public byte[] PrevHash { get; set; }

        public DateTime TimeStamp { get; }

        public override string ToString()
        {
            return $"{Data} " + TimeStamp.ToLongDateString();
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
    }
}
