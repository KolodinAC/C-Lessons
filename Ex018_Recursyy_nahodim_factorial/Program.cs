// Создадим алгоритм нахождения факториала (произведение чисел от 1 до заданного числа факториала ex: 5!=5*4*3*2*1):

double Factorial(double n)
{
    // 1! = 1    факториал от единицы равен единице
    // 0! = 1    факториал от нуля равен единице
    if (n == 1) return 1;
    else return (n * Factorial(n - 1));
}

for(int i = 1; i < 40; i++)                // через цикл организовали пошаговый вывод расчета факториала
{
    Console.WriteLine($"{i}! = {Factorial(i)}");
}
