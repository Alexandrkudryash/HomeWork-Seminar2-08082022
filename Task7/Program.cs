// ДЗ к Семинару-2 от 08.08.2022 
// Задача-7. Определить количество цифр в числе.

Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");
int i = 0;
while (n >0)
{
   n = n /=10;
   i++;
}
Console.WriteLine(i);
