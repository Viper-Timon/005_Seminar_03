
// Console.WriteLine("Введите координату X:");
// int x = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите координату Y:");
// int y = int.Parse(Console.ReadLine());
// if (x > 0 && y > 0) Console.WriteLine("1");
// else if (x > 0 && y > 0) Console.WriteLine("Диапазон 1");
// else if (x < 0 && y > 0) Console.WriteLine("Диапазон 2");
// else if (x < 0 && y < 0) Console.WriteLine("Диапазон 3");
// else if (x > 0 && y < 0) Console.WriteLine("Диапазон 4");
// else Console.WriteLine ("Введите координаты отличные от 0");


// Console.WriteLine("Введите номер диапазона от 1 до 4");
// int diap = int.Parse(Console.ReadLine());
// if (diap == 1) Console.WriteLine("Соответствует значениям x > 0 и y > 0");
// else if (diap == 2) Console.WriteLine("Соответствует значениям x < 0 и y > 0");
// else if (diap == 3) Console.WriteLine("Соответствует значениям x < 0 и y < 0");
// else if (diap == 4) Console.WriteLine("Соответствует значениям x > 0 и  < 0");
// else Console.WriteLine("Вы ввели неверный номер диапазона");


//через Метод
void FindDiap(int quarter) 
{
    if (quarter == 1) 
    {
        Console.WriteLine("Соответствует значениям x > 0 и y > 0");
    }
    else if (quarter == 2) 
    {
        Console.WriteLine("Соответствует значениям x < 0 и y > 0");
    }
    else if (quarter == 3) 
    {
        Console.WriteLine("Соответствует значениям x < 0 и y < 0");
    }
    else if (quarter == 4) 
    {
        Console.WriteLine("Соответствует значениям x > 0 и  < 0");
    }
    else 
    {
        Console.WriteLine("Вы ввели неверный номер диапазона");
    }
}

Console.WriteLine("Введите номер диапазона от 1 до 4");
int diap = int.Parse(Console.ReadLine());
FindDiap(diap);
