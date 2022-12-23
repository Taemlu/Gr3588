//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int[] genArray = ReadData("Введите числa через запятую: " ); //вводим массив чисел введенных пользователем
int result = CountPosNum(genArray);
PrintData ("Количество чисел больше нуля равно:  ", result) ;


int[] ReadData(string line)  //Метод для ввода пользователем ряда чисел в виде массива
{
    Console.Write(line); 
    int [] genArray = Array.ConvertAll(Console.ReadLine().Split( "," ),int.Parse);
    return genArray;
    
    
}
void PrintData(string msg, int res) // Метод вывода результата в консоль
{
    Console.WriteLine(msg + res);
}
int CountPosNum( int[] array) //Считаем количество чисел выше нуля
{
    int res=0;
    for(int i = 0; i < array.Length; i++)
    {
        if (array[i] >0) res++; // проверяем каждый элемент массива, больше ли он нуля и приплюсовываем к результату
        
    }
     
    return res;
}