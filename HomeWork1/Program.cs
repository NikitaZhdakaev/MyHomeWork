  /* Задача 2

  var n1 = Decimal.Parse(Console.ReadLine());
            var n2 = Decimal.Parse(Console.ReadLine());
            if (n1 > n2)
                Console.WriteLine(n1);
            else 
                Console.WriteLine(n2);
                */


/* Задача 6

int n = 100;
Console.Write("Введите число: ");
n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(n % 2 == 0 ? "Четное" : "Не четное");
*/

/* Задача 4

int m1, m2, m3, Mmax = 10;

Console.Write("Введите число: ");
m1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
m2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число: ");
m3 = Convert.ToInt32(Console.ReadLine());

if (m1 > m2) 
{
    m1 = Mmax;
}
else
{
    m2 = Mmax;
}
if (m2 > m3)
{
    m2 = Mmax;
}
else
{
    m3 = Mmax;
}
if (m3 > m1)
{
    m3 = Mmax;
}
else
{
    m1 = Mmax;
}

Console.WriteLine(Math.Max(m1, Math.Max(m2, m3)));
*/

/* Задача 8
int N = int.Parse(Console.ReadLine());
int i = 1, k = 1;            
while (true)
{
	if (i % 2 == 0)
	{
		Console.Write(i + " ");
		k++;
	}
	if (k > N)
	{
		break;
	}
	i++;
}
*/