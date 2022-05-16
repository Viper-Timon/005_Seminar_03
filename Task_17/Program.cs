
Console.WriteLine("Введите координату X:");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите координату Y:");
int y = int.Parse(Console.ReadLine());
if (x > 0 && y > 0) Console.WriteLine("1");
else if (x > 0 && y > 0) Console.WriteLine("Диапазон 1");
else if (x < 0 && y > 0) Console.WriteLine("Диапазон 2");
else if (x < 0 && y < 0) Console.WriteLine("Диапазон 3");
else if (x > 0 && y < 0) Console.WriteLine("Диапазон 4");
else Console.WriteLine ("Введите координаты отличные от 0");