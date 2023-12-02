using System.Text.RegularExpressions;

public class AdventOfCode
{
    public static void Main(string[] args)
    {
        string path = @"E:\Documents\GitHub\AdventOfCode\assets\input.txt";
        string[] strings = File.ReadAllText(path).Split(
            new string[] { Environment.NewLine },
            StringSplitOptions.None
        );

        var numberMapping = new Dictionary<string, string>()
        {
            { "one", "1" },
            { "two", "2" },
            { "three", "3" },
            { "four", "4" },
            { "five", "5" },
            { "six", "6" },
            { "seven", "7" },
            { "eight", "8" },
            { "nine", "9" }
        };

        void firstPart(string[] strings)
        {
            List<int> validNumbers = new List<int>();
            foreach (string s in strings)
            {
                string[] numbers = Regex.Split(s, @"\D+");
                string number = string.Join("", numbers);
                int i = int.Parse(number[0].ToString() + number[number.Length - 1].ToString());

                validNumbers.Add(i);
            }

            Console.WriteLine("First Part: " + validNumbers.Sum());
        }


        void secondPart(string[] strings)
        {
            List<int> validNumbers = new List<int>();
            foreach (string s in strings)
            {
                string pattern = string.Join("|", numberMapping.Keys);
                Regex regex = new Regex(pattern);
                MatchEvaluator evaluator = match => numberMapping[match.Value];

                string result = regex.Replace(s, evaluator);

                string[] numbers = Regex.Split(result, @"\D+");
                string number = string.Join("", numbers);
                int i = int.Parse(number[0].ToString() + number[number.Length - 1].ToString());
                validNumbers.Add(i);
            }

            Console.WriteLine("Second Part: " + validNumbers.Sum());
        }

        firstPart(strings);
        secondPart(strings);
    }
}