// See https://aka.ms/new-console-template for more information
using LimbajeFormaleLab1;
using System;
class Program
{
  static void Main()
  {
    //ex1
    Console.WriteLine("Ex1");
    string A = "bac123";
    string B = "zyab3";

    Console.WriteLine("Alfabet A: " + new string(FunctiiEx1.A));
    Console.WriteLine("Alfabet B: " + new string(FunctiiEx1.B));
    Console.WriteLine("Alfabet C: " + new string(FunctiiEx1.C));


    Console.WriteLine("Stringurile de start sunt:");
    Console.WriteLine("A: " + A);
    Console.WriteLine("B: " + B);

    Console.WriteLine("Concatenare A cu B: " + FunctiiEx1.Concatenate(A, B));
    Console.WriteLine("Inversare B: " + FunctiiEx1.Invers(B));
    Console.WriteLine("Substituire y cu 2 in sirul B: " + FunctiiEx1.Substituie(B, 'y', '2'));
    Console.WriteLine("Lungime '" + A + "': " + FunctiiEx1.Lungime(A));

    //ex2
    Console.WriteLine("Ex2");

    //enumuri pentru cele 3 alfabete, din cauza ca sigma3 are ca si simbol 2 caractere.
    Console.WriteLine("Cele 3 alfabete sunt:");
    var abc1 = Enum.GetValues(typeof(FunctiiEx2.Alfabet1));
    int length1 = abc1.Length;

    for (int i = 0; i < length1; i++)
    {
      string value = Enum.GetName(typeof(FunctiiEx2.Alfabet1), abc1.GetValue(i)).TrimStart('_');

      if (i == length1 - 1)
      {
        Console.WriteLine(value);
      }
      else
      {
        Console.Write(value + ", ");
      }
    }
    var abc2 = Enum.GetValues(typeof(FunctiiEx2.Alfabet2));
    int length2 = abc2.Length;

    for (int i = 0; i < length2; i++)
    {
      string value = Enum.GetName(typeof(FunctiiEx2.Alfabet2), abc2.GetValue(i)).TrimStart('_');

      if (i == length2 - 1)
      {
        Console.WriteLine(value);
      }
      else
      {
        Console.Write(value + ", ");
      }
    }
    var abc3 = Enum.GetValues(typeof(FunctiiEx2.Alfabet3));
    int length3 = abc3.Length;

    for (int i = 0; i < length3; i++)
    {
      string value = Enum.GetName(typeof(FunctiiEx2.Alfabet3), abc3.GetValue(i)).TrimStart('_');

      if (i == length3 - 1)
    {
      Console.WriteLine(value);
    }
    else
    {
      Console.Write(value + ", ");
    }
  }

  string s1 = FunctiiEx2.Alfabet2.a.ToString() + FunctiiEx2.Alfabet1._5.ToString().Substring(1) + FunctiiEx2.Alfabet3.x3.ToString();
    string s2 = FunctiiEx2.Alfabet2.g.ToString() + FunctiiEx2.Alfabet1._1.ToString().Substring(1) + FunctiiEx2.Alfabet3.y2.ToString();

    Console.WriteLine("Stringurile de start sunt:");
    Console.WriteLine("S1: " + s1);
    Console.WriteLine("S2: " + s2);

    Console.WriteLine("Concatenare s1 cu s2: " + FunctiiEx2.Concatenate(s1, s2));

    Console.WriteLine("Repetare  s1 de 2 ori: " + FunctiiEx2.Repeat(s1, 2));
    Console.WriteLine("Inversare s1: " + FunctiiEx2.Reverse(s1));
    Console.WriteLine("Extractie (0-2) din s1: " + FunctiiEx2.Extract(s1, 0, Math.Min(2, s1.Length - 1)));
    Console.WriteLine("Inlocuire 'a5' cu 'z1': " + FunctiiEx2.Replace(s1, "a5", "z1"));


    //ex3
    Console.WriteLine("Ex3");

    //generare de palindroame recursiv 
    Console.WriteLine("Palindroame:");
    FunctiiEx3.GeneratePalindromes("");

    //ex4
    Console.WriteLine("Ex4");

    Console.Write("Introdu numarul maxim de litere 'a': ");
    int maxA = int.Parse(Console.ReadLine());

    Console.Write("Introcu numarul maxim de litere 'b': ");
    int maxB = int.Parse(Console.ReadLine());
    
    Console.WriteLine("Cuvintele generate:");
    FunctiiEx4.GenerateStrings("",maxA, maxB);
    
  }
}

