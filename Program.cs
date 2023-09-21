//Example_001
// Задача вывода Hello World!
// Console.WriteLine("123 Hello, World!");

//Example_002
// Задача вывода приветствия пользователя.
//Console.WriteLine("Введите Ваше имя ");
//string username=Console.ReadLine();
//Console.Write("Привет, ");
//Console.Write(username);
//Console.Write("!");

//Example_003
//написать программу, выводящую сумму двух натуральных чисел на экран.

//Console.WriteLine("Введите два числа ");
//int numberA=Convert.ToInt32(Console.ReadLine());
//int numberB=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine(numberA+numberB);

//Example_004
//написать программу выводящую частное двух чисел.
//double numberA = new Random().Next(1,10);
//double numberB = new Random().Next(1,10);
//Console.WriteLine(numberA);
//Console.WriteLine(numberB);
//double result = numberA/numberB;
//Console.WriteLine(result);

//Example_005
//Написать программу, приветствующую "любимчика" по-особенному.
//Console.WriteLine("Введите ваше имя: ");
//string username = Console.ReadLine();

//if(username.ToLower() == "Маша")
//{
//Console.WriteLine("Ура, это же Маша!");
//}
//else
//{
//  Console.Write("Привет, ");
//Console.WriteLine(username);
//}

//Example_006

// int a = 1;
// int b = 2;
// int c = 6;
// int d = 8;
// int e = 4;

// int max = a;

// if (b > max) max = b;
// if (c > max) max = c;
// if (d > max) max = d;
// if (e > max) max = e;

// Console.Write("max = ");
// Console.WriteLine(max);

//Example_007
Console.Clear();
// Console.SetCursorPosition(10,4);
// Console.WriteLine("+");

int xa = 1, ya = 1,
xb = 1, yb = 30,
xc = 40, yc = 30;

Console.SetCursorPosition(xa, ya);
Console.WriteLine("+");

Console.SetCursorPosition(xb, yb);
Console.WriteLine("+");

Console.SetCursorPosition(xc, yc);
Console.WriteLine("+");

int x = xa, y = yb;

int count = 0;

while (count < 1000)
{
    int what = new Random().Next(0, 3);
    if (what == 0)
    {
        x = (x + xa) / 2;
        y = (y + ya) / 2;
    }
    if (what == 1)
    {
        x = (x + xb) / 2;
        y = (y + yb) / 2;
    }
    if (what == 2)
    {
        x = (x + xc) / 2;
        y = (y + yc) / 2;
    }

    Console.SetCursorPosition(x, y);
    Console.WriteLine("+");
    count = count + 1;
}
