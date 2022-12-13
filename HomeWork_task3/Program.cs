/*Задача 29: Напишите программу, которая задаёт массив из 
8 элементов и выводит их на экран.*/

int[] numbers = new int[8];
Random rnd = new Random();

for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = rnd.Next(0, 100);
    Console.Write(numbers[i] + ", ");
}