namespace LimbajeFormaleLab5
{
  public class FunctiiEx3
  {
    private enum Stare { Q1, Q2 };
    private Stare stareCurenta = Stare.Q1;

    public void GetInputs(string inputString)
    {
      foreach (char input in inputString)
      {
        switch (stareCurenta)
        {
          case Stare.Q1:
            if (input == 'X')
            {
              stareCurenta = Stare.Q2;
              Console.WriteLine("Output: O1");
            }
            else if (input == 'Y')
            {
              stareCurenta = Stare.Q1;
              Console.WriteLine("Output: O1");
            }
            else
            {
              Console.WriteLine("Invalid input: " + input);
              return;
            }
            break;

          case Stare.Q2:
            if (input == 'X')
            {
              stareCurenta = Stare.Q1;
              Console.WriteLine("Output: O2");
            }
            else if (input == 'Y')
            {
              stareCurenta = Stare.Q2;
              Console.WriteLine("Output: O2");
            }
            else
            {
              Console.WriteLine("Invalid input: " + input);
              return;
            }
            break;
        }
      }
    }
  }
}
