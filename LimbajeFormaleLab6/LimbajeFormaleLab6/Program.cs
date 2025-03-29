using LimbajeFormaleLab6;
using System;

class Program
{
  static void Main()
  {
    //ex1
    Console.WriteLine("Introdu numar pompare pentru ex 1");
    int nrPompare = Convert.ToInt32(Console.ReadLine());
    FunctiiEx1A.Verifica(nrPompare);
    Console.WriteLine();
    FunctiiEx1B.Verifica(nrPompare);
    Console.WriteLine();
    FunctiiEx1C.Verifica(nrPompare);

    //ex2
    while (true)
    {
      var L1 = FunctiiEx2.CitesteLimbaj("L1 separate prin virgula:");
      var L2 = FunctiiEx2.CitesteLimbaj("L2 separate prin virgula: ");

      Console.WriteLine("\n1. Uniune\n2. Intersectie\n3. Concatenare\n4. Diferenta\n5. Apartine limbaj\n0. Iesire");

      while (true)
      {
        Console.Write("\nAlege operatia: ");
        var optiune = Console.ReadLine();

        switch (optiune)
        {
          case "1":
            FunctiiEx2.AfiseazaRezultat("Uniune", FunctiiEx2.Uniune(L1, L2));
            break;
          case "2":
            FunctiiEx2.AfiseazaRezultat("Intersectie", FunctiiEx2.Intersectie(L1, L2));
            break;
          case "3":
            FunctiiEx2.AfiseazaRezultat("Concatenare", FunctiiEx2.Concatenare(L1, L2));
            break;
          case "4":
            FunctiiEx2.AfiseazaRezultat("Diferenta", FunctiiEx2.Diferenta(L1, L2));
            break;
          case "5":
            Console.Write("Introdu cuvantul: ");
            var cuvant = Console.ReadLine()?.Trim();
            FunctiiEx2.Apartine(L1, L2, cuvant);
            break;
          case "0":
            return;
          default:
            Console.WriteLine("Optiune invalida");
            break;
        }
        Console.ReadKey();
      };
    }
  }
}