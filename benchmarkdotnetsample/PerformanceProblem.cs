using BenchmarkDotNet.Attributes;
using System;
using System.Linq;
using System.Text;

namespace benchmarkdotnetsample
{
    public class PerformanceProblem
    {
        public PerformanceProblem()
        {

        }
        [Benchmark]
        public string StringConcat()
        {
            return String.Concat(Enumerable.Repeat("a", 1000).ToArray());
        }

        [Benchmark]
        public string StringBuilder()
        {
            StringBuilder sb = new System.Text.StringBuilder();
            sb.Append('a', 1000);
            return sb.ToString();
        }

    }
}
