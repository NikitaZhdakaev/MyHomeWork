/* Задача 66: Задайте значения M и N. 
Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

Console.Clear();
Console.WriteLine($"Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N");
int m = InputNumbers("Введите m: ");
int n = InputNumbers("Введите n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSumm(m, n, temp=0);

void PrintSumm(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма элементов= {summ} ");
    return;
  }
  PrintSumm(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}
*/

/* Задача 67: Напишите программу, 
которая будет принимать на вход число и возвращать кол-во его цифр.

int SumOfDigits(int number)
    {
 if(number/10==0) return 1;
 return 1 + SumOfDigits(number/10);
    }
Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(SumOfDigits(a));
*/
