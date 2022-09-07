// Задача 3: Напишите программу вычисления функции Аккермана с помощью
// рекурсии. Даны два неотрицательных числа m и n.
// m = 3, n = 2 -> A(m,n) = 29
int Prompt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int DoAkkermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return DoAkkermanFunction(m - 1, 1);
    }
    else
    {
        return DoAkkermanFunction(m - 1, DoAkkermanFunction(m, n - 1));
    }

}
int m = Prompt("Введите первое число--->");
int n = Prompt("Введите второе число--->");
int result = DoAkkermanFunction(m, n);
System.Console.WriteLine($"Функция Аккермана равна  {result}");