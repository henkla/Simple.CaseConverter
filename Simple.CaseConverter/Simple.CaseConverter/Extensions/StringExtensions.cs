using System;
using Simple.CaseConverter.Converters;

namespace Simple.CaseConverter.Extensions;

/// <summary>
/// Provides extension methods for converting string values to various casing styles.
/// </summary>
public static class StringExtensions
{
    /// <summary>
    /// Converts the input string to camelCase.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A camelCase representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToCamelCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return CamelCaseConverter.ConvertToCamelCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to camel case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to PascalCase.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A PascalCase representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToPascalCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return PascalCaseConverter.ConvertToPascalCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to pascal case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to snake_case.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A snake_case representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToSnakeCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return SnakeCaseConverter.ConvertToSnakeCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to snake case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to kebab-case.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A kebab-case representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToKebabCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return KebabCaseConverter.ConvertToKebabCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to kebab case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to SCREAMING_SNAKE_CASE.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A SCREAMING_SNAKE_CASE representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToScreamingSnakeCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return ScreamingSnakeCaseConverter.ConvertToScreamingSnakeCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to screaming snake case. See inner exception for further details.", e);
        }
    }
    
    /// <summary>
    /// Converts the input string to SCREAMING-KEBAB-CASE.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A SCREAMING-KEBAB-CASE representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToScreamingKebabCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return ScreamingKebabCaseConverter.ConvertToScreamingKebabCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to screaming kebab case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to Train-Case.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A Train-Case representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToTrainCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return TrainCaseConverter.ConvertToTrainCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to train case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to Title Case.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A Title Case representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToTitleCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return TitleCaseConverter.ConvertToTitleCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to title case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to Sentence case.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A Sentence case representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToSentenceCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return SentenceCaseConverter.ConvertToSentenceCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to sentence case. See inner exception for further details.", e);
        }
    }
    
    /// <summary>
    /// Converts the input string to lowercase.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A lowercase representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToLowerCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return LowerCaseConverter.ConvertToLowerCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to lower case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Converts the input string to UPPERCASE.
    /// </summary>
    /// <param name="input">The input string to convert.</param>
    /// <returns>A UPPERCASE representation of the input string.</returns>
    /// <exception cref="CaseConverterException">Thrown when an unexpected error occurs during conversion.</exception>
    public static string ToUpperCase(this string input)
    {
        if (input.IsNullOrWhitespace())
        {
            return input;
        }

        try
        {
            return UpperCaseConverter.ConvertToUpperCase(input);
        }
        catch (Exception e) when (e is not CaseConverterException)
        {
            throw new CaseConverterException("An error occurred while converting string to upper case. See inner exception for further details.", e);
        }
    }

    /// <summary>
    /// Determines whether the specified string is null or consists only of white-space characters.
    /// </summary>
    /// <param name="input">The input string to check.</param>
    /// <returns><c>true</c> if the string is null or whitespace; otherwise, <c>false</c>.</returns>
    internal static bool IsNullOrWhitespace(this string input)
    {
        return string.IsNullOrWhiteSpace(input);
    }
}
