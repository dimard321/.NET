using LibraryForGame.AbstractClasses;
using LibraryForGame.Enum;
using LibraryForGame.GameElements;

namespace HomeWork4
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в игру!");
            Console.WriteLine("Выберете персонажа:");
            Console.WriteLine("1. Раса - Человек.");
            Console.WriteLine("2. Раса - Эльф.");

            int choice = int.TryParse(Console.ReadLine(), out int characterChoice) ? characterChoice : 0;
            Character player;

            switch ((ChoseCharacter)choice)
            {
                case ChoseCharacter.Human:
                    player = new Human(10, 5, 1, 0, 0);
                    break;
                case ChoseCharacter.Elph:
                    player = new Elph(8, 7, 2, 0, 0);
                    break;
                default:
                    Console.WriteLine("Такой рассы не существует. Был выбран персонаж по умолчанию - Человек.");
                    player = new Human(10, 5, 1, 0, 0);
                    break;
            }
            var trees = new Tree[3];
            var stones = new Stone[4];
            var wolves = new Wolf[2];
            var bears = new Bear[2];
            var random = new Random();

            for (var i = 0; i < trees.Length; i++)
            {
                trees[i] = new Tree(random.Next(1, 10), random.Next(1, 10));
            }
            for (var i = 0; i < stones.Length; i++)
            {
                stones[i] = new Stone(random.Next(1, 10), random.Next(1, 10));
            }
            for (var i = 0; i < wolves.Length; i++)
            {
                wolves[i] = new Wolf(random.Next(1, 10), random.Next(1, 10), random.Next(1, 5), 15);
            }
            wolves = wolves.Where(wolves => wolves.HP > 0).ToArray();

            for (var i = 0; i < bears.Length; i++)
            {
                bears[i] = new Bear(random.Next(1, 10), random.Next(1, 10), random.Next(5, 10), 15);
            }
            bears = bears.Where(bear => bear.HP > 0).ToArray();

            var bonuses = new List<Bonus>();
            for (var i = 0; i < 10; i++)
            {
                int x = random.Next(1, 10);
                int y = random.Next(1, 10);
                BonusType type = (BonusType)random.Next(0, 2);

                switch (type)
                {
                    case BonusType.Banana:
                        bonuses.Add(new Banana(x, y, random.Next(1, 5)));
                        break;
                    case BonusType.Apple:
                        bonuses.Add(new Apple(x, y, random.Next(1, 5)));
                        break;
                    case BonusType.Cherry:
                        bonuses.Add(new Cherry(x, y, random.Next(1, 5)));
                        break;
                }
            }

            ConsoleKeyInfo keyInfo;
            do
            {
                Console.Clear();
                Console.WriteLine($"Текущие характеристики персонажа: HP = {player.HP}, Speed = {player.Speed}, Attack = {player.Attack}");
                Console.WriteLine($"Персонаж находится в точке {player.X}, {player.Y}");

                if (player.HP <= 0)
                {
                    Console.WriteLine("Смерть. Игра окончена.");
                    break;
                }

                keyInfo = Console.ReadKey();
                int newX = player.X;
                int newY = player.Y;

                switch (keyInfo.Key)
                {
                    case ConsoleKey.UpArrow:
                        newY--;
                        break;
                    case ConsoleKey.DownArrow:
                        newY++;
                        break;
                    case ConsoleKey.LeftArrow:
                        newX--;
                        break;
                    case ConsoleKey.RightArrow:
                        newX++;
                        break;
                }

                if (newX < 0 || newX >= 11 || newY < 0 || newY >= 11)
                {
                    Console.WriteLine("Вы не можете выйти за пределы игрового поля 10x10.");
                    Thread.Sleep(1000);
                    continue;
                }
                // Проверки
                bool collision = false;
                foreach (Tree tree in trees)
                {
                    if (newX == tree.X && newY == tree.Y)
                    {
                        collision = true;
                        Console.WriteLine("Игрок столкнулся с деревом.");
                        break;
                    }
                }

                foreach (Stone stone in stones)
                {
                    if (newX == stone.X && newY == stone.Y)
                    {
                        collision = true;
                        Console.WriteLine("Игрок столкнулся с камнем.");
                        break;
                    }
                }

                foreach (Wolf wolf in wolves)
                {
                    if (newX == wolf.X && newY == wolf.Y)
                    {
                        wolf.HP -= player.Attack;
                        Console.WriteLine($"Игрок атаковал волка и нанес {player.Attack} урона. Здоровье волка: {wolf.HP}");
                        if (wolf.HP <= 0)
                        {
                            Console.WriteLine("Волк умер.");
                            Array.Resize(ref wolves, wolves.Length - 1);
                        }
                        else
                        {
                            player.TakeDamage(wolf.Attack);
                            Console.WriteLine($"Волк атаковал игрока и нанес {wolf.Attack} урона. Здоровье игрока: {player.HP}");
                        }
                        break;
                    }
                }

                foreach (Bear bear in bears)
                {
                    if (newX == bear.X && newY == bear.Y)
                    {
                        bear.HP -= player.Attack;
                        Console.WriteLine($"Игрок атаковал медведя и нанес {player.Attack} урона. Здоровье медведя: {player.HP}");
                        if (bear.HP <= 0)
                        {
                            Console.WriteLine("Медведь умер.");
                            Array.Resize(ref bears, bears.Length - 1);
                        }
                        else
                        {
                            player.TakeDamage(bear.Attack);
                            Console.WriteLine($"Медведь атаковал человека и нанес {bear.Attack} урона. Здоровье игрока: {player.HP}");
                        }
                        break;
                    }
                }

                foreach (Bonus bonus in bonuses.ToList())
                {
                    if (newX == bonus.X && newY == bonus.Y)
                    {
                        // Применяем бонус к соответствующей характеристике персонажа
                        bonus.ApplyBonus(player);
                        Console.WriteLine($"Игрок получил бонус: {bonus.GetType().Name}. Текущая характеристика: {bonus.GetStat()} = {player.GetStatValue(bonus.GetStat())}");
                        bonuses.Remove(bonus);
                        break;
                    }
                }

                //движение волков и медведей
                foreach (Wolf wolf in wolves)
                {
                    wolf.MoveMonster(trees, stones);
                }

                foreach (Bear bear in bears)
                {
                    bear.MoveMonster(trees, stones);
                }

                if (bonuses.Count == 0)
                {
                    Console.WriteLine("Вы собрали все бонусы. Игра окончена.");
                    break;
                }

                if (!collision)
                {
                    player.X = newX;
                    player.Y = newY;
                }

                Console.WriteLine("В какую сторону пойдём?");
                Console.ReadKey();
            } while (keyInfo.Key != ConsoleKey.Escape);
        }
    }
}
