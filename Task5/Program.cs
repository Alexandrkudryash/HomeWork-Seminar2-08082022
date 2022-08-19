// ДЗ к Семинару-2 от 08.08.2022 
// Задача-5. Найти кубы чисел от 1 до N.

Console.Clear();

Console.WriteLine("введите размер массива");
int size = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];
array[0] = 1;
Console.WriteLine();
Console.WriteLine("получается такой массив:");
Console.Write(array[0] +", ");
int j = 1;
while (j < size)
{
    array[j] = array[j-1] + 1;
    Console.Write(array[j] +", ");
    j++;
}
Console.WriteLine();
Console.WriteLine("Кубы чисел от 1 до введенного числа:");
double [] result = new double[size];
for (int i = 0; i < size; i++)
{
 result[i] = Math.Pow(array[i],3);
 Console.Write(result[i] +", ");
}
Console.WriteLine();
