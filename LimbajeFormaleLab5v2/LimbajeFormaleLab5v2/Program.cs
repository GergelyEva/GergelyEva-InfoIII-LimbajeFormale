namespace LimbajeFormaleLab5v2;
class Program
{
  static void Main(string[] args)
  {
    //ex1
    FunctiiEx1 moore = new FunctiiEx1();
    Console.WriteLine("Introdu un sir format din 1 si 0:");
    string input = Console.ReadLine();
    moore.GetInputs(input);
    
    //ex2
    FunctiiEx2 automat = new FunctiiEx2();
    Console.WriteLine("Introdu un sir format din a, b sau e (pentru epsilon):");
    string cuvant = Console.ReadLine();
    bool rezultat = automat.VerificaCuvant(cuvant);
    Console.WriteLine(rezultat ? "Sirul este valid." : "Sirul nu este valid.");
  }
}
