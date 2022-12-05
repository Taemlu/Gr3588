//Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string? input1 = Console.ReadLine(); //введем значения переменных типа "строка"
string? input2 = Console.ReadLine();
 

if(input1!=null&&input2!=null) //проверим, что значения не пустые

{
    int num1 = int.Parse(input1); // оператор Parse превращает наше число из строки в десятичное
    int num2 = int.Parse(input2);

    if(num1>num2)
    {
    Console.WriteLine(num1 + " больше чем "+ num2);
    }
    else
    
        if(num1==num2)
        {
        Console.WriteLine(num2 + " равно "+ num1);
        }
    

    else
    
        if(num1<num2)
        {
        Console.WriteLine(num2 + " больше чем "+ num1);
        }
}
