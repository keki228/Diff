using System;
using System.IO;

namespace Diff
{
    static class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 2)
                return;

            string a = System.IO.File.ReadAllText(args[0]);
            string b = System.IO.File.ReadAllText(args[1]);

            Result.CreateResult(a, b);
            

        }
    }
}
