using System;

namespace SequenceLOL
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 12; i < 900; i=i+111)
            {
            string data = i.ToString();
            Console.WriteLine("Sequence :" + i);
            }
            Console.WriteLine("Birinci 12-ye fikir vermeyin:)");
            Console.ReadLine();
        }
    }
}
