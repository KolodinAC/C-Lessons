// Имеется одномерный массив array из n элементов. 
// Требуется найти элемент массива, равный find.
// 1. установить счетчик индекса на 0
// 2. если array[index] == find, алгоритм завершает работу успешно.
// 3. увеличить index на 1
// 4. если index < n, то перейти к шагу 2. В противном случае алгоритм завершит работу безуспешно. 


int[] array = {11, 98, 43, 64, 98, 68, 17, 98};

int n = array.Length;
int find = 98;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}