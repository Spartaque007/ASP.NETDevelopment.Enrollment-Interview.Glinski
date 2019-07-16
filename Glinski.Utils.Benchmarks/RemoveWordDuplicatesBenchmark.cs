using BenchmarkDotNet.Attributes;
using Gliski.Utils;
using System.IO;
using System.Numerics;
using System.Text;

namespace Glinski.Utils.Benchmarks
{
    public class RemoveWordDuplicatesBenchmark
    {
        string text;

        public RemoveWordDuplicatesBenchmark()
        {
            string path = @"C:\Users\SPARTAQUE\Desktop\A_chto_vy_hoteli_ot_Baby-jagi.txt";

            text = File.ReadAllText(path, Encoding.UTF8);
        }
        

        [Benchmark]
        public string Dictionry() => StringCouter.RemoveDuplicateWords2(text);
    }
}
