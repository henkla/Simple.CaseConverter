using BenchmarkDotNet.Attributes;
using Simple.CaseConverter.Extensions;

namespace Simple.CaseConverter.Benchmarks;

[MemoryDiagnoser]
public class CaseConversionBenchmarks
{
    private const string TestString = "thisIsAString123ToTest";

    [Benchmark] public string ToCamelCaseBenchmark() => TestString.ToCamelCase();
    [Benchmark] public string ToPascalCaseBenchmark() => TestString.ToPascalCase();
    [Benchmark] public string ToSnakeCaseBenchmark() => TestString.ToSnakeCase();
    [Benchmark] public string ToKebabCaseBenchmark() => TestString.ToKebabCase();
    [Benchmark] public string ToScreamingSnakeCaseBenchmark() => TestString.ToScreamingSnakeCase();
    [Benchmark] public string ToScreamingKebabCaseBenchmark() => TestString.ToScreamingKebabCase();
    [Benchmark] public string ToTrainCaseBenchmark() => TestString.ToTrainCase();
    [Benchmark] public string ToTitleCaseBenchmark() => TestString.ToTitleCase();
    [Benchmark] public string ToSentenceCaseBenchmark() => TestString.ToSentenceCase();
    [Benchmark] public string ToLowerCaseBenchmark() => TestString.ToLowerCase();
    [Benchmark] public string ToUpperCaseBenchmark() => TestString.ToUpperCase();
}