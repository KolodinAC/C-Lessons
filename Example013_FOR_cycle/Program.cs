// Цикл for так называемый цикл со встроенным счетчиком как бы объединияет срузу несколько циклов в себе


string Method4(int count, string text)
{
    // int i = 0; первым прописывается в конструкции for - это называется инициализация счетчика
    string result = string.Empty;
    for (int i = 0; i < count; i++)   // while (i < count) далее в фор прописывается условие движения по циклу
    {                                 // i++; третьим в цикле for прописывается инкремент
        result = result + text;   
    }
    return result;
}
string res = Method4(10, "fuck you asshole!");
System.Console.WriteLine(res);
