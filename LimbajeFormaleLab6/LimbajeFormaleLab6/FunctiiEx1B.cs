using System;
namespace LimbajeFormaleLab6
{
  public static class FunctiiEx1B
  {
    public static void Verifica(int nrPompare)
    {
      Console.WriteLine("2. L = {a^i b^j | i <= j}");

      string cuvantEx = new string('a', nrPompare) + new string('b', nrPompare + 1);

      Console.WriteLine($"Stringul generat: {cuvantEx}");

      for (int lungimeY = 1; lungimeY <= nrPompare; lungimeY++)
      {
        string parteX = cuvantEx.Substring(0, nrPompare - lungimeY);
        string parteY = cuvantEx.Substring(nrPompare - lungimeY, lungimeY);
        string parteZ = cuvantEx.Substring(nrPompare);

        string cuvantPompatSus = parteX + parteY + parteY + parteZ;
        int numarA = cuvantPompatSus.Split('b')[0].Length;
        int numarB = cuvantPompatSus.Length - numarA;

        if (numarA > numarB)
        {
          Console.WriteLine("Limbaj neregulat");
          return;
        }
      }
    }
  }
}