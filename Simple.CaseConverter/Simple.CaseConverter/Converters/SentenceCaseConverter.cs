using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Simple.CaseConverter.Extensions;

namespace Simple.CaseConverter.Converters;

public static partial class SentenceCaseConverter
{
    public static string ConvertToSentenceCase(string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }
        
        var words = SplitWords(input);
        if (words.Length == 0)
        {
            return input;
        }
        
        for (var i = 0; i < words.Length; i++)
        {
            words[i] = words[i].ToLowerInvariant();
        }
        
        words[0] = CapitalizeFirstLetter(words[0]);
        
        return string.Join(" ", words);
    }

    private static string[] SplitWords(string input)
    {
        var replaced = input.Replace('-', ' ').Replace('_', ' ');
        var parts = replaced.Split([' '], StringSplitOptions.RemoveEmptyEntries);
        var wordsList = new List<string>();
        var camelCaseRegex = CamelCaseRegex();

        foreach (var part in parts)
        {
            var matches = camelCaseRegex.Matches(part);
            if (matches.Count > 0)
            {
                foreach (Match m in matches)
                {
                    wordsList.Add(m.Value);
                }
            }
            else
            {
                wordsList.Add(part);
            }
        }

        return wordsList.ToArray();
    }


    private static string CapitalizeFirstLetter(string word)
    {
        if (string.IsNullOrEmpty(word))
        {
            return word;
        }

        if (word.Length == 1)
        {
            return word.ToUpperInvariant();
        }

        return char.ToUpperInvariant(word[0]) + word.Substring(1);
    }

    [GeneratedRegex(@"([A-Z]?[a-z]+|[A-Z]+(?![a-z])|\d+)", RegexOptions.Compiled)]
    private static partial Regex CamelCaseRegex();
}