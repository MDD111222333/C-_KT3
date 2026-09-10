using System;

public class Money
{
    public decimal Amount { get; set; }

    public Money(decimal amount)
    {
        Amount = amount;
    }

    public static Money operator +(Money a, Money b)
    {
        return new Money(a.Amount + b.Amount);
    }

    public static Money operator -(Money a, Money b)
    {
        return new Money(a.Amount - b.Amount);
    }

    public static Money operator -(Money a)
    {
        return new Money(-a.Amount);
    }

    public override string ToString()
    {
        return $"{Amount} руб.";
    }
}

class Program
{
    static void Main()
    {
        Money m1 = new Money(125.50m);
        Money m2 = new Money(50m);

        Console.WriteLine("Сумма 1: " + m1);
        Console.WriteLine("Сумма 2: " + m2);

        Money sum = m1 + m2;
        Console.WriteLine("Сложение: " + sum);

        Money diff = m1 - m2;
        Console.WriteLine("Вычитание: " + diff);

        Money debt = m2 - m1;
        Console.WriteLine("Долг: " + debt);

        Money neg = -m1;
        Console.WriteLine("Унарный минус: " + neg);
    }
}