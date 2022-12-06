//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
double number = double.Parse(Console.ReadLine() ?? "0");
if(number>99)

{
    double number1 = Math.Log10(number);
    double number2 = 1+number1;
    double countdigits = Math.Floor(number2);

    double division = number/(Math.Pow(10,countdigits) - Math.Pow(10,3));
    double result = division%10;
    Console.WriteLine(result);
}
// {
// Char [] digits = number.ToString().ToCharArray(); // превратим число в массив
// Console.WriteLine(digits[2]);
// }
else
{
    Console.WriteLine("Третей цифры нет.");
}