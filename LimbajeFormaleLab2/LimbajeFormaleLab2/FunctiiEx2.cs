using LimbajeFormaleLab2;
using System;

namespace LimbajeFormaleLab2
{
  public class FunctiiEx2
  {
    public bool VerificareCuvant(string input)
    {
      string stareCurenta = "q0";

      foreach (char c in input)
      {
        switch (stareCurenta)
        {
          case "q0":
            stareCurenta = (c == 'c') ? "q1" : "q0";
            break;
          case "q1":
            stareCurenta = (c == 'a') ? "q2" : (c == 'c') ? "q1" : "q0";
            break;
          case "q2":
            stareCurenta = (c == 't') ? "q3" : (c == 'c') ? "q1" : "q0";
            break;
          case "q3":
            stareCurenta = "q3"; 
            break;
        }
      }

      return stareCurenta == "q3";
    }
  }
}