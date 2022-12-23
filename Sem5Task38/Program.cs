// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.




double min = double.MaxValue;
double max = double.MinValue;
int len = ReadData("Задайте длину массива: ");
double[] array = GenArray(len, 1,100/10.0);
Print1DArr(array);

double diff = MinMax(min,max);

PrintData("Разница между маскимальным и минимальным числом массива равна: " + diff);
int ReadData(string line)//Просим пользователя задать длину массива.
{
    Console.Write(line); //Выводим сообщение
    //Считываем число
    int insertNum = int.Parse(Console.ReadLine() ?? "0");
    //Возвращаем значение
    return insertNum;
}
double[] GenArray(int len , double minValue, double maxValue)// Генерируем массив из случайных чисел с тремя параметрами: Длина,минимальное значение и максимальное значение
{
    Random rnd = new  Random();
    double [] array = new double [len];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1,100)/10.0;
    }
    return array;
}


void Print1DArr(double[] array)//Печатаем массив
{
    Console.Write("[");
    for (int i = 0; i < array.Length - 1; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine(array[array.Length - 1] + "]");
}

double MinMax(double min, double max) // Выясняем минимальное и максимальное значение,выводиv разницу.
{
    double diff = 0;
   
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i] ;
        if (array[i] < min) min = array[i] ;
    }
   return diff=max-min;
}

void PrintData(string msg) // Выводим результат в консоль

{
    Console.WriteLine(msg );
}

