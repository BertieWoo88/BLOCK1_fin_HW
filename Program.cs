/* Задача: Написать програму, которая из имеющегося массива строк формирует массив из строк, длина которых 
меньше либо равна З символа. Первоначаљный массив можно ввести с клавиатуры, либо задать на старте 
выполнения алгоритма. При решении не рекоменщется пользоваться коллеюкциями, лучше обойтись 
исключительно массивами. */

using System;
using static System.Console;

Clear();
string[] check = GetArr();
Printarr(check);

string [] GetArr() // метод получения массива строк из одной введеной строки
{
    WriteLine("Введите cтроки для массива строк через пробел: ");
    string Strforarray = ReadLine()!;
    string[] result = Strforarray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    return result;
}


void Printarr (string [] arr) // Метод ввыода массива строк
{
  Console.Write("[ ");
  for(int i = 0; i < arr.Length-1; i ++)
  {
    Console.Write($"{arr[i]}, ");
  }
    Console.Write($"{arr[arr.Length-1]} ");
    Console.Write("]");
}

