// Двумерные масствы: 

// string[,] table = new string[2, 3];             
// string - тип данных массива
// [,] - обозначение что массив двумерный - запятая показыват что есть строки и столбцы в массиве
// table - просто название

// int[,] matrix = new int[5, 8]; - Еще пример - массив из целых чисел с 5 строками и 8 столбцами


string[,] table = new string[5, 2];
// String.Empty                             инициализация пустой строки через константу Empty
// table[0, 0]  table[0, 1] table[0, 2]     индексы позиций в массиве
// table[1, 0]  table[1, 1] table[1, 2]
// table[2, 0]  table[2, 1] table[2, 2]
// table[3, 0]  table[3, 1] table[3, 2]
// table[4, 0]  table[4, 1] table[4, 2]

table[2, 1] = "word";

// for (int rows = 0;  rows < 5; rows++)
// {
//     for (int columns = 0; columns < 2; columns++)
//     {
//         Console.WriteLine($"-{table[rows, columns]}-");
//     }
// } 


void PrintTwoDimArray(int[,] matr)           // создадим удобный метод печати прямоугольных матриц чисел
{
    for (int i = 0; i < matr.GetLength(0); i++)           // matrix.GetLength(0) - обращаемя к массиву и хотим получить первый аргумент вписав 0. для унификации метода чтоб не вписывать вручную колво строк
    {
        for (int j = 0; j < matr.GetLength(1); j++)      // matrix.GetLength(0) - обращаемя к массиву и хотим получить первый аргумент вписав 1. для унификации метода чтоб не вписывать вручную колво столбцов
        {
            System.Console.Write($"{matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillTwoDimArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)           
    {
        for (int j = 0; j < matr.GetLength(1); j++)      
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}


int[,] matrix = new int[3, 4];
PrintTwoDimArray(matrix);                  // матрица чисел или прямоугольная
FillTwoDimArray(matrix);
Console.WriteLine();
PrintTwoDimArray(matrix);