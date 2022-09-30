// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

/*

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2)
{
    Console.WriteLine("max = " + n1);
}
else
{
    Console.WriteLine("max = " + n2);
}

*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

/*

Console.Write("Input a first number: ");
int n1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a second number: ");
int n2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a third number: ");
int n3 = Convert.ToInt32(Console.ReadLine());

if (n1 > n2 && n1 > n3)
{
    Console.WriteLine($"The first number ({n1}) is the maximum");
}
else if (n2 > n1 && n2 > n3)
{
    Console.WriteLine($"The second number ({n2}) is the maximum");
}
else
{
    Console.WriteLine($"The third number ({n3}) is the maximum");
}

*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
// является ли число чётным (делится ли оно на два без остатка).

Console.Write("Input a number ");
int n = Convert.ToInt32(Console.ReadLine());

if (n % 2 == 0)
{
    Console.Write($"The number ({n}) is an even number");
}
else
{
    Console.Write($"The number ({n}) is an odd number");
}
