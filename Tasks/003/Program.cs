// Даны два числа. Показать большее и меньшее число

Console.Clear();
double a, b;
string s;
Console.Write("Введите первое число а=");
s=Console.ReadLine();
a=Convert.ToDouble(s);
Console.Write("Введите второе число b=");
s=Console.ReadLine();
b=Convert.ToDouble(s);

if (a>b)
{
    System.Console.WriteLine("Наибольшее {0}, наименьшее {1}", a, b);
}
else if (b>a)
{
    System.Console.WriteLine("Наибольшее {0}, наименьшее {1}", b, a);
}
else
{
    System.Console.WriteLine("Значения {0} и {1} равны", a, b);
}