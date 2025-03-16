namespace LimbajeFormaleLab5
{
  public class FunctiiEx2
  {
    private enum Stare { S1, S2 } 
    private Stare stareCurenta = Stare.S1;

    public void GetInputs(string inputString)
    {
      foreach (char input in inputString)
      {
        switch (stareCurenta)
        {
          case Stare.S1:
            if (input == 'A')
            {
              stareCurenta = Stare.S1;
            }
            else if (input == 'B')
            {
              stareCurenta = Stare.S2;
            }
            else
            {
              Console.WriteLine("Invalid input: " + input);
              return; 
            }
            break;

          case Stare.S2:
            if (input == 'A')
            {
              stareCurenta = Stare.S1;
            }
            else if (input == 'B')
            {
              stareCurenta = Stare.S2;
            }
            else
            {
              Console.WriteLine("Invalid input: " + input);
              return;
            }
            break;
        }

        switch (stareCurenta)
        {
          case Stare.S1:
            Console.WriteLine("Iesire: O1");
            break;
          case Stare.S2:
            Console.WriteLine("Iesire: O2");
            break;
        }
      }
    }
  }
}


