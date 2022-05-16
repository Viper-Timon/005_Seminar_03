Console.Clear();
Console.Write("Введите X1 ->");
int x1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1 ->");
int y1 = int.Parse(Console.ReadLine());
Console.Write("Введите X2 ->");
int x2 = int.Parse(Console.ReadLine());
Console.Write("Введите Y2 ->");
int y2 = int.Parse(Console.ReadLine());
double result = Math.Sqrt(Math.Pow(x2-x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine(Math.Round(result, 3));

