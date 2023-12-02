using System.Text.RegularExpressions;

public class AdventOfCode
{
    public static void Main(string[] args)
    {
        List<int> validNumbers = new List<int>();
        string path = @"E:\Documents\GitHub\AdventOfCode\assets\input.txt";
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