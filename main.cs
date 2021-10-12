using System;
using System.Linq;

class Program {
  public static void Main (string[] args) {

    int[] input = new int[10];
    for(int pos=0; pos < input.Length; pos++)
    {
      Console.WriteLine("Enter Value");
      input[pos]=Convert.ToInt32(Console.ReadLine());
    }
    Console.WriteLine("Even Number/s");
    foreach (int num in input)
    {
      if (num % 2 == 0)
      {
        int[] EvenNum = new int[1];
        for(int pos=0; pos < EvenNum.Length; pos++)
        {
         EvenNum[pos]=num;
        }
        Array.Sort(EvenNum);
        foreach (int even in EvenNum)
        {
         Console.WriteLine(even);
        }
        Console.WriteLine(EvenNum.Sum());
      }
    }
    Console.WriteLine("Odd Number/s");
    foreach (int num in input)
    {
      if (num % 2 !=0)
      {
        int[] OddNum = new int[1];
        for(int pos=0; pos < OddNum.Length; pos++)
        {
          OddNum[pos]=num;
        }

        Array.Sort(OddNum);
        Array.Reverse(OddNum);
        
        foreach (int odd in OddNum)
        {
          Console.WriteLine(odd);
        }
        Console.WriteLine(OddNum.Sum());
      }
    }
  }
}