// See https://aka.ms/new-console-template for more information

uint number1 = 0;
uint number2 = 1;

for (int i = 0; i < 4; i++)
{
    uint fibonachhi = number1 + number2;
    Console.WriteLine(fibonachhi);
    number2 = fibonachhi;
    fibonachhi += fibonachhi;
    number1 = fibonachhi;
    Console.WriteLine(fibonachhi);
}
Console.ReadLine();

