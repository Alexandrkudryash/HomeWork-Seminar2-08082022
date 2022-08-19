// ДЗ к Семинару-2 от 08.08.2022 
// Задача-4. Найти расстояние между точками в пространстве 2Д/3Д.

Console.Clear();
double xa = new Random().Next(1, 100);
double ya = new Random().Next(1, 100);
double xb = new Random().Next(1, 100);
double yb = new Random().Next(1, 100);
double za = new Random().Next(1, 100);
double zb = new Random().Next(1, 100);
Console.WriteLine("Точка А имеет координаты: " +"x = " +xa +", y = " + ya + ", z = " +za);
Console.WriteLine("Точка B имеет координаты: " +"x = " +xb +", y = " + yb +", z= " +zb);
//double n = double.Parse(ConsoleReadLine() ?? "0");

Console.WriteLine("Для нахождения расстояния между точкой A и B в пространстве 3Д");
Console.WriteLine("выполним следующие математические действия:");

double distance1 = Math.Pow((xb -xa), 2);
double distance2 = Math.Pow((yb -ya), 2);
double distance3 = Math.Pow((zb -za), 2);
double N = distance1+distance2+distance3;
Console.WriteLine(" Квадрат разности Xa - Xb = " +distance1);
Console.WriteLine(" Квадрат разности Ya - Yb = " +distance2);
Console.WriteLine(" Квадрат разности Za - Zb = " +distance3);

Console.WriteLine("Корень квадратный из суммы квадратов разности даст нам расстояние между точками:");
Console.WriteLine(Math.Sqrt(distance1+distance2+distance3));

