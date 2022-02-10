// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите номер числа Фибоначчи");
int number = Convert.ToInt32(Console.ReadLine());

static int Fibonachhi(int number)
{
    if (number == 0 || number == 1)
    {
        return number;
    }
    return Fibonachhi(number-1) + Fibonachhi(number - 2);
}
Console.WriteLine(Fibonachhi(number));
