using System;

namespace LimbajeFormaleLab1
{
  public class FunctiiEx3
  {
    public static void GeneratePalindromes(string current)
    {
      if (current.Length > 5)
        return;

      if (current.Length > 0 && isPalindrome(current))
        Console.WriteLine(current);

      foreach (char c in new char[] { '0', '1', '2' })
      {
        GeneratePalindromes(current + c);
      }
    }


    public static bool isPalindrome(string myString)
    {
      string first = myString.Substring(0, myString.Length / 2);
      char[] arr = myString.ToCharArray();

      Array.Reverse(arr);

      string temp = new string(arr);
      string second = temp.Substring(0, temp.Length / 2);

      return first.Equals(second);
    }
   
  }
}