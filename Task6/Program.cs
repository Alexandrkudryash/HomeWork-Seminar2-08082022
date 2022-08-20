// ДЗ к Семинару-2 от 08.08.2022 
// Задача-6. Найти сумму чисел от 1 до А.

Console.Clear();

Console.WriteLine("введите размер массива");
int size = int.Parse(Console.ReadLine() ?? "0");

int[] array = new int[size];
array[0] = 1;
Console.WriteLine();
Console.WriteLine("получается такой массив:");
Console.Write(array[0] +", ");
int i = 1;
while (i < size)
{
    array[i] = array[i-1] + 1;
    Console.Write(array[i] +", ");
    i++;
}
Console.WriteLine();
Console.WriteLine("Сумма чисел от 1 до введенного числа:");

int j = 1;
int sum = array [0];
while (j < size)
 {
    array[j] = array[j-1]+1;
    sum = sum+array[j];
    j++;
}
Console.WriteLine(sum);