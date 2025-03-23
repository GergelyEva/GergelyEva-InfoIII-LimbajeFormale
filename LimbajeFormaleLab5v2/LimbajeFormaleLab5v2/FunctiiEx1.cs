namespace LimbajeFormaleLab5v2
{
  public class FunctiiEx1
  {
    private enum Stare { S0, S1 }
    private Stare stareCurenta = Stare.S0;

    public void GetInputs(string inputString)
    {
      foreach (char input in inputString)
      {
        switch (stareCurenta)
        {
          case Stare.S0:
            if (input == '0')
            {
              stareCurenta = Stare.S0;
            }
            else if (input == '1')
            {
              stareCurenta = Stare.S1;
            }
            else
            {
              Console.WriteLine("Input gresit: " + input);
              return;
            }
            break;

          case Stare.S1:
            if (input == '0')
            {
              stareCurenta = Stare.S1;
            }
            else if (input == '1')
            {
              stareCurenta = Stare.S0;
            }
            else
            {
              Console.WriteLine("Input gresit: " + input);
              return;
            }
            break;
        }

        switch (stareCurenta)
        {
          case Stare.S0:
            Console.WriteLine("Iesire: 0");
            break;
          case Stare.S1:
            Console.WriteLine("Iesire: 1");
            break;
        }
      }
    }
  }

}

