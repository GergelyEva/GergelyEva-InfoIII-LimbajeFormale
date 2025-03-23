﻿namespace LimbajeFormaleLab5v2
{
  public class FunctiiEx2
  {
    private enum Stare { q0, q1, q2, q3, q4 }
    private Stare stareCurenta = Stare.q0;

    public bool VerificaCuvant(string cuvant)
    {
      foreach (char simbol in cuvant)
        VerificaSimbol(simbol);

      TranzitiiEpsilon();

      return stareCurenta == Stare.q4;
    }

    private void VerificaSimbol(char simbol)
    {
      switch (stareCurenta)
      {
        case Stare.q0:
          if (simbol == 'b')
            stareCurenta = Stare.q1;
          else if (simbol == 'a')
            stareCurenta = Stare.q4;
          break;

        case Stare.q1:
          if (simbol == 'a' || simbol == 'b')
            stareCurenta = Stare.q2;
          break;

        case Stare.q2:
          if (simbol == 'a' || simbol == 'b')
            stareCurenta = Stare.q2;
          else if (simbol == 'e')
            stareCurenta = Stare.q3;
          break;

        case Stare.q3:
          stareCurenta = Stare.q4;
          break;

        case Stare.q4:
          Console.WriteLine("Stare finala.");
          break;
      }
    }

    private void TranzitiiEpsilon()
    {
      while (true)
      {
        switch (stareCurenta)
        {
          case Stare.q3:  
            stareCurenta = Stare.q4;
            break;
          default:
            return;
        }
      }
    }
  }
}
