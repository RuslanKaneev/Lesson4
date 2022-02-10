// See https://aka.ms/new-console-template for more information

Console.WriteLine("Введите номер месяца");
int nomerMonth = Convert.ToInt32(Console.ReadLine());

if (nomerMonth > 0 && nomerMonth < 13)
{
    Season seasonOfTheYear = VremenaGoda(nomerMonth);
    string russianSeasonOfTheYear = RussianVremenaGoda(seasonOfTheYear);
    Console.WriteLine(russianSeasonOfTheYear);
}
else
{
    Console.WriteLine("Ошибка: введите число от 1 до 12");
}

Console.ReadLine();

static Season VremenaGoda (int nomerMonth)
{ 
    switch (nomerMonth)
    {
        case 1:
        case 2:
        case 12:
            return Season.Winter;

        case 3:
        case 4:
        case 5:
            return Season.Spring;
            
        case 6:
        case 7:
        case 8:
            return Season.Summer;
           
        default:
            return Season.Autumn;
            
    }
}

static string RussianVremenaGoda(Season seasonOfTheYear)
{ 
 
    switch (seasonOfTheYear)
    {
        case Season.Winter:
            return "Зима";

        case Season.Spring:
            return "Весна";

        case Season.Summer:
            return "Лето";

        case Season.Autumn:
            return "Осень";
           
        default: 
            break;
    }
    return "Ошибка";
}
public enum Season
{
    Spring,
    Summer,
    Autumn,
    Winter,
}




