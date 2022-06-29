/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

void KolichestvoBolshe0(int[] massivNum)
{
    int counter = 0;
    int[] massivBolshe0 = new int[massivNum.GetLength(0)];

    for (int i = 0; i < massivBolshe0.GetLength(0); i++)
    {
        massivBolshe0[i] = massivNum[i];
        if(massivBolshe0[i] > 0) counter = counter + 1;
        Console.Write($"{massivBolshe0[i]} ");
    }

    Console.WriteLine();
    Console.WriteLine($"{counter} чисел больше 0");
}

Console.WriteLine("введите количество чисел для проверки");
int counteNumber = Convert.ToInt32(Console.ReadLine());
int[] massivNumber = new int[counteNumber];

for (int i = 0; i < massivNumber.GetLength(0); i++)
{
    Console.WriteLine("введите целое число");
    massivNumber[i] = Convert.ToInt32(Console.ReadLine());
}

KolichestvoBolshe0(massivNumber);
*/

/* Задача 45: Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

int[] CopyArray(int[] array)
{
 int[] copy = new int[array.Length];
 int i = 0;
 foreach (int elem in array)
	{
 copy[i] = elem;
 i++;
	}
 return copy;
}
int[] array = { 54, 21, -5, 90, -56 };
int[] copyArray = CopyArray(array);
Console.WriteLine(string.Join(", ", copyArray));
*/

