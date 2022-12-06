System.Random numberSintezator = new System.Random(); // создадим экземпляр класса рандомайзер

int randomNumber = numberSintezator.Next(10,100); //Получаем новое случайное число

Console.WriteLine(randomNumber);

int firstNumber = randomNumber/10;
int secondNumber = randomNumber%10; //получаем первое и второе число по отдельности      

//сравниваем числа
if (firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
   //выводим данные в консоль
   Console.WriteLine(secondNumber);
}
// //вариант 2
// char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
// Console.WriteLine(digits);

// int firstNumber = ((int)digits[0])-48;
// int secondNumber = ((int)digits[1])-48;

// int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
// Console.WriteLine(resultNumber);




