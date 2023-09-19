using LibraryForGame.Interfaces;

namespace LibraryForGame.AbstractClasses
{
    /// <summary>
    /// Базовый класс персонажей.
    /// </summary>
    public abstract class Character : ICharacter, IGameElement
    {
        /// <inheritdoc/>
        public int HP { get; set; }
        /// <inheritdoc/>
        public int Speed { get; set; }
        /// <inheritdoc/>
        public int Attack { get; set; }
        /// <inheritdoc/>
        public int X { get; set; }
        /// <inheritdoc/>
        public int Y { get; set; }

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