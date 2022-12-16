// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.?
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(string res, int[] arr)
{
    Console.WriteLine(res);
    PrintArr(arr);
}
int arrLen = ReadData("Введите длину массива.");

int startValue = ReadData("Введите начальное значение");
int endValue = ReadData("Введите конечное значение");
int[] GenArr(int num)
{
    Random rnd = new Random();
    int[] arr = new int[num];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rnd.Next(startValue, endValue);
    }
    return arr;
}

void PrintArr(int[] arr)
{
    Console.Write("[");
    for (int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}


int[] arr = GenArr(arrLen);

PrintData("Сгененрированный массив:",arr);