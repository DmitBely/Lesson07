// Собрать строку с числами от a до b, a <= b

string NumberFor(int a, int b)
{
    string result = String.Empty;
    for (int i = a; i <= b; i++) // если нужно выводить значения
    // от большего к меньшему: i>= b; i--
    {
        result += $"{i} ";
    }
    return result;
}

string NumberRec(int a, int b)
{
    if(a <= b) return $"{a} " + NumberRec(a + 1, b);// если нужно выводить значения
    // от большего к меньшему: NumberRec(a + 1, b) + $"{a}";
    else return String.Empty;
}

Console.Write(NumberFor(1, 10));
Console.WriteLine(String.Empty);
Console.Write(NumberRec(1, 10));