/* Задача 1. Задайте массив строк. Напишите программу, 
считает кол-во слов в массиве, начинающихся на гласную букву.

string[] CreateStringArray(int size )
{
 string[] words = new string [size];
 for(int i = 0; i < size; i++)
    {
 Console.Write($"Input {i + 1} word: ");
 words [i]= Console.ReadLine();
    }
    return words;
}
void ShowArray(string[] array)
{
   for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
int QuantityOfWords(string[] array)
{
    int count = 0;
    char [] volwe = {'a', 'e', 'i', 'o', 'u', 'y'};
    for (int i = 0; i < array.Length; i++)
    {
        for (int j = 0; j < volwe.Length; j++)
            if (Char.ToLower(array[i][0]) == volwe[j]) count++;
    } 
    return count;
}
Console.Write("Input the size of arrays: ");
int size = Convert.ToInt32(Console.ReadLine());
string[] names = CreateStringArray(size);
Console.WriteLine(" " + QuantityOfWords(names));
*/

/* Задача 2. Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.

string [] UnitElementsOfArray(string [] array)
{
    int merge = 0;
    if (array.Length % 2 != 0) merge = 1;    
    string [] array1 = new string [array.Length / 2 + merge];
    for (int i = 0; i < array1.Length; i++)
    {
        if (i * 2 + 1 < array.Length) array1[i] = array[i * 2] + array[i * 2 + 1];
        else array1[i] = array [i * 2];
    }
    return array1;
}
void ShowNewArray(string[] array)
{
   for(int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
    
    Console.WriteLine();
}
string [] array = {"fgh", "sdgr", "AAA", "ddG","drthuty","srtdrtr", "DDGrrD", "shuh"};
ShowNewArray(array);
string [] newArray = UnitElementsOfArray(array);
ShowNewArray(newArray);
*/
