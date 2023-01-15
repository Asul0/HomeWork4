// Задача 29: Напишите программу, реализующую метод, который
//формирует массив случайных целых чисел из 8 элементов и 
//выводит их на экран.1,2,5,7,19,6,1,33 -> [1,2,5,7,19,6,1,33 ]


using static System.Console;
Clear();



int[] sum = InitBinaryArray();
PrintArray(sum);



int[] InitBinaryArray()
{
    int[] res = new int[8];

    for (int i = 0; i < res.Length; i++)
    {
        res[i] = new Random().Next(100);
    }
    return res;
}

void PrintArray(int[] arr)
{
    Write("[");
    for (int i = 0; i < 7; i++)
    {
        Write($"{arr[i]},");
    }
    for (int i = 0; i < 1; i++)     //данный цикл, чтобы последний массив был без ","  
    {
        Write($"{arr[7]}");
    }
    Write("]");
}
