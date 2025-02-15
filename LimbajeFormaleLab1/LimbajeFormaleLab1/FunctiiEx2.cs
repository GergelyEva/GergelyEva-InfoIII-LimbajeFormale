using System;
using System.Linq;


namespace LimbajeFormaleLab1
{
  public class FunctiiEx2
  {
    public enum Alfabet1
    {
      _0, _1, _2, _3, _4, _5, _6, _7, _8, _9
    }

    public enum Alfabet2
    {
      a, b, c, d, e, f, g, i, j, k
    }

    public enum Alfabet3
    {
      x1, y1, x2, y2, x3, y3, x4, y4, x5, y5
    }
    public static string Concatenate(string s1, string s2)
    {
      return s1 + s2;
    }

    public static string Repeat(string s, int n)
    {
      var result = s;

      for (var i = 0; i < n - 1; i++)
      {
        result += s;
      }

      return result;
    }

    public static string Reverse(string s)
    {
      //pentru tratarea corect a celui de-al treilea alfabet
      var pattern = new System.Text.RegularExpressions.Regex(@"(x[1-5]|y[1-5]|\w)");
      var matches = pattern.Matches(s);

      var reversed = matches.Cast<System.Text.RegularExpressions.Match>().Select(m => m.Value).Reverse();

      return string.Join("", reversed);
    }

    public static string Extract(string s, int i, int j)
    {
      if (i < 0 || j >= s.Length || i > j)
      {
        return "Datle introduse nu sunt corecte!";
      }
      //in caz ca cel extras este din al treilea alfabet, sa se extraga ambele charuri (un simbol)
      var pattern = new System.Text.RegularExpressions.Regex(@"(x[1-5]|y[1-5]|\w)");
      var matches = pattern.Matches(s);

      var selected = matches.Cast<System.Text.RegularExpressions.Match>()
                            .Skip(i)
                            .Take(j - i + 1)
                            .Select(m => m.Value);

      return string.Join("", selected);
    }

    
    public static string Replace(string s, string sub, string newSub)
    {
      return s.Replace(sub, newSub);
    }

  }
}
