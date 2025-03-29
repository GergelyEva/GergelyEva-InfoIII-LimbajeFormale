namespace LimbajeFormaleLab6
{
  public class FunctiiEx2
  {
    public static List<string> CitesteLimbaj(string limbaj)
    {
      Console.Write(limbaj);
      var input = Console.ReadLine()?.Trim();

      if (string.IsNullOrEmpty(input))
      {
        return new List<string>();
      }

      var elemente = input.Split(new[] { ',' }, StringSplitOptions.RemoveEmptyEntries)
                         .Select(e => e.Trim())
                         .Where(e => !string.IsNullOrEmpty(e))
                         .Distinct()
                         .ToList();

      return elemente;
    }

    public static List<string> Uniune(List<string> L1, List<string> L2)
    {
      var rezultat = new List<string>();
      rezultat.AddRange(L1);

      foreach (var item in L2)
      {
        if (!rezultat.Contains(item))
        {
          rezultat.Add(item);
        }
      }

      return rezultat;
    }

    public static List<string> Intersectie(List<string> L1, List<string> L2)
    {
      var rezultat = new List<string>();

      foreach (var item in L1)
      {
        if (L2.Contains(item))
        {
          rezultat.Add(item);
        }
      }

      return rezultat;
    }

    public static List<string> Concatenare(List<string> L1, List<string> L2)
    {
      var rezultat = new List<string>();

      foreach (var s1 in L1)
      {
        foreach (var s2 in L2)
        {
          var combinatie = s1 + s2;
          if (!rezultat.Contains(combinatie))
          {
            rezultat.Add(combinatie);
          }
        }
      }

      return rezultat;
    }

    public static List<string> Diferenta(List<string> L1, List<string> L2)
    {
      var rezultat = new List<string>();

      foreach (var item in L1)
      {
        if (!L2.Contains(item))
        {
          rezultat.Add(item);
        }
      }

      return rezultat;
    }

    public static void Apartine(List<string> L1, List<string> L2, string cuvant)
    {
      if (string.IsNullOrEmpty(cuvant))
      {
        Console.WriteLine("Introdu cuvantul");
        return;
      }

      Console.WriteLine($"\nL1: {(L1.Contains(cuvant) ? "contine" : "nu contine")}  '{cuvant}'");
      Console.WriteLine($"L2: {(L2.Contains(cuvant) ? "contine" : "nu contine")}  '{cuvant}'");
    }

    public static void AfiseazaRezultat(string operatie, List<string> rezultat)
    {
      Console.WriteLine($"\n{operatie}:");

      if (rezultat.Count == 0 || (rezultat.Count == 1 && string.IsNullOrEmpty(rezultat[0])))
      {
        Console.WriteLine("nu exista intersecite");
        return;
      }

      var elementeOrdonate = rezultat.Where(s => !string.IsNullOrEmpty(s))
                                    .OrderBy(s => s.Length)
                                    .ThenBy(s => s)
                                    .ToList();
      Console.WriteLine($"{{{string.Join(", ", elementeOrdonate)}}}");
    }
  }
}
