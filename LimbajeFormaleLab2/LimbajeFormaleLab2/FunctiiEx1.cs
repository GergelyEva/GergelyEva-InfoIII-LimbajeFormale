using System;

namespace LimbajeFormaleLab2
{
  public class FunctiiEx1
  {
    public bool VerificareDrum(string input)
    {
      string stareCurenta = "q0";

      foreach (char nr in input)
      {
        if (nr != '0' && nr != '1')
        {
          Console.WriteLine("Introdu doar cifre de 0 si 1");
        }

        switch (stareCurenta)
        {
          case "q0":
            stareCurenta = (nr == '0') ? "q1" : "q2";
            break;
          case "q1":
            stareCurenta = (nr == '0') ? "q3" : "q0";
            break;
          case "q2":
            stareCurenta = (nr == '0') ? "q1" : "q3";
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
