/* 
2 друга идут навстречу друг другу, от первого до второго бежит собака,
как только собака добегает до второго друга, она разворачивается и бежит к первому.
Когда добегает до первого друга разворачивается и бежит ко второму.
Сколько раз успеет пробежать собака мужду друзьями пока они не встретятся?
Растояние которое считается, что друзья встретились 10м.
*/

Console.Clear();
double speedFirstFried, speedSecondFriend, speedDog, distance, time;
int runDog=0;
string s;
Console.Write("Введите скорость первого друга: ");
s=Console.ReadLine();
speedFirstFried=Convert.ToDouble(s);
Console.Write("Введите скорость второго друга: ");
s=Console.ReadLine();
speedSecondFriend=Convert.ToDouble(s);
Console.Write("Введите скорость собаки: ");
s=Console.ReadLine();
speedDog=Convert.ToDouble(s);
Console.Write("Введите расстояние мужду друзьями: ");
s=Console.ReadLine();
distance=Convert.ToDouble(s);

while (distance>10)
{
    if (speedDog==0)
    {
        System.Console.WriteLine("Собака сидит на месте, условия задачи не выполнены");
        distance=0;
    }
    else if (speedDog<=speedFirstFried)
    {
        System.Console.WriteLine("Собака бежит медленно и не сможет добежать до второго друга до встречи друзей.");
        distance=0;
    }
    if (speedDog>speedFirstFried & speedDog<=speedSecondFriend)
    {
        System.Console.WriteLine("Собака возможно успеет добежать до второго друга, но не успеет вернуться к первому не успеет до их встречи");
        time=distance/(speedSecondFriend+speedDog);
        distance=distance-(speedFirstFried+speedSecondFriend)*time;
        if (distance>=10)
        {
            runDog=1;
            distance=0;
        }

    }
    time=distance/(speedSecondFriend+speedDog);
    distance=distance-(speedFirstFried+speedSecondFriend)*time;
    if (distance>=10)
    {
        runDog=runDog+1;
    }
}


System.Console.WriteLine("Количество раз, которые собака успела пробежать между друзьями, пока они не встретились {0}", runDog);