using System.Text.RegularExpressions;

String song = "At first I was afraid, I aaswaswas petrified\r\nKept thinkin' I could never live without you by my side\r\nBut then I spent so many nights thinkin' how you did me wrong\r\nAnd I grew strong and I learned how to get along";

List<string> words =  new List<string>(Regex.Split(song, @"\W+"));

//foreach (string word in words)
//{
//    Console.WriteLine(word);
//}

var wordsWith5PlusLetters = words.Where(word => word.Length > 4);
Console.WriteLine($"\nList of words that have more than 4 letters:");
foreach (string word in wordsWith5PlusLetters)
{
    Console.WriteLine($"{word}");
}

var words5_8Letters = words.Where(word => word.Length > 4).Where(word => word.Length <= 8);
Console.WriteLine($"\nList of words that have 5-8 letters:");
foreach (string word in words5_8Letters)
{
    Console.WriteLine($"{word}");
}

var wordsSortedByLenght= words.OrderBy(word => word.Length).ThenBy(word => word);
Console.WriteLine($"\nList of words sorted by letters:");
foreach (string word in wordsSortedByLenght)
{
    Console.WriteLine($"{word}");
}

var maxLength = words.Max(word => word.Length);
var wordsWithMaxLength = words.Where(word => word.Length == maxLength);

Console.WriteLine($"\nHere is the list of ongest words. They have {maxLength} letters.:");
foreach (string word in wordsWithMaxLength)
{
    Console.WriteLine($"{word}");
}

var wordsSortedAlphabetically = words.OrderBy(word => word).ToList(); //sorts and converts the result to a list.
if (wordsSortedAlphabetically.Count >= 3)
{
    Console.WriteLine($"\nThe 3rd word in the alphabetically sorted list is:");
    Console.WriteLine($"{wordsSortedAlphabetically[2]}");
}
else
{
    Console.WriteLine("The list does not contain enough words.");
}