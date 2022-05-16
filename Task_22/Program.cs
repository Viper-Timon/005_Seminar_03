
// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

Console.Clear();
Console.WriteLine("Введите число N");
int n = int.Parse(Console.ReadLine());
int index = 1;

while (index <= n)
{
    int result = index * index;
    Console.WriteLine($"{index, 10} | {result, 10}");
    index++;
}
Console.WriteLine();
Console.WriteLine("Квадраты всех чисел от 1 до N");