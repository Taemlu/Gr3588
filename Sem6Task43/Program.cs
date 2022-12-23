// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.


double b1 = ReadData("Введите число b1:");
double k1 = ReadData("Введите число k1:");
double b2 = ReadData("Введите число b2:");
double k2 = ReadData("Введите число k2:");
    

(double x,double y) point = IntersectionPoint(b1, k1, b2, k2);          // Находим пересечение между точками
        
PrintData("Пересечение прямых происходит в точке с координатами: " , point);

   
//Метод, считывающий данные, введенные пользователем
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData (string msg, (double,double) point) // Выводим результат в консоль

{
    Console.WriteLine(msg + point);
}

// Метод находит точку пересечения двух прямых
(double, double) IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = ((double)b2 - (double)b1) / ((double)k1 - (double)k2);
    double y = (double)k1 * x + (double)b1;
    return (x, y);
}

