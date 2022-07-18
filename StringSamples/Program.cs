// main

//Console.WriteLine(IsUppercase("ADE"));
//Console.WriteLine(IsLowercase("ade"));
//Console.WriteLine("IsPasswordComplex?  " + IsPasswordComplex("Ade"));
//Console.WriteLine("IsPasswordComplex? " + IsPasswordComplex("Olusola01"));
//Console.WriteLine("IsPasswordComplex? " + IsPasswordComplex("Hello0"));
// Console.WriteLine("NormalizeString? " + NormalizeString("Hello There, budyd"));
using System.Text;

Console.WriteLine("Hello world".Contains("ll"));
// Console.WriteLine("IsAtEvenIndex" + IsAtEvenIndex("Olusola", 'u'));

Console.WriteLine("Reverse: " + Reverse2("Olusola"));
Console.WriteLine("Reverse: " + Reverse2(""));
Console.WriteLine("Reverse: " + Reverse2("telcos"));
Console.WriteLine("ReverseWords: " + ReverseEachWord("Ask me a question."));
static string ReverseEachWord(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return input;
    }
    StringBuilder result = new StringBuilder();
    // convert to array of string
    string[] words = input.Split(" ");
    for (int i = 0; i < words.Length; i++)
    {
        result.Append(Reverse(words[i]));
        if (i < words.Length - 1)
        {
            result.Append(" ");
        }
    }
    // 2348092823605

    return result.ToString();
}

static string Reverse2(string input)
{
    char[] arr = input.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);

}
static string Reverse(string input)
{
    if (string.IsNullOrEmpty(input))
    {
        return input;
    }

    StringBuilder reversed = new StringBuilder();
    for (int i = input.Length - 1; i >= 0; i--)
    {
        reversed.Append(input[i]);
    }

    return reversed.ToString();
}

static bool IsAtEvenIndex(string s, char item)
{
    for (int i = 0; i < s.Length; i += 2)
    {
        if (s[i] == item)
        {
            return true;
        }
    }
    return false;
}
static string NormalizeString(string input)
{
    return input.ToLower().Trim().Replace(",", "");
    // string lowerCased = input.ToLower();
    //lowerCased.Trim();
    //string trimmed = lowerCased.Trim();
    //trimmed.Replace(",", ""); 16th of May and 3rd of March, 31st March 2022 - units, value

}

static bool IsUppercase(string s)
{
    return s.All(Char.IsUpper);
} // PEN200889172117

static bool IsLowercase(string s)
{
    return s.All(Char.IsLower);
}
static bool IsPasswordComplex(string s)
{
    return s.Any(char.IsLower) && s.Any(char.IsUpper) && s.Any(char.IsDigit);
}
