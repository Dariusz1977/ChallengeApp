bool Ewa = true;
bool Darek = false;
var womenAge = 33;
var menAge = 17;


if (Darek)
{
    if (menAge < 18)
    {
        Console.WriteLine("Darek jest niepełnoletni.");
    }

    else
    {
        Console.WriteLine("Darek jest pełnoletni i może iść na dyskotekę.");
    }

}
else
{
    if (Ewa)
    {
        if (womenAge > 32)
        {
            Console.WriteLine("Ewa ma więcej niż 33 lata i nie wypada jej iść na dyskotekę :).   ");
        }
        else
        {
            Console.WriteLine("To jest Ewa i jest jeszcze młoda.");
        }




    }


    else
    {
        Console.WriteLine("Proszę wpisać inne imię");
    }

}