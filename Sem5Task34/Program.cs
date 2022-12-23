//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// using System.Numerics;
int ReadData(string line)//Просим пользователя задать длину массива.
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    int insertNum = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return insertNum;
}
int[] GenArray(int len, int minValue, int maxValue)// Генерируем массив из случайных чисел с тремя параметрами: Длина,минимальное значение и максимальное значение
{
    Random rnd = new Random();
    int[] array = new int[len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}
//Печатаем массив
void Print1DArr(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1]);
}
int CountOfEven(int[] array) // Производим подсчет количества четных чисел
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}
void PrintData(string msg, int count) // Выводим результат в консоль

{
    Console.WriteLine(msg + count);
}

int len = ReadData("Задайте длину массива:");

int[] array = GenArray(len, 100, 999);
Print1DArr(array);
int count = CountOfEven(array);
PrintData("Количество четных чисел в сгенерированном массиве равно: ", count);

