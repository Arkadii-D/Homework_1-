// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int numA = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int numB = int.Parse(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int numC = int.Parse(Console.ReadLine());

if (numA > numB)
{
    if (numA >  numC)
    {
        Console.WriteLine("Максимальное число: " + numA);
    }
    else
    {
        Console.WriteLine("Максимальное число: " + numC);
    }
}

else if (numB > numC)
{
    Console.WriteLine("Максимальное число: " + numB);
}
else
{
    Console.WriteLine("Максимальное число: " + numC);
}
