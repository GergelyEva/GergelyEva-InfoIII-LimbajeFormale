using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajeFormaleLab6
{
  public class FunctiiEx1A
  {
    public static void Verifica(int nrPompare)
    {
      Console.WriteLine("1.L = {0^i 1^j | i > j}");

      string cuvantEx = new string('0', nrPompare + 1) + new string('1', nrPompare);

      Console.WriteLine($"Stringul generat: {cuvantEx}");

      for (int lungimeY = 1; lungimeY <= nrPompare; lungimeY++)
      {
        string parteX = cuvantEx.Substring(0, nrPompare + 1 - lungimeY);
        string parteZ = cuvantEx.Substring(nrPompare + 1);

        string cuvantPompatJos = parteX + parteZ;
        int numar0 = cuvantPompatJos.Split('1')[0].Length;
        int numar1 = cuvantPompatJos.Length - numar0;

        if (numar0 <= numar1)
        {
          Console.WriteLine("Limbaj neregulat");
          return;
        }
      }
    }
  }
}
