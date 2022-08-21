// ДЗ к Семинару-2 от 08.08.2022 
// Задача-10. Показать кубы чисел, заканчивающихся на чётную цифру.


Console.Clear();
Console.WriteLine("введите размер массива");
int size = int.Parse(Console.ReadLine() ?? "0");

void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 1000);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.Write(col[position] +", ");
        position++;
    }
}

int [] array = new int[size];
FillArray(array);
PrintArray(array);
Console.WriteLine();

Console.WriteLine("Кубы чисел заканчивающихся на чётную цифру: " );
double [] result = new double[size];
for (int i = 0; i < size; i++)
{
 if (array[i]%2 == 0)
     {
     result[i] = Math.Pow(array[i],3);
     Console.Write(result[i] +", ");
     }
  else Console.Write(", <X>, ");
 }
 
Console.WriteLine();

