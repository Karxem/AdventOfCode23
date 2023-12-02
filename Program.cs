using System.Text.RegularExpressions;

public class AdventOfCode
{
    public static void Main(string[] args)
    {
        // Path to the given input.txt
        string path = @"AdventOfCode\assets\input.txt";

        List<int> validNumbers = new List<int>();
        string[] strings = File.ReadAllText(path).Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None
        );
        
        foreach ( string s in strings )
        {
            string[] numbers = Regex.Split(s, @"\D+");
            string number = string.Join("", numbers);
            int i = int.Parse(number[0].ToString() + number[number.Length - 1].ToString());

            validNumbers.Add(i);
        }

        Console.WriteLine("Summ: " + validNumbers.Sum());
    }
}