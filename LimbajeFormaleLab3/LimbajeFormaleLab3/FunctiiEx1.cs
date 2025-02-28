using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajeFormaleLab3
{
  public class FunctiiEx1
  {
    private string stareCurenta = "q0";

    public void ComandaBautura(string comanda)
    {
      switch (stareCurenta)
      {
        case "q0":
          stareCurenta = comanda switch
          {
            "C" => "q1",
            "T" => "q2",
            "A" => "q3",
            "H" => "q4", 
            _ => stareCurenta 
          };
          break;

        case "q1": 
        case "q2": 
        case "q3": 
          stareCurenta = (comanda == "OK") ? "q4" : stareCurenta;
          break;

        case "q4":
          stareCurenta = (comanda == "OK") ? "q0" : stareCurenta;
          break;
      }
      switch (stareCurenta)
      {
        case "q1":
          Console.WriteLine("Cafea selectata. Apasa OK pentru confirmare.Stare curenta "+stareCurenta);
          break;
        case "q2":
          Console.WriteLine("Ceai selectat. Apasa OK pentru confirmare.Stare curenta "+stareCurenta);
          break;
        case "q3":
          Console.WriteLine("Cappuccino selectat. Apasa OK pentru confirmare.Stare curenta "+stareCurenta);
          break;
        case "q4":
          Console.WriteLine("Bautura e pregatita. Apasa OK pentru a reveni la meniu.Stare curenta "+stareCurenta);
          break;
      }
    }

  }
}
