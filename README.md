
# Simple.CaseConverter

[![GitHub Repo stars](https://img.shields.io/github/stars/henkla/Simple.CaseConverter)](https://github.com/henkla/Simple.CaseConverter/stargazers)  
[![GitHub Actions Workflow Status](https://img.shields.io/github/actions/workflow/status/henkla/Simple.CaseConverter/nuget-package.yml)](https://github.com/henkla/Simple.CaseConverter/actions)  
[![NuGet version](https://img.shields.io/nuget/v/Simple.CaseConverter.svg?style=flat-square)](https://www.nuget.org/packages/Simple.CaseConverter/)  
[![NuGet Downloads](https://img.shields.io/nuget/dt/Simple.CaseConverter)](https://www.nuget.org/packages/Simple.CaseConverter/)  
[![GitHub Issues](https://img.shields.io/github/issues/henkla/Simple.CaseConverter)](https://github.com/henkla/Simple.CaseConverter/issues)

---

## 🚀 Overview

**Simple.CaseConverter** is a lightweight and efficient .NET library for converting strings between common casing styles such as camelCase, PascalCase, snake_case, kebab-case, and more.  
It focuses on speed, correctness, and simplicity with zero dependencies beyond .NET.

---

## 🔑 Key Features

- 🔄 Supports multiple case conversions: camelCase, PascalCase, snake_case, kebab-case, and more
- ⚡ Extremely fast performance with optimized algorithms
- 🧩 Simple and intuitive API for easy integration
- 🧪 Supports culture-invariant conversions and ASCII/non-ASCII characters
- 📚 Well-tested with comprehensive unit tests
- 🏆 Benchmark results showing performance advantages over similar libraries
- 🧩 Compatible with .NET 8 and later

---

## 📚 Table of Contents

1. [Getting Started](#getting-started)
    - [Installing](#installing)
    - [Usage](#usage)
2. [Casings Supported](#casings-supported)
3. [Benchmark Results](#benchmark-results)
4. [Technical Information](#technical-information)
5. [Known Issues & Limitations](#known-issues--limitations)
6. [Contributing](#contributing)
7. [License](#license)

---

## 🚦 Getting Started

Convert strings easily between different case styles with **Simple.CaseConverter**.

### 📦 Installing

Add the package via NuGet:

```bash
dotnet add package Simple.CaseConverter
```

---

### 🧪 Usage

```csharp
var camel = "hello_world".ToCamelCase();
Console.WriteLine(camel);  // Output: helloWorld
```

---

## 🎯 Casings Supported

* camelCase
* PascalCase
* snake_case
* kebab-case
* SCREAMING_SNAKE_CASE
* SCREAMING-KEBAB-CASE
* Train-Case
* Title Case
* Sentence case
* lowercase
* UPPERCASE
---

## ⚡ Benchmark Results

BenchmarkDotNet v0.13.5, Windows 11, .NET 8.0.0

| Method                        | Mean       | Error    | StdDev   | Median     | Gen0   | Allocated |
|------------------------------ |-----------:|---------:|---------:|-----------:|-------:|----------:|
| ToCamelCaseBenchmark          |   430.6 ns |  7.32 ns |  8.43 ns |   429.5 ns | 0.2275 |     952 B |
| ToPascalCaseBenchmark         |   491.0 ns |  9.34 ns |  8.73 ns |   493.2 ns | 0.2518 |    1056 B |
| ToSnakeCaseBenchmark          |   362.1 ns |  5.32 ns |  4.98 ns |   361.6 ns | 0.1526 |     640 B |
| ToKebabCaseBenchmark          |   364.1 ns |  5.78 ns |  5.40 ns |   363.1 ns | 0.1526 |     640 B |
| ToScreamingSnakeCaseBenchmark |   366.0 ns |  6.42 ns |  6.01 ns |   363.9 ns | 0.1526 |     640 B |
| ToScreamingKebabCaseBenchmark |   371.1 ns |  6.89 ns |  6.45 ns |   373.0 ns | 0.1526 |     640 B |
| ToTrainCaseBenchmark          |   570.8 ns | 11.29 ns | 12.08 ns |   565.6 ns | 0.2518 |    1056 B |
| ToTitleCaseBenchmark          |   584.6 ns |  8.96 ns |  8.39 ns |   582.2 ns | 0.2518 |    1056 B |
| ToSentenceCaseBenchmark       | 1,324.9 ns | 26.17 ns | 66.60 ns | 1,294.1 ns | 0.6809 |    2848 B |
| ToLowerCaseBenchmark          |   387.6 ns |  6.60 ns |  6.17 ns |   386.6 ns | 0.1583 |     664 B |
| ToUpperCaseBenchmark          |   400.6 ns |  7.93 ns | 12.11 ns |   403.9 ns | 0.1583 |     664 B |

---

## 🔬 Technical Information

- Optimized string manipulation algorithms with minimal allocations
- Culture-invariant operations ensuring consistent results
- Supports ASCII and Unicode characters correctly
- Simple API for both specific case methods and general conversion method
- Uses Span\<char> and memory-safe code to maximize performance

---

## 🐞 Known Issues & Limitations

- Currently supports common casing styles only; custom casing styles are not supported yet
- Some edge cases with unusual Unicode characters may not convert perfectly

---

## 🤝 Contributing

Bug reports, feature requests, and pull requests are welcome!  
Please open an issue or submit a PR via [GitHub Issues](https://github.com/henkla/Simple.CaseConverter/issues).

---

## 📄 License

This project is licensed under the MIT License.
