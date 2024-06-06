using System;

class Trapeze
{
    // Поля
    private int _a; // Довжина першої основи
    private int _b; // Довжина другої основи
    private int _h; // Висота
    private readonly int _c; // Колір (припустимо, що це просто ціле число для представлення кольору)

    // Конструктор
    public Trapeze(int a, int b, int h, int c)
    {
        _a = a;
        _b = b;
        _h = h;
        _c = c;
    }

    // Властивості для отримання і встановлення довжин
    public int A
    {
        get { return _a; }
        set { _a = value; }
    }

    public int B
    {
        get { return _b; }
        set { _b = value; }
    }

    public int H
    {
        get { return _h; }
        set { _h = value; }
    }

    // Властивість для отримання кольору
    public int C
    {
        get { return _c; }
    }

    // Метод для виведення довжин на екран
    public void DisplayDimensions()
    {
        Console.WriteLine($"Основи: {_a}, {_b}; Висота: {_h}; Колір: {_c}");
    }

    // Метод для розрахунку периметра трапеції
    public double CalculatePerimeter()
    {
        // Для обчислення периметра необхідно знати довжини бічних сторін. 
        // Використовуємо теорему Піфагора для обчислення довжин бічних сторін, вважаючи їх рівними
        double sideLength = Math.Sqrt(Math.Pow((Math.Abs(_a - _b) / 2.0), 2) + Math.Pow(_h, 2));
        return _a + _b + 2 * sideLength;
    }

    // Метод для розрахунку площі трапеції
    public double CalculateArea()
    {
        return ((_a + _b) / 2.0) * _h;
    }

    // Властивість для визначення, чи є трапеція квадратом
    public bool IsSquare
    {
        get
        {
            return _a == _b && _h == _a;
        }
    }
}

class Program
{
    static void Main()
    {
        // Створення масиву трапецій
        Trapeze[] trapezes = new Trapeze[]
        {
            new Trapeze(4, 4, 4, 1),
            new Trapeze(5, 6, 7, 2),
            new Trapeze(8, 8, 8, 3),
            new Trapeze(3, 3, 3, 4)
        };

        // Виведення інформації про трапеції
        int squareCount = 0;
        foreach (var trapeze in trapezes)
        {
            trapeze.DisplayDimensions();
            Console.WriteLine($"Площа: {trapeze.CalculateArea()}");
            Console.WriteLine($"Периметр: {trapeze.CalculatePerimeter()}");
            if (trapeze.IsSquare)
            {
                Console.WriteLine("Ця трапеція є квадратом.");
                squareCount++;
            }
            else
            {
                Console.WriteLine("Ця трапеція не є квадратом.");
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Кількість квадратів: {squareCount}");
    }
}
