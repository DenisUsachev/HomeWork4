/*Напишите цикл, который принимает на вход два числа (A и B) и 
возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16*/

int GetNumber(string message)
{
    bool isCorrent = false;
    int result = 0; 
    

    while (!isCorrent)
    {
        if(int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            isCorrent = true;
        }
        else
        {
            Console.WriteLine("Введите число больше 0");
        }
    }
    return result;
}

int GetDegree(int firstnum, int secondnum)
{
    int degree = 1;

    int index = secondnum;
    while (index > 0)
    {
        degree *= firstnum;
        index -= 1;
    }
    return degree;
}

int firstnum = GetNumber("Введите первое число");
int secondnum = GetNumber("Введите второе число");
int degree = GetDegree(firstnum,secondnum);

Console.WriteLine($"Степень числа {firstnum} и числа {secondnum} равна {degree}");