// See https://aka.ms/new-console-template for more information

static string GetFullName(string firstName, string lastName, string patronymic)
{
    string fioName = lastName + " " + firstName + " " + patronymic;
    Console.WriteLine(fioName);
    return fioName;
}


{
    int count = 0;
    while(count != 4)
    {
        Console.WriteLine("Введите Имя пользователя");

        string firstName1 = Console.ReadLine();

        Console.WriteLine("Введите Фамилию пользователя");

        string lastName1 = Console.ReadLine();

        Console.WriteLine("Введите Отчество пользователя");

        string patronymic1 = Console.ReadLine();

        GetFullName(firstName1, lastName1, patronymic1);
        count++;

    }
    Console.ReadLine();


}

