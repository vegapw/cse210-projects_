using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction f1 = new Fraction();
        Fraction f2 = new Fraction(1);
        Fraction f3 = new Fraction(5);
        Fraction f4 = new Fraction(3, 4);
        Fraction f5 = new Fraction(1, 3);

        Console.WriteLine($"F1 top: {f1.GetTop()} bottom: {f1.GetBottom()}");
        Console.WriteLine($"F2 top: {f2.GetTop()} bottom: {f2.GetBottom()}");
        Console.WriteLine($"F3 top: {f3.GetTop()} bottom: {f3.GetBottom()}");
        Console.WriteLine($"F4 top: {f4.GetTop()} bottom: {f4.GetBottom()}");
        Console.WriteLine($"F5 top: {f5.GetTop()} bottom: {f5.GetBottom()}");

        Console.WriteLine($"F1 String Fraction: {f1.GetFractionString()}");
        Console.WriteLine($"F1 Decimal Value: {f1.GetDecimalValue()}");
        Console.WriteLine($"F2 String Fraction: {f2.GetFractionString()}");
        Console.WriteLine($"F2 Decimal Value: {f2.GetDecimalValue()}");
        Console.WriteLine($"F3 String Fraction: {f3.GetFractionString()}");
        Console.WriteLine($"F3 Decimal Value: {f3.GetDecimalValue()}");
        Console.WriteLine($"F4 String Fraction: {f4.GetFractionString()}");
        Console.WriteLine($"F4 Decimal Value: {f4.GetDecimalValue()}");
        Console.WriteLine($"F5 String Fraction: {f5.GetFractionString()}");
        Console.WriteLine($"F5 Decimal Value: {f5.GetDecimalValue()}");

    }
}