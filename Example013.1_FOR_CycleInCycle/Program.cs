// Цикл for может использоваться в конструкции - цикл в цикле.


// string Method4(int count, string text)
// {
//     // int i = 0; первым прописывается в конструкции for - это нахывается инициализация счетчика
//     string result = string.Empty;
//     for (int i = 0; i < count; i++)   // while (i < count) далее в фор прописывается условие движения по циклу
//     {
//         result = result + text;   // i++; третьим в цикле for прописывается инкремент
//     }
//     return result;
// }
// string res = Method4(10, "fuck you asshole!");
// System.Console.WriteLine(res);

// Создадим с помощью цикла в цикле вывод таблицы умножения

for (int i = 2; i <= 10; i++) // начинаем с таблицы на 2, это первый или внешний цикл
{
    for (int j = 1; j <= 10; j++) // это второй или внутренний или вложенный цикл
    {
        System.Console.WriteLine($"{i} x {j} = {i*j}");
    }
    System.Console.WriteLine();
}