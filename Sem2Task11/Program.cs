//создаем экземпляр класса рандомайзер
System.Random numberSintezator = new System.Random();

//получаем новое слуйчаное число
int num = numberSintezator.Next(100,1000);

Console.WriteLine(num);

// int number1 = num/100; //получаем старший разряд числа
// int number2 = num%10; //получаем младщий разряд числа

//int result = (num/100)*10 + num%10; //ввели сразу выражения вместо number1,2
Console.WriteLine((num/100)*10 + num%10); //записали сразу выражение в результат
