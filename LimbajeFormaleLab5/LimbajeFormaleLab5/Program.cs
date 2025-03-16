using LimbajeFormaleLab5;


class Program
{
  static void Main()
  {
    //ex1
    Console.WriteLine("Introdu un string format din a,e(epsilon),b");
    string cuvant = Console.ReadLine().ToLower();
    FunctiiEx1 automat = new FunctiiEx1();
    bool isAccepted = automat.VerificaCuvant(cuvant);
    Console.WriteLine(isAccepted ? "Drum corect" : "Drum incorect");

    //ex2
    Console.WriteLine("Moore - introdu un string format din a si/sau b.");
    string mooreInput = Console.ReadLine().ToUpper();
    FunctiiEx2 moore = new FunctiiEx2();
    moore.GetInputs(mooreInput);

    //ex3
    Console.WriteLine("Mealy - introdu un string format din x si/sau y.");
    string mealyInput = Console.ReadLine().ToUpper();
    FunctiiEx3 mealy = new FunctiiEx3();
    mealy.GetInputs(mealyInput);
  }
}