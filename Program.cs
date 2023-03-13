//  Задача 64: Задайте значения N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
//  N = 5. -> "5, 4, 3, 2, 1"
//  N = 8. -> "8, 7, 6, 5, 4, 3, 2, 1"


Console.Write("Число N = ");
int number = int.Parse(Console.ReadLine());

if (number <= 0) Console.Write($"{number} заданное значение не соответствует условию задачи");
int start = 1;
naturalRow(number, start);

void naturalRow(int N, int count)
{
    if (count > N) return;
    else
    {
        naturalRow(N, count + 1);
        Console.Write(count + "  ");
    }
}

