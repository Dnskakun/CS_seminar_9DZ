// Задача 64: Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке
// от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите число: ");
int number = GetNumberFromUser();
PrintReversNumberSequence(number);



//Функции, используемые в программе
int GetNumberFromUser()
{
    while (true)
    {
        bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
        if (isCorrect && num > 0) return num;
        else Console.WriteLine("Ошибка ввода");
    }
}

void PrintReversNumberSequence(int startNum)
{
    Console.Write($"N = {startNum} -> ");
    ReversNumberSequence(startNum);
    int ReversNumberSequence(int startNumber)
    {
        if (startNumber == 1)
        {
            Console.Write($"{startNumber}");
            return 1;
        }
        else
        {
            Console.Write($"{startNumber}, ");
            return ReversNumberSequence(startNumber - 1);
        }
    }
}




