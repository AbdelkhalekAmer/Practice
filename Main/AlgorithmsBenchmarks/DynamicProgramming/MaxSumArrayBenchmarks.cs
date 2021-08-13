using Algorithms.DynamicProgramming;

using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Engines;

using System;

namespace Main.AlgorithmsBenchmarks.DynamicProgramming
{
    [SimpleJob(RunStrategy.Throughput,
        launchCount: 10,
        warmupCount: 10,
        targetCount: 10,
        invocationCount: 10)]
    [IterationsColumn, MinColumn, MaxColumn, MeanColumn, MedianColumn]
    public class MaxSumArrayBenchmarks
    {
        private readonly int[] data;

        public MaxSumArrayBenchmarks()
        {
            data = new int[10000];
            for (int i = 0; i < data.Length; i++) data[i] = new Random().Next(int.MinValue, int.MaxValue);
        }

        [Benchmark]
        public int GetMaxSumByUsingAdditionalArray() => MaxSumArray.GetMaxSumByUsingAdditionalArray(data);

        [Benchmark]
        public int GetMaxSumByUsingTheSameInputArray() => MaxSumArray.GetMaxSumByUsingTheSameInputArray(data);
    }
}
