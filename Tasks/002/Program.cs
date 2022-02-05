// По двум заданным числам проверять является ли первое квадратом второго

Console.Clear();
double a, b;
string s;
Console.Write("Введите первое число, которое может оказаться квадратом второго а=");
s=Console.ReadLine();
a=Convert.ToDouble(s);
Console.Write("Введите второе число b=");
s=Console.ReadLine();
b=Convert.ToDouble(s);

if (a==b*b) 
{
    System.Console.WriteLine("{0} квадрат {1}", a, b);
}
else
{
    System.Console.WriteLine("{0} не является квадратом {1}", a, b);
}