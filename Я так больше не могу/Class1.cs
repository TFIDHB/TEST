public abstract class Animal
{
    public string Name { get; set; }
    public int Amount { get; set; }
    public string Behavior { get; set; }

    public Animal(string name, int amount, string behavior)
    {
        Name = name;
        Amount = amount;
        Behavior = behavior;
    }

    public virtual void Speak()
    {
        Console.WriteLine($"{Name} издает звук.");
    }
}

public class Predator : Animal
{
    public Predator(string name, int amount, string behavior) : base(name, amount, behavior) { }

    public static string[] PredatorNames = { "Волк", "Лиса", "Медведь" };

    public override void Speak()
    {
        Console.WriteLine($"{Name} рычит.");
    }
}

public class Herbivore : Animal
{
    public Herbivore(string name, int amount, string behavior) : base(name, amount, behavior) { }

    public static string[] HerbivoreNames = { "Олень", "Заяц", "Лось" };
    public override void Speak()
    {
        Console.WriteLine($"{Name} молчит.");
    }
}