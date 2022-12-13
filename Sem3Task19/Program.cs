//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом

// Метод вывода данных
void PrintData(bool result)
{
    Console.WriteLine(result);
}

// Метод читает данные от пользователя
int ReadData(string msg)
{
    Console.Write(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

int number = ReadData("Введите пятизначное число: ");
bool result = PalinTest(number);
PrintData(result);
bool PalinTest(int number)
{
    bool result = false;
    result = (number/10000==number%10&&(number/1000)%10==(number/10)%10);

    return result;
}


