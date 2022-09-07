// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все
// чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8" 

int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

void OutputEvenNumbers(int M, int N)
{
    if (M <= N)
    {
        if ((M % 2) == 0) System.Console.Write($" {M}");
    }

    if (M == N) return;
    M++;
    OutputEvenNumbers(M, N);
}

int M = Prompt("Введите меньшее натуральное число ---> ");
int N = Prompt("Введите большее натуральное число ---> ");
if (M < N)
{
    OutputEvenNumbers(M, N);
}
else System.Console.WriteLine("Ошибка ввода");