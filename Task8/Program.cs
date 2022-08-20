// ДЗ к Семинару-2 от 08.08.2022 
// Задача-8. Подсчитать сумму цифр в числе.

Console.Clear();
Console.WriteLine("Введите число");
int n = int.Parse(Console.ReadLine() ?? "0");
int temp = n;
int i = 0;
while (n > 0)
{
   n = n /=10;
   i++;
}
// Console.WriteLine(i);
// выше код - мы узнали сколько цифр в числе

Console.WriteLine("Запишем наше число в массив по каждой цифре");
string z = temp.ToString();
int[] array = new int[i];
int j = 0;
while (j < i)
{
    array[j] = int.Parse(z[j].ToString());
    Console.Write(array[j] +", ");
    j++;
}
Console.WriteLine();
Console.WriteLine("Просуммируем значения массива :");
int k = 0;
int sum =0;
while (k < i)
{
   sum = sum +array[k];
   k++;
}
Console.WriteLine(sum);