// ДЗ к Семинару-2 от 08.08.2022 
// Задача-2. По двум заданным числам проверять является ли одно квадратом другого.

Console.Clear();
Console.WriteLine("Введите два числа");
int a = int.Parse(Console.ReadLine() ?? "0");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a / b == b) 
{
    Console.WriteLine("Первое число является квадратом второго");
}
else
{
    Console.WriteLine("Первое число не является квадратом второго");
}

if (b / a == a) 
{
    Console.WriteLine("Второе число является квадратом первого");
}
else
{
    Console.WriteLine("Второе число не является квадратом первого");
}


