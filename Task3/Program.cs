// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. Даны два 
// неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

Console.Write("Введите первое число для функции Аккермана: ");
int number1 = GetNumberFromUser();
Console.Write("Введите второе число для функции Аккермана: ");
int number2 = GetNumberFromUser();

int result = CalcAccermanFunc(number2, number1);
Console.WriteLine($"m = {number1}; N = {number2} -> {result}");

// Функции, используемые в программе
int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0)
        {
            return num;
        }
        else Console.WriteLine("Ошибка ввода!");
    }
}

int CalcAccermanFunc(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (m > 0 && n == 0)
    {
        return CalcAccermanFunc(m - 1, 1);
    }
    else if (m > 0 && n > 0)
    {
        return CalcAccermanFunc(m - 1, CalcAccermanFunc(m, n - 1));
    }
    else
    {
        return n + 1;
    }
}




