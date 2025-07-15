using BenchmarkDotNet.Running;
using Simple.CaseConverter.Benchmarks;

var summary = BenchmarkRunner.Run<CaseConversionBenchmarks>();
