using System.Text;

class Program
{
    static void Main(string[] args)
    {
        WelcomeText();

        string path = "Dictionary.txt";
        var dict = ReadFile(path);

        var input = GetInputWord();
        var translateWord = SearchWord(dict, input);

        ShowResult(translateWord);
    }

    private static void WelcomeText()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Welcome! This is a English dictionary...");
        Console.ResetColor();
    }

    private static IDictionary<string, string> ReadFile(string path)
    {
        var lines = File.ReadAllLines(path);

        var dict = new Dictionary<string, string>();
        foreach(var line in lines)
        {
            var words = line.Split(' ');
            dict.Add(words[0], words[1]);
        }

        return dict;
    }

    private static string GetInputWord()
    {
        Console.WriteLine("Enter a word to translate: ");
        var word = Console.ReadLine();
        return word;
    }

    private static string SearchWord(IDictionary<string, string> dict, string wordToSearch)
    {
        return dict[wordToSearch];
    }

    private static void ShowResult(string translateWord)
    {
        Console.WriteLine("The translate word is: " + translateWord);
    }
}