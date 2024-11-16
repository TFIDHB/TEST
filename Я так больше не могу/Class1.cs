using System;
using System.Collections.Generic;

namespace Я_так_больше_не_могу
{
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

        public virtual void Speak(List<Animal> animals)
        {

            if (Behavior == "охотится")
            {
                Console.WriteLine($"{Name} рычит.");
            }

            else if (Behavior == "ест")
            {
                Console.WriteLine($"{Name} ест.");
            }
            else
            {
                Console.WriteLine($"{Name} издает звук.");
            }
        }
    }

    public class Predator : Animal
    {
        public Predator(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] PredatorNames = { "Волк", "Лиса", "Медведь" };

        public override void Speak(List<Animal> animals)
        {
            base.Speak(animals);
            if (Behavior == "охотится")
            {
                foreach (var animal in animals)
                {
                    if (animal is Herbivore && animal.Amount > 0 && Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int hunted = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= hunted;
                        Amount += hunted;

                        Console.WriteLine($"{Name} охотится на {animal.Name}. Количество {animal.Name}: {animal.Amount}");

                        if (animal.Amount > 0)
                        {
                            string prevBehv = animal.Behavior;
                            animal.Behavior = "убегает";
                            animal.Speak(animals);

                            animal.Behavior = prevBehv;
                            Console.WriteLine($"{animal.Name} возвращается к поведению {animal.Behavior}.");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine($"Поведение {Behavior} невозможно в данном контексте");
            }
        }
    }

    public class Herbivore : Animal
    {
        public Herbivore(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] HerbivoreNames = { "Олень", "Заяц", "Лось" };

        public override void Speak(List<Animal> animals)
        {
            if (Behavior == "питается")
            {
                foreach (var animal in animals)
                {
                    if (animal is Plant && animal.Amount > 0 && Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int eaten = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= eaten;
                        Amount += eaten;

                        Console.WriteLine($"{Name} питается {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                    }
                }
            }
            else if (Behavior == "убегает")
            {
                int remaining = new Random().Next(1, Amount + 1);
                int escaped = Amount - remaining;
                Amount = remaining;
                Console.WriteLine($"{Name} убегает. Количество убежавших: {escaped}, оставшееся количество: {Amount}");
            }
            else
            {
                Console.WriteLine($"Поведение {Behavior} невозможно в данном контексте");
            }
        }
    }

    public class Plant : Animal
    {
        public Plant(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] PlantNames = { "Берёза", "Ромашка", "Трава" };

        public override void Speak(List<Animal> animals)
        {
            Console.WriteLine($"{Name} бездействует");
        }
    }

    public class Insect : Animal
    {
        public Insect(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] InsectNames = { "Пчела", "Клещ", "Муравей" };

        public override void Speak(List<Animal> animals)
        {
            if (Behavior == "паразитирует" && Name == "Клещ")
            {
                foreach (var animal in animals)
                {
                    if (animal is Herbivore && animal.Amount > 0 )
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int parasitized = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= parasitized;
                        Amount += parasitized;

                        Console.WriteLine($"{Name} паразитирует на {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                    }
                }
            }
            else if (Behavior == "питается" && Name != "Клещ")
            {
                foreach (var animal in animals)
                {
                    if (animal is Plant && animal.Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int pollinated = Math.Min(preyAmount, animal.Amount);

                        animal.Amount += pollinated;
                        Amount += pollinated;

                        Console.WriteLine($"{Name} питается/опыляет {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                    }
                }
            }
            else
            {
                Console.WriteLine($"Поведение {Behavior} невозможно в данном контексте");
            }
        }

    }
}
