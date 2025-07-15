using Shouldly;
using Simple.CaseConverter.Extensions;

namespace Simple.CaseConverter.Tests.Extensions;

public class StringExtensionsTests
{
    [Theory]
    [InlineData("this should be converted", "thisShouldBeConverted")]
    [InlineData("ThisShouldBeConverted", "thisShouldBeConverted")]
    [InlineData("this-should-be-converted", "thisShouldBeConverted")]
    [InlineData("this_should_be_converted", "thisShouldBeConverted")]
    [InlineData("THIS SHOULD BE CONVERTED", "thisShouldBeConverted")]
    [InlineData("This Should Be Converted", "thisShouldBeConverted")]
    [InlineData("  this   should    be  converted  ", "thisShouldBeConverted")] 
    [InlineData("t", "t")] 
    [InlineData("T", "t")] 
    [InlineData("123 start with numbers", "123StartWithNumbers")]
    [InlineData("camelCaseAlready", "camelCaseAlready")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "thisHas123Numbers")] 
    [InlineData("with_special$characters!", "withSpecialCharacters")]
    [InlineData("MiXeD_CaSe_In_PuT", "miXeDCaSeInPuT")]
    public void ToCamelCase_WhenInputIsNotCamelCase_ShouldReturnCamelCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToCamelCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "ThisShouldBeConverted")]
    [InlineData("ThisShouldBeConverted", "ThisShouldBeConverted")]
    [InlineData("this-should-be-converted", "ThisShouldBeConverted")]
    [InlineData("this_should_be_converted", "ThisShouldBeConverted")]
    [InlineData("THIS SHOULD BE CONVERTED", "ThisShouldBeConverted")]
    [InlineData("This Should Be Converted", "ThisShouldBeConverted")]
    [InlineData("  this   should    be  converted  ", "ThisShouldBeConverted")] 
    [InlineData("t", "T")] 
    [InlineData("T", "T")] 
    [InlineData("123 start with numbers", "123StartWithNumbers")]
    [InlineData("PascalCaseAlready", "PascalCaseAlready")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "ThisHas123Numbers")] 
    [InlineData("with_special$characters!", "WithSpecialCharacters")]
    [InlineData("MiXeD_CaSe_In_PuT", "MiXeDCaSeInPuT")]
    public void ToPascalCase_WhenInputIsNotPascalCase_ShouldReturnPascalCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToPascalCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "this_should_be_converted")]
    [InlineData("ThisShouldBeConverted", "this_should_be_converted")]
    [InlineData("this-should-be-converted", "this_should_be_converted")]
    [InlineData("this_should_be_converted", "this_should_be_converted")]
    [InlineData("THIS SHOULD BE CONVERTED", "this_should_be_converted")]
    [InlineData("This Should Be Converted", "this_should_be_converted")]
    [InlineData("  this   should    be  converted  ", "this_should_be_converted")] 
    [InlineData("t", "t")] 
    [InlineData("T", "t")] 
    [InlineData("123 start with numbers", "123_start_with_numbers")]
    [InlineData("snake_case_already", "snake_case_already")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "this_has_123_numbers")] 
    [InlineData("with_special$characters!", "with_special_characters")]
    [InlineData("MiXeD_CaSe_In_PuT", "mi_xe_d_ca_se_in_pu_t")]
    public void ToSnakeCase_WhenInputIsNotSnakeCase_ShouldReturnSnakeCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToSnakeCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "this-should-be-converted")]
    [InlineData("ThisShouldBeConverted", "this-should-be-converted")]
    [InlineData("this-should-be-converted", "this-should-be-converted")]
    [InlineData("this_should_be_converted", "this-should-be-converted")]
    [InlineData("THIS SHOULD BE CONVERTED", "this-should-be-converted")]
    [InlineData("This Should Be Converted", "this-should-be-converted")]
    [InlineData("  this   should    be  converted  ", "this-should-be-converted")] 
    [InlineData("t", "t")] 
    [InlineData("T", "t")] 
    [InlineData("123 start with numbers", "123-start-with-numbers")]
    [InlineData("kebab-case-already", "kebab-case-already")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "this-has-123-numbers")] 
    [InlineData("with_special$characters!", "with-special-characters")]
    [InlineData("MiXeD_CaSe_In_PuT", "mi-xe-d-ca-se-in-pu-t")]
    public void ToKebabCase_WhenInputIsNotKebabCase_ShouldReturnKebabCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToKebabCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "THIS_SHOULD_BE_CONVERTED")]
    [InlineData("ThisShouldBeConverted", "THIS_SHOULD_BE_CONVERTED")]
    [InlineData("this-should-be-converted", "THIS_SHOULD_BE_CONVERTED")]
    [InlineData("this_should_be_converted", "THIS_SHOULD_BE_CONVERTED")]
    [InlineData("THIS SHOULD BE CONVERTED", "THIS_SHOULD_BE_CONVERTED")]
    [InlineData("This Should Be Converted", "THIS_SHOULD_BE_CONVERTED")]
    [InlineData("  this   should    be  converted  ", "THIS_SHOULD_BE_CONVERTED")] 
    [InlineData("t", "T")] 
    [InlineData("T", "T")] 
    [InlineData("123 start with numbers", "123_START_WITH_NUMBERS")]
    [InlineData("SCREAMING_SNAKE_CASE_ALREADY", "SCREAMING_SNAKE_CASE_ALREADY")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "THIS_HAS_123_NUMBERS")] 
    [InlineData("with_special$characters!", "WITH_SPECIAL_CHARACTERS")]
    [InlineData("MiXeD_CaSe_In_PuT", "MI_XE_D_CA_SE_IN_PU_T")]
    public void ToScreamingSnakeCase_WhenInputIsNotScreamingSnakeCase_ShouldReturnScreamingSnakeCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToScreamingSnakeCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "THIS-SHOULD-BE-CONVERTED")]
    [InlineData("ThisShouldBeConverted", "THIS-SHOULD-BE-CONVERTED")]
    [InlineData("this-should-be-converted", "THIS-SHOULD-BE-CONVERTED")]
    [InlineData("this_should_be_converted", "THIS-SHOULD-BE-CONVERTED")]
    [InlineData("THIS SHOULD BE CONVERTED", "THIS-SHOULD-BE-CONVERTED")]
    [InlineData("This Should Be Converted", "THIS-SHOULD-BE-CONVERTED")]
    [InlineData("  this   should    be  converted  ", "THIS-SHOULD-BE-CONVERTED")] 
    [InlineData("t", "T")] 
    [InlineData("T", "T")] 
    [InlineData("123 start with numbers", "123-START-WITH-NUMBERS")]
    [InlineData("SCREAMING-KEBAB-CASE-ALREADY", "SCREAMING-KEBAB-CASE-ALREADY")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "THIS-HAS-123-NUMBERS")] 
    [InlineData("with_special$characters!", "WITH-SPECIAL-CHARACTERS")]
    [InlineData("MiXeD_CaSe_In_PuT", "MI-XE-D-CA-SE-IN-PU-T")]
    public void ToScreamingKebabCase_WhenInputIsNotScreamingKebabCase_ShouldReturnScreamingKebabCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToScreamingKebabCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "This-Should-Be-Converted")]
    [InlineData("ThisShouldBeConverted", "This-Should-Be-Converted")]
    [InlineData("this-should-be-converted", "This-Should-Be-Converted")]
    [InlineData("this_should_be_converted", "This-Should-Be-Converted")]
    [InlineData("THIS SHOULD BE CONVERTED", "This-Should-Be-Converted")]
    [InlineData("This Should Be Converted", "This-Should-Be-Converted")]
    [InlineData("  this   should    be  converted  ", "This-Should-Be-Converted")] 
    [InlineData("t", "T")] 
    [InlineData("T", "T")] 
    [InlineData("123 start with numbers", "123-Start-With-Numbers")]
    [InlineData("Train-Case-Already", "Train-Case-Already")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "This-Has-123-Numbers")] 
    [InlineData("with_special$characters!", "With-Special-Characters")]
    [InlineData("MiXeD_CaSe_In_PuT", "Mi-Xe-D-Ca-Se-In-Pu-T")]
    public void ToTrainCase_WhenInputIsNotTrainCase_ShouldReturnTrainCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToTrainCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "This Should Be Converted")]
    [InlineData("ThisShouldBeConverted", "This Should Be Converted")]
    [InlineData("this-should-be-converted", "This Should Be Converted")]
    [InlineData("this_should_be_converted", "This Should Be Converted")]
    [InlineData("THIS SHOULD BE CONVERTED", "This Should Be Converted")]
    [InlineData("This Should Be Converted", "This Should Be Converted")]
    [InlineData("  this   should    be  converted  ", "This Should Be Converted")] 
    [InlineData("t", "T")] 
    [InlineData("T", "T")] 
    [InlineData("123 start with numbers", "123 Start With Numbers")]
    [InlineData("Title Case Already", "Title Case Already")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "This Has 123 Numbers")] 
    [InlineData("with_special$characters!", "With Special Characters")]
    [InlineData("MiXeD_CaSe_In_PuT", "Mi Xe D Ca Se In Pu T")]
    public void ToTitleCase_WhenInputIsNotTitleCase_ShouldReturnTitleCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToTitleCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "This should be converted")]
    [InlineData("ThisShouldBeConverted", "This should be converted")]
    [InlineData("this-should-be-converted", "This should be converted")]
    [InlineData("this_should_be_converted", "This should be converted")]
    [InlineData("THIS SHOULD BE CONVERTED", "This should be converted")]
    [InlineData("This Should Be Converted", "This should be converted")]
    [InlineData("  this   should    be  converted  ", "This should be converted")] 
    [InlineData("t", "T")] 
    [InlineData("T", "T")] 
    [InlineData("123 start with numbers", "123 start with numbers")]
    [InlineData("Sentence case already", "Sentence case already")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "This has 123 numbers")] 
    [InlineData("with_special$characters!", "With special characters")]
    [InlineData("MiXeD_CaSe_In_PuT", "Mi xe d ca se in pu t")]
    public void ToSentenceCase_WhenInputIsNotSentenceCase_ShouldReturnSentenceCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToSentenceCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "thisshouldbeconverted")]
    [InlineData("ThisShouldBeConverted", "thisshouldbeconverted")]
    [InlineData("this-should-be-converted", "thisshouldbeconverted")]
    [InlineData("this_should_be_converted", "thisshouldbeconverted")]
    [InlineData("THIS SHOULD BE CONVERTED", "thisshouldbeconverted")]
    [InlineData("This Should Be Converted", "thisshouldbeconverted")]
    [InlineData("  this   should    be  converted  ", "thisshouldbeconverted")] 
    [InlineData("t", "t")] 
    [InlineData("T", "t")] 
    [InlineData("123 start with numbers", "123startwithnumbers")]
    [InlineData("lowercasealready", "lowercasealready")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "thishas123numbers")] 
    [InlineData("with_special$characters!", "withspecialcharacters")]
    [InlineData("MiXeD_CaSe_In_PuT", "mixedcaseinput")]
    public void ToLowerCase_WhenInputIsNotLowerCase_ShouldReturnLowerCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToLowerCase();

        // assert
        
        result.ShouldBe(expected);
    } 
    
    [Theory]
    [InlineData("this should be converted", "THISSHOULDBECONVERTED")]
    [InlineData("ThisShouldBeConverted", "THISSHOULDBECONVERTED")]
    [InlineData("this-should-be-converted", "THISSHOULDBECONVERTED")]
    [InlineData("this_should_be_converted", "THISSHOULDBECONVERTED")]
    [InlineData("THIS SHOULD BE CONVERTED", "THISSHOULDBECONVERTED")]
    [InlineData("This Should Be Converted", "THISSHOULDBECONVERTED")]
    [InlineData("  this   should    be  converted  ", "THISSHOULDBECONVERTED")] 
    [InlineData("t", "T")] 
    [InlineData("T", "T")] 
    [InlineData("123 start with numbers", "123STARTWITHNUMBERS")]
    [InlineData("UPPERCASEALREADY", "UPPERCASEALREADY")]
    [InlineData("", "")]
    [InlineData("   ", "   ")]
    [InlineData(null, null)]
    [InlineData("thisHas123Numbers", "THISHAS123NUMBERS")] 
    [InlineData("with_special$characters!", "WITHSPECIALCHARACTERS")]
    [InlineData("MiXeD_CaSe_In_PuT", "MIXEDCASEINPUT")]
    public void ToUpperCase_WhenInputIsNotUpperCase_ShouldReturnUpperCase(string input, string expected)
    {
        // arrange & act

        var result = input.ToUpperCase();

        // assert
        
        result.ShouldBe(expected);
    } 
}