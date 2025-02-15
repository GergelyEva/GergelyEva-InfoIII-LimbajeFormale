using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajeFormaleLab1
{

  public class FunctiiEx1
  {
    //Cele trei alfabete sunt:
    public static char[] A = { 'a', 'b', 'c' };
    public static char[] B = { 'x', 'y', 'z' };
    public static char[] C = { '1', '2', '3' };
    public static string Concatenate(string s1, string s2)
    {
      return s1 + s2;
    }

    public static string Invers(string s)
    {
      char[] charArray = s.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }

    public static string Substituie(string s, char a, char b)
    {
      return s.Replace(a, b);
    }

    public static int Lungime(string s)
    {
      return s.Length;
    }
  }
}
