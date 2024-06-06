using System;

// Базовий клас
class Test
{
    public string Subject { get; set; }
    public DateTime Date { get; set; }

    public Test(string subject, DateTime date)
    {
        Subject = subject;
        Date = date;
    }

    public virtual void Show()
    {
        Console.WriteLine($"Предмет: {Subject}, Дата: {Date.ToShortDateString()}");
    }
}

// Похідний клас Exam
class Exam : Test
{
    public int Duration { get; set; } // Тривалість іспиту в хвилинах

    public Exam(string subject, DateTime date, int duration) 
        : base(subject, date)
    {
        Duration = duration;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Тривалість: {Duration} хвилин");
    }
}

// Похідний клас FinalExam
class FinalExam : Exam
{
    public string GraduationYear { get; set; }

    public FinalExam(string subject, DateTime date, int duration, string graduationYear) 
        : base(subject, date, duration)
    {
        GraduationYear = graduationYear;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Рік випуску: {GraduationYear}");
    }
}

// Похідний клас Trial
class Trial : Test
{
    public string Location { get; set; } // Місце проведення випробування

    public Trial(string subject, DateTime date, string location) 
        : base(subject, date)
    {
        Location = location;
    }

    public override void Show()
    {
        base.Show();
        Console.WriteLine($"Місце проведення: {Location}");
    }
}

class Program
{
    static void Main()
    {
        // Масив базового класу
        Test[] tests = new Test[]
        {
            new Test("Математика", new DateTime(2024, 6, 1)),
            new Exam("Фізика", new DateTime(2024, 6, 10), 120),
            new FinalExam("Хімія", new DateTime(2024, 6, 15), 180, "2024"),
            new Trial("Біологія", new DateTime(2024, 6, 20), "Лабораторія 1")
        };

        // Виведення інформації про всі об'єкти
        foreach (var test in tests)
        {
            test.Show();
            Console.WriteLine();
        }
    }
}
