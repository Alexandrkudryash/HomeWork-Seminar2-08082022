// ДЗ к Семинару-2 от 08.08.2022 
// Задача-1. Дано число обозначающее день недели. Выяснить является ли номер дня недели выходным.

Console.Clear();

Console.WriteLine("Введите число - день недели");
int n = int.Parse(Console.ReadLine()?? "0");

if (n >= 1 && n < 8) 
    { 
    if (n == 6)
    Console.WriteLine("Это выходной день - Суббота");
    if (n == 7)
    Console.WriteLine("Это выходной день - Воскресенье");
    else
    Console.WriteLine("Этот день не является выходным");
    }

else
    {
    Console.WriteLine("Вы ввели число НЕ обозначающее день недели");
    }