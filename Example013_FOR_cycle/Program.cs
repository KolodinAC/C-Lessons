// Цикл for так называемы цикл со встроенным счетчиком как бы объединияет сруз несколько циклов в себе


string Method4(int count, string text)
{
    // int i = 0; первым прописывается в конструкции for - это нахывается инициализация счетчика
    string result = string.Empty;
    for (int i = 0; i < count; i++)   // while (i < count) далее в фор прописывается условие движения по циклу
    {
        result = result + text;   // i++; третьим в цикле for прописывается инкремент
    }
    return result;
}
string res = Method4(10, "fuck you asshole!");
System.Console.WriteLine(res);
