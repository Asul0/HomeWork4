// Задача 27: Напишите программу, реализующую метод, 
//который принимает на вход число и выдаёт сумму цифр в числе.

using static System.Console;
Clear();

Write("Input number: ");
int number = int.Parse(ReadLine());

int sum = GetDegree(number);
WriteLine($"Сумма цифр в числе: {sum}");





int GetDegree(int a)
{
    int result = 0;
    while (a > 0)
    {
    result = result + a % 10;
    a = a /10 ;
    }
    return result;
}