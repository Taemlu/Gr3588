//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N

string? input1 = Console.ReadLine();

if (input1 != null)
{
    int num1 = int.Parse(input1);

    int even = 2;

    string outResult = string.Empty; //введем переменную, в которую будем накапливать наш результат и обозначим там пока пустоту

    while (even <= num1)
    {
        outResult = outResult + even + ", "; // копим ряд четных чисел
        even = even + 2;
    }

    Console.WriteLine(outResult);

}