//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 

int row = ReadData("Введите количество строк");
int column = ReadData("Введите количество столбцов");
int page = ReadData("Введите количество страниц");

List<int> num=new List<int>();
for(int i=0;i<99;i++)
{
    num.Add(10+i);
}

int[,,] arr3D = Fill3DArray(row, column, page, num);
Print3DArray(arr3D);

int GenNum(List<int>num)
{
    int index=new Random().Next(0,num.Count);
    int outNum=num[index];
    num.RemoveAt(index);
    return outNum;
}
// Метод вывода данных
int ReadData(string line)
{
    Console.Write(line);
    int number = int.Parse(Console.ReadLine() ?? "0");
    return number;
}
//Универсальный метод генерации и заполнения двумерного массива
int[,,] Fill3DArray(int countRow, int countColumn, int countPage,  List<int> num)
{
    int[,,] array3D = new int[countRow, countColumn, countPage];

    for (int i = 0; i < countRow; i++)
    {
        for (int j = 0; j < countColumn; j++)
        {
            for (int k = 0; k < countPage; k++)
            {
                array3D[i, j, k] = GenNum(num);
            }
        }
    }
    return array3D;
}
//печать трехмерного массива
 void Print3DArray(int[,,] array3D)
 {
     for (int i = 0; i < array3D.GetLength(0); i++)
     {
         for (int j = 0; j < array3D.GetLength(1); j++)
         {
             for (int k = 0; k < array3D.GetLength(2); k++)
             {
                Console.Write($"{array3D[i,j,k]}({i},{j},{k}) ");
             }
         }
         Console.WriteLine();
     }
     Console.WriteLine();
 }