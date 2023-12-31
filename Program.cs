using System;

class Program 
{
  static void Main(string[] args) 
  {
    
    Console.Write("а=");
    int num = int.Parse(Console.ReadLine());

    if(num % 7 == 0 && num % 23 == 0) 
    {
      Console.WriteLine("Да");
    }
    else 
    {
      Console.WriteLine("Нет"); 
    }

  }
}


