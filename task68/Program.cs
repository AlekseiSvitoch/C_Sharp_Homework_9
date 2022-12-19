// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int A(int m, int n)
{
    int b = 0;
    if (m == 0)
        return n + 1;
    else if (m > 0 && n == 0)
        return A(m - 1, 1);
    else if (m > 0 && n > 0)
        return A(m - 1, A(m, n - 1));
    else
        return b;
}

Console.Clear();
Console.Write("Введите 1-е неотрицательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-е неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
if (m < 0 || n < 0)
    Console.WriteLine("Ошибка! Введите два неотрицательных числа");
else
    Console.WriteLine($"Ответ: {A(m, n)}");
    
