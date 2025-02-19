using LimbajeFormaleLab2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
  static void Main()
  {
    //ex1
    FunctiiEx1 automatFinit = new FunctiiEx1();

    Console.Write("Introdu drumul reprezentat de numerele 0 si 1: ");
    string input = Console.ReadLine();

    Console.WriteLine(string.IsNullOrEmpty(input)
    ? "Nu s-a introdus valorile."
    : (automatFinit.VerificareDrum(input) ? "Corect." : "Incorect."));

    //ex2

    FunctiiEx2 ex2 = new FunctiiEx2();

    Console.Write("Introdu un cuvant care poate contine subsirul \"cat\": ");
    string sirCaractere = Console.ReadLine();

    if (!string.IsNullOrEmpty(sirCaractere))
    {
      Console.WriteLine(ex2.VerificareCuvant(sirCaractere) ? "Subsirul exista in sir" : "Subsirul nu exista in sir");
    }


    //ex3
    List<string> limbaj = Functiiex3.GenerareCuvinte();

    Functiiex3 ex3 = new Functiiex3();

    Random random = new Random();
    for (int i = 0; i < 3; i++)
    {
      string cuvant = limbaj[random.Next(limbaj.Count)];
      bool corect = ex3.CuvantCorect(cuvant);

      Console.WriteLine($"\"Cuvantul\": '{cuvant}' e {(corect ? "corect" : "nu e corect")}.");
    }


    //ex4

    FunctiiEx4 verificator = new FunctiiEx4();

    Console.Write("Introdu calea catre fisier: ");
    string filePath = Console.ReadLine();

    verificator.VerificaFactura(filePath);

  }

}



