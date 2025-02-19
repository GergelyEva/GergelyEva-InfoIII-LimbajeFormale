using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajeFormaleLab2
{
  public class Functiiex3
  {
    private string stare = "q0";

    public bool CuvantCorect(string word)
    {//cuvantul corect incepe cu a
      stare = "q0";

      foreach (char c in word)
      {
        Transition(c);
      }
      return stare == "q3"; 
    }
    private void Transition(char c)
    {
      switch (stare)
      {
        case "q0":
          // {δ(q0, a) = q1
          //• δ(q0, b) = q0
          //• δ(q0, c) = q0
          //• δ(q0, d) = q0
          stare = (c == 'a') ? "q1" : "q0";
          break;
        case "q1":
          //• δ(q1, a) = q1
          //• δ(q1, b) = q2
          //• δ(q1, c) = q1
          //• δ(q1, d) = q1

          stare = (c == 'b') ? "q2" : "q1";
          break;
        case "q2":
          // δ(q2, a) = q2
          //• δ(q2, b) = q2
          //• δ(q2, c) = q2
          //• δ(q2, d) = q3

          stare = (c == 'd') ? "q3" : "q2";
          break;
        case "q3":
          // • δ(q3, a) = q3
          //• δ(q3, b) = q3
          //• δ(q3, c) = q3
          //• δ(q3, d) = q3

          //am epuizat cele 3 litere, cazul in schimb trebuie sa existe conform diagramelor.
          break;
      }
    }
    public static List<string> GenerareCuvinte()
    {
      List<string> cuvinte = new List<string>();
      char[] alfabet = { 'a', 'b', 'c', 'd' };

      foreach (char c1 in alfabet)
      {
        foreach (char c2 in alfabet)
        {
          foreach (char c3 in alfabet)
          {
            string cuvant = $"{c1}{c1}{c2}{c2}{c3}{c3}";
            cuvinte.Add(cuvant);
          }
        }
      }

      return cuvinte;
    }
  }
}
