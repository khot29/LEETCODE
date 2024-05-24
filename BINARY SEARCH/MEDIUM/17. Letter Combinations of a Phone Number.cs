using System;
using System.Collections.Generic;

public class Program
{
  public static void Main()
  {
    var solution = new Solution();

    // Example 1
    var result1 = solution.LetterCombinations("23");
    Console.WriteLine(string.Join(", ", result1));
    // Output: ad, ae, af, bd, be, bf, cd, ce, cf

    // Example 2
    var result2 = solution.LetterCombinations("");
    Console.WriteLine(string.Join(", ", result2));
    // Output: (an empty string)

    // Example 3
    var result3 = solution.LetterCombinations("2");
    Console.WriteLine(string.Join(", ", result3));
    // Output: a, b, c
  }
}




public class Solution
{
  
  public IList<string> LetterCombinations(string digits)
  {
    if (string.IsNullOrEmpty(digits))
    {
      return new List<string>();
    }

    // Mapping of digits to corresponding letters
    var phoneMap = new Dictionary<char, string> {
            { '2', "abc" }, { '3', "def" }, { '4', "ghi" },
            { '5', "jkl" }, { '6', "mno" }, { '7', "pqrs" },
            { '8', "tuv" }, { '9', "wxyz" }
        };

    var result = new List<string>();
    Backtrack(digits, 0, "", result, phoneMap);
    return result;
  }

  private void Backtrack(string digits, int index, string path, List<string> result, Dictionary<char, string> phoneMap)
  {
    if (index == digits.Length)
    {
      result.Add(path);
      return;
    }

    string letters = phoneMap[digits[index]];
    foreach (char letter in letters)
    {
      Backtrack(digits, index + 1, path + letter, result, phoneMap);
    }
  }
}



