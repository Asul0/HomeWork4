//Задача 25: Напишите программу, 
//реализующую метод,который принимает на вход
//два числа (A и B) и возводит число A в натуральную 
//степень B с использованием цикла.


using static System.Console;
Clear();

Write("Input number1: ");
int number1 = int.Parse(ReadLine());
Write("Input number2: ");
int number2 = int.Parse(ReadLine());

int sum = GetDegree(number2, number1);
WriteLine($"Power of numbers: {sum}");





int GetDegree(int a, int b)
{
    int result = 1;
    for(int i=1; i<=a; i++)
    {
    result *= b;
    }
    return result;
}