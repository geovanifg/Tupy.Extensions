using System;
using Tupy.Extensions;

namespace Sample
{
    class Program
    {
        static void Main(string[] args)
        {
            var now = DateTime.Now;
            Console.WriteLine(now.ToLong());
            Console.WriteLine(now.ToStringFull());
            Console.WriteLine(now.ToStringYYYYMMDD());

            DateTimeOffset nowoffset = now;
            Console.WriteLine(nowoffset.ToBigInteger());
            Console.WriteLine(nowoffset.ToStringFull());
            Console.WriteLine(nowoffset.ToStringFull("-"));

            Console.ReadKey();
        }
    }
}
