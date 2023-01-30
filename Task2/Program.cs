// Задача 66: Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое число: ");
int number1 = GetNumberFromUser();
Console.Write("Введите второе число: ");
int number2 = GetNumberFromUser();

int sumNumbers = CalcSumNumbers(number1, number2);
Console.WriteLine($"M = {number1}; N = {number2} -> {sumNumbers}");



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


int CalcSumNumbers(int startNumber, int endNumber)
{
    if (startNumber == endNumber) return endNumber;
    else
    {
        if (endNumber > startNumber) return startNumber + CalcSumNumbers(startNumber + 1, endNumber);
        else return endNumber + CalcSumNumbers(startNumber, endNumber + 1);
    }
}


