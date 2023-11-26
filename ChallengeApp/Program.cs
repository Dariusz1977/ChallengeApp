bool Ewa = true;
bool Darek = false;
bool women = true;
bool men = false;
var womenAge = 32;
var menAge = 17;


if (Darek && men)
{
    if (menAge < 18)
    {
        Console.WriteLine("Mężczyzna jest niepełnoletni.");
    }

    else
    {
        Console.WriteLine("Darek jest pełnoletni.");
    }

}
else
{
    if (Ewa && women)
    {
        if (womenAge > 32)
        {
            Console.WriteLine("Ewa, lat 33.");
        }
        else
        {
            Console.WriteLine("Kobieta poniżej 30 lat.");
        }




    }


    else
    {
        Console.WriteLine("Podaj imię i płeć");
    }

}