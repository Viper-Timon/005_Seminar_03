// Задача 19: Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

// Решение через метод с циклом
Console.Write("Введите число ");
int number = int.Parse(Console.ReadLine());

void FindNumPalin(int num)
{
    // определение количества знаков 
    if (num < 0) num = num * -1;
    int count = 0;
    int num1 = num;
    int num2 = num;
    
    while (num1 > 0)
    {
        num1 = num1 / 10;
        count++;
    }

    // создание и заполнение массива
    int[] col1 = new int[count];

    for (int i = 0; i < count; i++)
    {
        col1[i] = num2 % 10;
        num2 = num2 / 10;
    }

    int collen = col1.Length;
    string result = "Не вышло"; 

    // цикл для сравнения
    for (int j = 0; j < (collen / 2); j++)
    {
       if (col1[j] == col1[(collen-1)-j])
       {   
            result = "Да";
       }
       else
       {
            result = "Нет";
            break;
       }
    }
    Console.WriteLine(result);
    
}

FindNumPalin(number);
