﻿// По заданному номеру дня недели вывести его название

Console.Clear();
int a;
string s;
Console.Write("Введите номер дня недели: ");
s=Console.ReadLine();
a=Convert.ToInt32(s);

if (a==1)
{
    System.Console.WriteLine("Понедельник");
}
else if (a==2)
{
    System.Console.WriteLine("Вторник");
}

else if (a==3)
{
    System.Console.WriteLine("Среда");
}
else if (a==4)
{
    System.Console.WriteLine("Четверг");
}
else if (a==5)
{
    System.Console.WriteLine("Пятница");
}
else if (a==6)
{
    System.Console.WriteLine("Суббота");
}
else if (a==7)
{
    System.Console.WriteLine("Воскресенье");
}

else 
{
    System.Console.WriteLine("Введено не правильное значение");
}