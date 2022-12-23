//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
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
void Print1DArr(int[] array)//Печатаем массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}
int SumOfOdd(int[] array)// Задаем метод,который найдет числа на нечетных позициях и сложит их
{
    int sum = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }

    return sum;
}
void PrintData(string msg, int sum) // Выводим результат в консоль

{
    Console.WriteLine(msg + sum);
}

int len = ReadData("Задайте длину массива:");
int minValue = ReadData("Задайте минимальное значение массива:");
int maxValue = ReadData("Задайте максимальное значение массива:");
int[] array = GenArray(len, minValue, maxValue);
Print1DArr(array);
int sum = SumOfOdd(array);
PrintData("Сумма чисел стоящих на нечетных позициях в сгенерированном массиве равна: ", sum);