namespace LimbajeFormaleLab1
{
  public class FunctiiEx4
  {
    public static void GenerateStrings(string currentWord, int maxA, int maxB)
    {
      Console.WriteLine(currentWord);

      if (maxA > 0)
        GenerateStrings(currentWord + "a", maxA - 1, maxB);

      if (maxB > 0)
        GenerateStrings(currentWord + "b", maxA, maxB - 1);
    }
  }
}
