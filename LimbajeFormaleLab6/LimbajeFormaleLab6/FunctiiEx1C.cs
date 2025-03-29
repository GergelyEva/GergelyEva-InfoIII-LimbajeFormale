using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajeFormaleLab6
{
  public class FunctiiEx1C
  {
    public static void Verifica(int nrPompare)
    {
      Console.WriteLine("3. L = {a^n b^n c^n | n > 0}");

      string cuvantEx = new string('a', nrPompare) + new string('b', nrPompare) + new string('c', nrPompare);

      Console.WriteLine($"String generat: {cuvantEx}");

      for (int startY = 0; startY < nrPompare; startY++)
      {
        for (int lungimeY = 1; lungimeY <= nrPompare; lungimeY++)
        {
          if (startY + lungimeY <= cuvantEx.Length)
          {
            string parteX = cuvantEx.Substring(0, startY);
            string parteY = cuvantEx.Substring(startY, lungimeY);
            string parteZ = cuvantEx.Substring(startY + lungimeY);

            string cuvantPompat = parteX + parteY + parteY + parteZ;
            Console.WriteLine($"Pompare (y='{parteY}'): {cuvantPompat}");

            int numarA = cuvantPompat.Split('b')[0].Length;
            int numarB = cuvantPompat.Substring(numarA).Split('c')[0].Length;
            int numarC = cuvantPompat.Length - numarA - numarB;

            if (numarA != numarB || numarB != numarC)
            {
              Console.WriteLine("Limbaj neregulat");
              return;
            }
          }
        }
        }
    }
  }
}
