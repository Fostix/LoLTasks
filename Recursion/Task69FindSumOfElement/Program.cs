// Найти сумму элементов от M до N, N и M заданы.

int Rec(int start, int finish)
{
    if(start > finish)
    {
        return start + Rec(finish, start - 1);
    }
    if (start == finish)
    {
        return finish;
    }
    return start + Rec(finish, start + 1);
}

Console.Write(Rec(5, 1));