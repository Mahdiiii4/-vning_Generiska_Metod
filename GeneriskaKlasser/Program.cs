using System;

float val1 = 2.345f;
float val2 = 2.346f;

T Min<T>(T val1, T val2) where T: IComparable<T>
{
    int resultat = val1.CompareTo(val2);
    if(resultat < 0)
    {
        return val1;
    }
    else if (resultat > 0)
    {
        return val2;
    }
    else
    {
        return val1;
    }
}

Console.WriteLine(Min(val1, val2));