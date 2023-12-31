//Задача 1: Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
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


//Задача 2: Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.
using System;

class Program 
{
  static void Main(string[] args) 
  {
    Console.Write("Введите координату X: ");
    int x = int.Parse(Console.ReadLine());

    Console.Write("Введите координату Y: ");  
    int y = int.Parse(Console.ReadLine());

    if(x > 0 && y > 0) 
    {
      Console.WriteLine("1");
    }
    else if(x < 0 && y > 0) 
    {
      Console.WriteLine("2");  
    }
    else if(x < 0 && y < 0) 
    {
      Console.WriteLine("3");
    }
    else if(x > 0 && y < 0) 
    {
      Console.WriteLine("4");
    }
  }
}


//Задача 3: Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.
using System;

class Program 
{
  static void Main(string[] args) 
  {

    Console.Write("Введите число от 10 до 99: ");
    int num = int.Parse(Console.ReadLine());

    if(num < 10 || num > 99) 
    {
      Console.WriteLine("Число не в диапазоне от 10 до 99");
      return;
    }

    int firstDigit = num / 10;
    int secondDigit = num % 10;

    int maxDigit = Math.Max(firstDigit, secondDigit);

    Console.WriteLine("Наибольшая цифра числа: " + maxDigit);

  }
}


//Задача 4: Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.
using System;
using System.Collections.Generic;

class Program 
{

  static void Main(string[] args) 
  {

    Console.Write("Введите число: ");
    int num = int.Parse(Console.ReadLine());

    List<int> digits = new List<int>();

    while (num > 0) 
    {
      digits.Insert(0, num % 10);  
      num /= 10;
    }

    for(int i = 0; i < digits.Count; i++) 
    {
      if (i > 0) Console.Write(",");
      Console.Write(digits[i]); 
    }

  }

}
