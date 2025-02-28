using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LimbajeFormaleLab3
{
  public class FunctiiEx2
  {
    private int[] locuriParcare;
    private int numarLocuri;

    public FunctiiEx2(int numarLocuri)
    {
      this.numarLocuri = numarLocuri;
      locuriParcare = new int[numarLocuri];
    }
    public void ProceseazaComanda(string comanda)
    {
      switch (comanda)
      {
        case "P": 
          int locLiber = GasesteLocLiber();
          if (locLiber != -1)
          {
            locuriParcare[locLiber] = 1;
            Console.WriteLine($"Masina parcata la locul {locLiber + 1}");
          }
          else
          {
            Console.WriteLine("Parcarea este deja plina.");
          }
          break;

        case "A": 
          int locOcupat = GasesteLocOcupat();
          if (locOcupat != -1)
          {
            locuriParcare[locOcupat] = 0; 
            Console.WriteLine($"Masina a plecat de la locul { locOcupat + 1}");
          }
          else
          {
            Console.WriteLine("Parcarea este goala.");
          }
          break;

        case "O": 
          AfiseazaStareaParcarii();
          break;

        default:
          Console.WriteLine("Foloseste P pentru a parca o masina pe primul loc disponibil," +
            " A ca sa plece o masina din parcare, sau O pentru a vedea starea parcarii");
          break;
      }

    }
    private int GasesteLocLiber()
    {
      for (int i = 0; i < numarLocuri; i++)
      {
        if (locuriParcare[i] == 0)
        {
          return i;
        }
      }
      return -1;
    }

    private int GasesteLocOcupat()
    {
      for (int i = 0; i < numarLocuri; i++)
      {
        if (locuriParcare[i] == 1)
        {
          return i;
        }
      }
      return -1;
    }

    private void AfiseazaStareaParcarii()
    {
      Console.WriteLine("Starea parcarii:");
      for (int i = 0; i < numarLocuri; i++)
      {
        Console.WriteLine($"Loc {i + 1}: {(locuriParcare[i] == 0 ? "Liber" : "Ocupat")}");
      }
    }
  }
}
