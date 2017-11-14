using BenchmarkDotNet.Running;

namespace benchmarkdotnetsample
{
    class Program
    {
        static void Main(string[] args)
        {
            var summary = BenchmarkRunner.Run(typeof(PerformanceProblem));
        }
    }
}
