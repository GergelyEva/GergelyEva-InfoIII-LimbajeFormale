using LimbajeFormaleLab3;

class Program
{
  static void Main(string[] args)
  {
    //ex1
    FunctiiEx1 automat = new FunctiiEx1();

    Console.WriteLine("Automat de bauturi: Cafea (C), Ceai (T), Cappuccino (A), Ciocolata calda (H), Confirmare (OK)");
    // while (true)
    //{
    Console.Write("Introdu o comanda (C/T/A/H/OK): ");
    string bautura = Console.ReadLine().ToUpper();

    automat.ComandaBautura(bautura);
    //}

    //ex2
    Console.WriteLine("Introdu numarul de locuri de parcare");
    int nrlocuriparcare= Convert.ToInt32(Console.ReadLine());
    FunctiiEx2 parcare = new FunctiiEx2(nrlocuriparcare);

    Console.WriteLine("Parcare Automata: Parcheaza (P), Paraseste parcare (A), Arata optiuni (O)");
    while (true)
    {
      Console.Write("Introdu o comanda (P/A/O): ");
      string actiune = Console.ReadLine().ToUpper();

      parcare.ProceseazaComanda(actiune);
    }
  }
}