// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello,dude!");

Random n = new Random();
int x = n.Next(50);

Console.WriteLine("Напишите число от 0 до 50");

int y = Convert.ToInt32(Console.ReadLine());

if (x == y)
{
    Console.WriteLine("Вы отгадали число");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Вы не угадали число, попробуйте еще раз");
}

int r = Convert.ToInt32(Console.ReadLine());
if (x == r)
{
    Console.WriteLine("Вы отгадали число");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Вы не угадали число, попробуйте еще раз");
}

int g = Convert.ToInt32(Console.ReadLine());
if (x == g)
{
    Console.WriteLine("Вы отгадали число");
    Environment.Exit(0);
}
else
{
    Console.WriteLine("Вы не угадали число, попробуйте еще раз");
}
