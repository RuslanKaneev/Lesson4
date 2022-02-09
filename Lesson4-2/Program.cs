

static int SummaChislvTexte (string strokaChisla)
{ 
    string sumChislaText = null;
    int sumChislo = 0;
    for (int i = 0; i < strokaChisla.Length; i++)
    {

    if (strokaChisla[i] == ' ')
        {
        sumChislo += Convert.ToInt32(sumChislaText);
        sumChislaText = null;
    }
    
    else
    {
        sumChislaText += strokaChisla[i];  

    }
    if(i == strokaChisla.Length - 1)
    {
        sumChislo += Convert.ToInt32(sumChislaText);
    }
        
    }
return sumChislo;
    
}
Console.WriteLine("Введите числа с пробелами");
int itog = SummaChislvTexte(Console.ReadLine());
Console.WriteLine(itog);
Console.ReadLine();



