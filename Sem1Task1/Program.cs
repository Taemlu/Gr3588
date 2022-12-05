string? num1Line = Console.ReadLine();
string? num2Line = Console.ReadLine();

if(num1Line!=null&&num2Line!=null)  //проверили, что числа не нулевые, что есть значение
{
    int num1 = int.Parse(num1Line); // оператор Parse превращает наше число из строки в десятичное
    int num2 = int.Parse(num2Line);

    bool outResult = num1 == num2*num2; // проверяем является ли первое число квадратом второго
    Console.WriteLine(outResult);
}