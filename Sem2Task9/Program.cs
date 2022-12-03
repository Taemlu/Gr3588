// System.Random numberSintezator = new System.Random(); // создадим экземпляр класса рандомайзер

// int number = numberSintezator.Next(10,100); //Получаем новое случайное число

// Console.WriteLine(number);

// int firstNumber = number/10;
// int secondNumber = number%10; //получаем первое и второе число по отдельности      

// //сравниваем числа
// if (firstNumber>secondNumber)
// {
//     Console.WriteLine(firstNumber);
// }
// else
// {
//    //выводим данные в консоль
//    Console.WriteLine(secondNumber);
// }
//вариант 2
char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resultNumber = firstNumber>secondNumber?resultNumber=firstNumber:resultNumber=secondNumber;
Console.WriteLine(resultNumber);




