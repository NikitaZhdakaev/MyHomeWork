// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа
/*
Console.Clear();

string SecDigit(int num)
{
 if (num < 100 ^ num > 999) 
    {
 string result = "Your number isn't met above mentioned requirement!";
 return result;
    }
 else
    {
 string result = (num + " -> " + num % 100 / 10);
 return result;
    }
}

Console.Write("Please, input a number between 100 and 999: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(SecDigit(num1));
*/
//Задача 13: Напишите программу, которая выводит третью цифру 
//заданного числа или сообщает, что третьей цифры нет
/*
Console.Clear();

string ThirdDigit(string num)
{
    if (num.Length < 3) 
    {
        string result = "Your number isn't met above mentioned requirement!";
        return result;
    }
    else
    {
        string result = (num + " -> " + num[2]);
        return result;
    }
}

Console.Write("Please, input a number more or equal 100: ");
string num1  = Console.ReadLine();

Console.WriteLine(ThirdDigit(num1));
*/
//Задача 15: Напишите программу, которая принимает на вход цифру,
//обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Clear();

bool WeekEnd(int num)
{
    if(num < 6) return false;
    else return true;
}

Console.WriteLine("Please, input a number matched to the weekday, as follow:" + "\n" +
                " 1 - Monday" + "\n" +
                " 2 - Tuesday" + "\n" +
                " 3 - Wednesday" + "\n" +
                " 4 - Thursday" + "\n" +
                " 5 - Friday" + "\n" +
                " 6 - Saturday" + "\n" +
                " 7 - Sunday");
int num1  = Convert.ToInt32(Console.ReadLine());

if (num1 < 1 ^ num1 > 7)
{
    Console.WriteLine("Your number isn't met above mentioned requirement!");
}
else
{
    if(WeekEnd(num1)) Console.WriteLine(num1 + " is Weekend");
    else Console.WriteLine(num1 + " is not Weekend");
}
*/