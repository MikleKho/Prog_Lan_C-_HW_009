// Задача 2: Задайте значения M и N. Напишите программу, которая найдёт сумму
// натуральных элементов в промежутке от M до N с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8 -> 30
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SummarizeNumbers(int m, int n, int sum)
{
    if (m <= n)
    {
        sum = sum + m;
    }

    if (m == n) return (sum);
    m++;
    return (SummarizeNumbers(m, n, sum));
}

int m = Prompt("Введите меньшее натуральное число ---> ");
int n = Prompt("Введите большее натуральное число ---> ");
int sum = 0;
if (m < n)
{
    sum = SummarizeNumbers(m, n, sum);
    System.Console.WriteLine($"Сумма чисел ---> {sum}");
}
else System.Console.WriteLine("Ошибка ввода");