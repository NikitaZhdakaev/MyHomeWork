/*Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
 Напишите программу, которая покажет количество чётных чисел в массиве.

int KolichestvoChetnix()
{
    int[] mass = new int[10];
    int schetchik = 0;

    for (int i = 0; i < 10; i++)
    {
        mass[i] = new Random().Next(100,1000);
        if (mass[i] % 2 == 0) schetchik = schetchik + 1;
        Console.Write(mass[i] + " ");
    }

    Console.WriteLine();
    return schetchik;
}

Console.WriteLine($"В массиве чётных чисел {KolichestvoChetnix()}");
*/

/* Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

int SummaNechetnixIndeksov()
{
    int[] mass = new int[10];
    int summa = 0;

    for (int i = 0; i < 10; i++)
    {
        mass[i] = new Random().Next(1,11);
        Console.Write(mass[i] + " ");
    }

    for (int i = 0; i < 10; i++)
    {
        if(i % 2 != 0) summa = summa + mass[i];
    }

    Console.WriteLine();
    return summa;
}

Console.WriteLine($"Сумма элементов с нечётными индексами = {SummaNechetnixIndeksov()}");
*/

/* Задача 38: Задайте массив вещественных дробных чисел.
Найдите разницу между максимальным и минимальным элементов массива.

double[] arrayRealNumbers = new double[10];
 for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
 arrayRealNumbers[i] = new Random().Next(1, 10);
 Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

 for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
 if (maxNumber < arrayRealNumbers[i])
    {
 maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double decision = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {decision}");
  */
  