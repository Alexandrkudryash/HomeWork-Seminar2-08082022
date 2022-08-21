// ДЗ к Семинару-2 от 08.08.2022 
// Задача-9. Написать программу вычисления произведения чисел от 1 до N.

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
Console.WriteLine("Произведение чисел от 1 до введенного числа:");

int Factorial (int size)
{
    if (size == 1) return 1;
    else return size * Factorial(size-1);
}
Console.WriteLine(Factorial(size));

/*
int j = 1;
int x = 1;
while (j < size)
 {
    int x = x * array[j]; здесь код выдаёт ошибку не пойму почему. 
    Console.Write(x +", "); для решения задачи взял код из лекции-4 для расчета N-факториала
    j++;
 }*/
Console.WriteLine();