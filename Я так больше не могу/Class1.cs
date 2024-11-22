using System;
using System.Collections.Generic;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Я_так_больше_не_могу
{
    public abstract class World
    {
        public string Name { get; set; }
        public int Amount { get; set; }
        public string Behavior { get; set; }

        public World(string name, int amount, string behavior)
        {
            Name = name;
            Amount = amount;
            Behavior = behavior;
        }

        public virtual void Speak(List<World> animals)
        {
            if (Behavior == "бездействует")
            {
                Random random = new Random();
                int change = random.Next(-2, 3);
                Amount = Math.Max(0, Amount + change);
                string action = change > 0 ? "увеличилось" : "уменьшилось";
                Console.WriteLine($"Количество {Name} {action} на {Math.Abs(change)}. Текущее количество: {Amount}");
            }
            else
            {
                Console.WriteLine($"{Name} издает звук.");
            }
        }

        public static void CheckEcosystem(List<World> animals)
        {
            int predators = animals.Count(a => a is Predator && a.Amount > 0);
            int herbivores = animals.Count(a => a is Herbivore && a.Amount > 0);
            int plants = animals.Count(a => a is Plant && a.Amount > 0);
            int insects = animals.Count(a => a is Insect && a.Amount > 0);

            bool ecosystemInBalance = true;

            if (herbivores == 0 && predators > 0)
            {
                Console.WriteLine("ЭКОСИСТЕМА НАРУШЕНА: Хищники уничтожили всех травоядных.");
                ecosystemInBalance = false;
            }
            if (herbivores > 0 && plants == 0)
            {
                Console.WriteLine("ЭКОСИСТЕМА НАРУШЕНА: Травоядные уничтожили всю растительность.");
                ecosystemInBalance = false;
            }
            if (plants == 0 && insects > 0)
            {
                Console.WriteLine("ЭКОСИСТЕМА НАРУШЕНА: Насекомые уничтожили всю растительность.");
                ecosystemInBalance = false;
            }
            if (predators == 0 && herbivores > 0)
            {
                Console.WriteLine("ЭКОСИСТЕМА НАРУШЕНА: Травоядные не регулируются хищниками, что может привести к перенаселению.");
                ecosystemInBalance = false;
            }

            if (ecosystemInBalance)
            {
                Console.WriteLine("ЭКОСИСТЕМА В НОРМЕ: Все группы животных и растений сбалансированы.");
            }

            if (!ecosystemInBalance)
            {
                if (herbivores == 0 && predators > 0)
                {
                    Console.WriteLine("Последствие: Хищники начнут голодать и уменьшаться в количестве.");
                }
                if (herbivores > 0 && plants == 0)
                {
                    Console.WriteLine("Последствие: Травоядные начнут голодать и уменьшаться в количестве.");
                }
                if (plants == 0 && insects > 0)
                {
                    Console.WriteLine("Последствие: Насекомые начнут голодать и уменьшаться в количестве.");
                }
                if (predators == 0 && herbivores > 0)
                {
                    Console.WriteLine("Последствие: Перенаселение травоядных приведет к дефициту пищи и уменьшению их количества.");
                }
            }
        }
    }



    public class Predator : World
    {
        public Predator(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] PredatorNames1 = { "Волк", "Лиса", "Медведь" };
        public static string[] PredatorNames2 = { "Лиса", "Ястреб", "Хорёк" };
        public static string[] PredatorNames3 = { "Змея", "Жаба", "Выдра" };

        public override void Speak(List<World> animals)
        {
            if (Behavior == "охотится" && Name != "Медведь" && Name != "Жаба")
            {
                foreach (var animal in animals)
                {
                    if (animal is Herbivore && animal.Amount > 0 && Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int hunted = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= hunted;
                        int increase = new Random().Next(1, hunted + 1);
                        Amount += increase;

                        Console.WriteLine($"{Name} охотится на {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                        Console.WriteLine($"Популяция {Name} увеличилась на {increase}. Текущее количество: {Amount}");

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
            else if (Behavior == "охотится" && Name == "Жаба")
            {
                foreach (var animal in animals)
                {
                    if (animal is Insect && animal.Amount > 0 && Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int hunted = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= hunted;
                        int increase = new Random().Next(1, hunted + 1);
                        Amount += increase;

                        Console.WriteLine($"{Name} охотится на {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                        Console.WriteLine($"Популяция {Name} увеличилась на {increase}. Текущее количество: {Amount}");

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
            else if (Behavior == "питается")
            {
                foreach (var animal in animals)
                {
                    if ((animal is Plant || animal is Insect) && animal.Amount > 0 && Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int eaten = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= eaten;
                        int increase = new Random().Next(1, eaten + 1);
                        Amount += increase;

                        Console.WriteLine($"{Name} питается {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                        Console.WriteLine($"Популяция {Name} увеличилась на {increase}. Текущее количество: {Amount}");
                    }
                }
            }
            else if (Behavior == "бездействует")
            {
                base.Speak(animals);
            }
            else
            {
                Console.WriteLine($"Поведение {Behavior} невозможно в данном контексте");
            }
        }
    }


    public class Herbivore : World
    {
        public Herbivore(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] HerbivoreNames1 = { "Олень", "Заяц", "Лось" };
        public static string[] HerbivoreNames2 = { "Белка", "Кролик", "Мышь" };
        public static string[] HerbivoreNames3 = { "Ондатра", "Мышь", "Бобр" };

        public override void Speak(List<World> animals)
        {
            if (Behavior == "питается")
            {
                foreach (var animal in animals)
                {
                    if ((animal is Plant || animal is Insect) && animal.Amount > 0 && Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int eaten = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= eaten;
                        int increase = new Random().Next(1, eaten + 1);
                        Amount += increase;

                        Console.WriteLine($"{Name} питается {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                        Console.WriteLine($"Популяция {Name} увеличилась на {increase}. Текущее количество: {Amount}");
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

            else if (Behavior == "бездействует")
            {
                base.Speak(animals);
            }
            else
            {
                Console.WriteLine($"Поведение {Behavior} невозможно в данном контексте");
            }
        }
    }


    public class Plant : World
    {
        public Plant(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] PlantNames1 = { "Берёза", "Ромашка", "Трава" };
        public static string[] PlantNames2 = { "Клевер", "Ромашка", "Мак" };
        public static string[] PlantNames3 = { "Кувшинка", "Мох", "Камыш" };

        public override void Speak(List<World> animals)
        {
            base.Speak(animals);
        }
    }

    public class Insect : World
    {
        public Insect(string name, int amount, string behavior) : base(name, amount, behavior) { }

        public static string[] InsectNames1 = { "Пчела", "Клещ", "Муравей" };
        public static string[] InsectNames2 = { "Пчела", "Бабочка", "Кузнечик" };
        public static string[] InsectNames3 = { "Комар", "Жук", "Стрекоза" };

        public override void Speak(List<World> animals)
        {
            if (Behavior == "питается" && (Name == "Клещ" || Name == "Комар") && Amount > 0)
            {
                Random rnd = new Random();
                bool parasiteOnPredator = rnd.Next(0, 2) == 0;

                foreach (var animal in animals)
                {
                    if ((animal is Herbivore || (animal is Predator && parasiteOnPredator)) && animal.Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int parasitized = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= parasitized;
                        int increase = new Random().Next(1, parasitized + 1);
                        Amount += increase;

                        Console.WriteLine($"{Name} паразитирует на {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                        Console.WriteLine($"Популяция {Name} увеличилась на {increase}. Текущее количество: {Amount}");
                    }
                }
            }
            else if (Behavior == "питается" && Name != "Клещ" && Name != "Муравей" && Amount > 0)
            {
                foreach (var animal in animals)
                {
                    if (animal is Plant && animal.Amount > 0)
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int pollinated = Math.Min(preyAmount, animal.Amount);

                        animal.Amount += pollinated;
                        int increase = new Random().Next(1, pollinated + 1);
                        Amount += increase;

                        Console.WriteLine($"{Name} питается/опыляет {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                        Console.WriteLine($"Популяция {Name} увеличилась на {increase}. Текущее количество: {Amount}");
                    }
                }
            }
            else if (Behavior == "питается" && Name == "Муравей" && Amount > 0)
            {
                foreach (var animal in animals)
                {
                    if (animal is World && animal.Amount <= 0)
                    {
                        Console.WriteLine($"{Name} разлагает {animal.Name}");
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

            else if (Behavior == "охотится" && Name == "Стрекоза")
            {
                foreach (var animal in animals)
                {
                    if (animal is Insect && animal.Amount > 0 && Amount > 0 && animal.Name != "Стрекоза")
                    {
                        int preyAmount = new Random().Next(1, Amount + 1);
                        int hunted = Math.Min(preyAmount, animal.Amount);

                        animal.Amount -= hunted;
                        int increase = new Random().Next(1, hunted + 1);
                        Amount += increase;

                        Console.WriteLine($"{Name} охотится на {animal.Name}. Количество {animal.Name}: {animal.Amount}");
                        Console.WriteLine($"Популяция {Name} увеличилась на {increase}. Текущее количество: {Amount}");

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

            else if (Behavior == "бездействует")
            {
                base.Speak(animals);
            }
            else
            {
                Console.WriteLine($"Поведение {Behavior} невозможно в данном контексте");
            }
        }
    }
}
