using System;
using Microsoft.Win32.SafeHandles;

// 1 абстр
abstract class Figura
{
    public abstract void Risovat(); // 1 абстр
}
// 1 инк насл пол
class Pryamougolnik : Figura // 1 насл
{
    private int x; // 1 инк
    public int X
    {
        get { return x; }
        set { x = value; }
    }
    public override void Risovat() // 1 пол
    {
        Console.WriteLine($"Прямоугольник с X = {X}");
    }
    public void Risovat(string tekst) // 2 пер
    {
        Console.WriteLine($"Рисуем: {tekst}");
    }
    public static Pryamougolnik operator +(Pryamougolnik a, Pryamougolnik b) // 2 пере оп
    {
        return new Pryamougolnik { X = a.X + b.X };
    }
    public static implicit operator int(Pryamougolnik p) // 2 пре
    {
        return p.X;
    }
}
class Programma
{
    static void Main()
    {
        Pryamougolnik pr1 = new Pryamougolnik { X = 5 };
        Pryamougolnik pr2 = new Pryamougolnik { X = 10 };
        Figura fig = pr1; // 1 насл и пол
        fig.Risovat();
        pr1.Risovat("Figura"); // 2 пере мет
        Pryamougolnik summa = pr1 + pr2; // 2 пере оп
        Console.WriteLine($"Сумма X: {summa.X}");
        int znachenie = pr1; // 2 пре
        Console.WriteLine($"pr1 как int: {znachenie}");
        Console.ReadKey();
    }
}
