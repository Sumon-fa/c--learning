namespace readFile;
class Program
{
    static void Main(string[] args)
    {
        string text = System.IO.File.ReadAllText(@"C:\Users\fakir\OneDrive\Desktop\integrify\c#-Execercie\readFile\\myText.txt");
        Console.WriteLine($"the text is: {text}");
    }
}
