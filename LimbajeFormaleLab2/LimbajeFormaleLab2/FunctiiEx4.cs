using System;
using System.IO;
using System.Text.RegularExpressions;

namespace LimbajeFormaleLab2
{
  public class FunctiiEx4
  {
    public void VerificaFactura(string fisier)
    {
      if (!File.Exists(fisier))
      {
        Console.WriteLine("Drum incorect.");
        return;
      }

      string fisierCitit = File.ReadAllText(fisier);

      bool clientValid = VerificaClient(fisierCitit);
      bool produsValid = VerificaProduse(fisierCitit);
      bool totalValid = VerificaTotal(fisierCitit);

      Console.WriteLine(clientValid && produsValid && totalValid ? "Fisier citit." : "Eroare.");

    }

    private bool VerificaClient(string fisier)
    {
      Regex clientRegex = new Regex(@"^Client:\s*[A-Za-z]+(?:\s+[A-Za-z]+)*", RegexOptions.Multiline);
      if (!clientRegex.IsMatch(fisier))
      {
        Console.WriteLine("Detaliile despre client nu respecta formaul.");
        return false;
      }

      return true;
    }

    private bool VerificaProduse(string fisier)
    {
      Regex produsRegex = new Regex(
          @"^Produs:\s*[A-Za-z]+(?:\s[A-Za-z]+)*,\s*Pret:\s*\d+\.\d{2},\s*TVA:\s*\d+%?,\s*Cantitate:\s*\d+$",
          RegexOptions.Multiline);

      bool produsValid = false;
      foreach (string i in fisier.Replace("\r", "").Split('\n'))
      {
        if (produsRegex.IsMatch(i.Trim()))
        {
          produsValid = true;
        }
        else if (i.Trim().StartsWith("Produs:"))
        {
          Console.WriteLine($"Eroare la produsul: {i.Trim()}");
        }
      }


      if (!produsValid)
      {
        Console.WriteLine("Detaliile produselor nu respecta formatul.");
        return false;
      }
      return true;
    }


    private bool VerificaTotal(string fisier)
    {
      Regex totalRegex = new Regex(@"^Total:\s*\d+\.\d{2}", RegexOptions.Multiline);
      if (!totalRegex.IsMatch(fisier))
      {
        Console.WriteLine("Totalul nu respecta formaul.");
        return false;
      }
      return true;
    }
  }
}