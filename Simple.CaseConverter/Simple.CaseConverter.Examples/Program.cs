using Simple.CaseConverter.Extensions;

const string example1 = "John Doe, the first";

Console.WriteLine("Example 1: \"" + example1 + "\"");
Console.WriteLine("  Camel case: " + example1 + " -> " + example1.ToCamelCase());
Console.WriteLine("  Kebab case: " + example1 + " -> " + example1.ToKebabCase());
Console.WriteLine("  Lower case: " + example1 + " -> " + example1.ToLowerCase());
Console.WriteLine("  Pascal case: " + example1 + " -> " + example1.ToPascalCase());
Console.WriteLine("  Screaming kebab case: " + example1 + " -> " + example1.ToScreamingKebabCase());
Console.WriteLine("  Screaming snake case: " + example1 + " -> " + example1.ToScreamingSnakeCase());
Console.WriteLine("  Sentence case: " + example1 + " -> " + example1.ToSentenceCase());
Console.WriteLine("  Snake case: " + example1 + " -> " + example1.ToSnakeCase());
Console.WriteLine("  Title case: " + example1 + " -> " + example1.ToTitleCase());
Console.WriteLine("  Train case: " + example1 + " -> " + example1.ToTrainCase());
Console.WriteLine("  Upper case: " + example1 + " -> " + example1.ToUpperCase());
Console.WriteLine();

const string example2 = "JaneDoe - the second";

Console.WriteLine("Example 2: \"" + example2 + "\"");
Console.WriteLine("  Camel case: " + example2 + " -> " + example2.ToCamelCase());
Console.WriteLine("  Kebab case: " + example2 + " -> " + example2.ToKebabCase());
Console.WriteLine("  Lower case: " + example2 + " -> " + example2.ToLowerCase());
Console.WriteLine("  Pascal case: " + example2 + " -> " + example2.ToPascalCase());
Console.WriteLine("  Screaming kebab case: " + example2 + " -> " + example2.ToScreamingKebabCase());
Console.WriteLine("  Screaming snake case: " + example2 + " -> " + example2.ToScreamingSnakeCase());
Console.WriteLine("  Sentence case: " + example2 + " -> " + example2.ToSentenceCase());
Console.WriteLine("  Snake case: " + example2 + " -> " + example2.ToSnakeCase());
Console.WriteLine("  Title case: " + example2 + " -> " + example2.ToTitleCase());
Console.WriteLine("  Train case: " + example2 + " -> " + example2.ToTrainCase());
Console.WriteLine("  Upper case: " + example2 + " -> " + example2.ToUpperCase());
Console.WriteLine();

/*
 
 OUTPUTS:
 
 Example 1: "John Doe, the first"
  Camel case: John Doe, the first -> johnDoeTheFirst
  Kebab case: John Doe, the first -> john-doe-the-first
  Lower case: John Doe, the first -> johndoethefirst
  Pascal case: John Doe, the first -> JohnDoeTheFirst
  Screaming kebab case: John Doe, the first -> JOHN-DOE-THE-FIRST
  Screaming snake case: John Doe, the first -> JOHN_DOE_THE_FIRST
  Sentence case: John Doe, the first -> John doe the first
  Snake case: John Doe, the first -> john_doe_the_first
  Title case: John Doe, the first -> John Doe The First
  Train case: John Doe, the first -> John-Doe-The-First
  Upper case: John Doe, the first -> JOHNDOETHEFIRST

Example 2: "JaneDoe - the second"
  Camel case: JaneDoe - the second -> janeDoeTheSecond
  Kebab case: JaneDoe - the second -> jane-doe-the-second
  Lower case: JaneDoe - the second -> janedoethesecond
  Pascal case: JaneDoe - the second -> JaneDoeTheSecond
  Screaming kebab case: JaneDoe - the second -> JANE-DOE-THE-SECOND
  Screaming snake case: JaneDoe - the second -> JANE_DOE_THE_SECOND
  Sentence case: JaneDoe - the second -> Jane doe the second
  Snake case: JaneDoe - the second -> jane_doe_the_second
  Title case: JaneDoe - the second -> Jane Doe The Second
  Train case: JaneDoe - the second -> Jane-Doe-The-Second
  Upper case: JaneDoe - the second -> JANEDOETHESECOND
  
 */