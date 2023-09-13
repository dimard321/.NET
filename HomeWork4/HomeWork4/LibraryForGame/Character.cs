namespace LibraryForGame
{
    /// <summary>
    /// Базовый класс персонажей.
    /// </summary>
    public class Character
    {
        /// <summary>
        /// Здоровье персонажа.
        /// </summary>
        public int HP { get; set; }
        /// <summary>
        /// Скорость перемещения персонажа.
        /// </summary>
        public int Speed { get; set; }
        /// <summary>
        /// Сила атаки персонажа.
        /// </summary>
        public int Attack { get; set; }
        /// <summary>
        /// Координата X препятствия.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y препятствия.
        /// </summary>
        public int Y { get; set; } = 0;

        /// <summary>
        /// Инициализирует новый экземпляр персонажа с указанными параметрами.
        /// </summary>
        /// <param name="hp">Здоровье персонажа.</param>
        /// <param name="speed">Скорость персонажа.</param>
        /// <param name="attack">Уровень атаки персонажа.</param>
        /// <param name="x">Координата X персонажа.</param>
        /// <param name="y">Координата Y персонажа.</param>
        public Character(int hp, int speed, int attack, int x, int y)
        {
            HP = hp;
            Speed = speed;
            Attack = attack;
            X = x;
            Y = y;
        }
        /// <summary>
        /// Получить значение характеристики по ее имени.
        /// </summary>
        /// <param name="statName">Имя характеристики.</param>
        /// <returns>Значение характеристики.</returns>
        public int GetStatValue(string statName)
        {
            switch (statName)
            {
                case "HP":
                    return HP;
                case "Speed":
                    return Speed;
                case "Attack":
                    return Attack;
                default:
                    throw new ArgumentException("Неверное имя характеристики", nameof(statName));
            }
        }
        /// <summary>
        /// Нанести урон персонажу.
        /// </summary>
        /// <param name="damage">Уровень урона.</param>
        public void TakeDamage(int damage)
        {
            HP -= damage;
        }
    }
}