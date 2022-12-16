// //Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
int ReadData(string msg)
{
    Console.WriteLine(msg);
    return int.Parse(Console.ReadLine() ?? "0");
}

void PrintData(int res)
{
    Console.WriteLine(res);
}


int Pow(int numA, int numB)
{
  int res = 1;
  for(int i=1; i <= numB; i++)
  {
    res = res * numA;
  }
    // int result = Math.Pow(numberA, numberB);
    return res;
}

int num1 = ReadData("Введите число А:");
int num2 = ReadData("Введите число B:");

int result = Pow(num1, num2);
PrintData(result);