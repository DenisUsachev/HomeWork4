/*Задача 27: Напишите программу, которая принимает на вход число и 
выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12*/ 

int GetNumber(string message)
{
    bool isCorrect = false;
    int result = 0;

    while (!isCorrect)
    {
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrect = true;
        }
        else
        {
            Console.WriteLine("Введите число больше 0");
        }
    }
    return result;
}

int GetSumm(int number)
{
    int summ = 0;

    while (number != 0)
    {
        summ += number % 10;
        number /= 10;
    }

    return summ;
}

int number = GetNumber("Введите число больше 0");
int summ = GetSumm(number);

Console.WriteLine($"Сумма чисел {number} = {summ}");