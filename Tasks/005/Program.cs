// Найти максимальное из трех чисел

Console.Clear();
double a=0, b, c, max=a;
string s;
Console.Write("Введите первое число а=");
s=Console.ReadLine();
a=Convert.ToDouble(s);
Console.Write("Введите второе число b=");
s=Console.ReadLine();
b=Convert.ToDouble(s);
Console.Write("Введите третье число c=");
s=Console.ReadLine();
c=Convert.ToDouble(s);

if (max<b)
{
    max=b;
}
if (max<c)
{
    max=c;
}
if (a==b & a==c)
{
    System.Console.WriteLine("Все три числа равны между собой");
}
System.Console.WriteLine("Максимальное число {0}", max);