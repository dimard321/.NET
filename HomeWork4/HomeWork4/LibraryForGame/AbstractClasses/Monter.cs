using LibraryForGame.Enum;
using LibraryForGame.GameElements;
using LibraryForGame.Interfaces;

namespace LibraryForGame.AbstractClasses
{
    /// <summary>
    /// Представляет базовый класс для монстров
    /// </summary>
    public abstract class Monter : IMonster, IGameElement
    {
        /// <inheritdoc/>
        public int X { get; set; }
        /// <inheritdoc/>
        public int Y { get; set; }
        /// <inheritdoc/>
        public int Attack { get; set; }
        /// <inheritdoc/>
        public int HP { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр монстра с указанными параметрами
        /// </summary>
        /// <param name="x">Координата X монстра.</param>
        /// <param name="y">Координата Y монстра.</param>
        /// <param name="attack">Сила атаки монстра.</param>
        /// <param name="hp">Здоровье монстра.</param>
        public Monter(int x, int y, int attack, int hp)
        {
            X = x;
            Y = y;
            Attack = attack;
            HP = hp;
        }
        /// <summary>
        /// Перемещение монстра на игровом поле
        /// </summary>
        /// <param name="trees">Массив деревьев на игровом поле.</param>
        /// <param name="stones">Массив камней на игровом поле.</param>
        public void MoveMonster(Tree[] trees, Stone[] stones)
        {
            Random random = new Random();

            int newX = X;
            int newY = Y;

            MonsterMovement movement = (MonsterMovement)random.Next(0, 4);

            switch (movement)
            {
                case MonsterMovement.Up: // Вверх
                    newY--;
                    break;
                case MonsterMovement.Down: // Вниз
                    newY++;
                    break;
                case MonsterMovement.Left: // Влево
                    newX--;
                    break;
                case MonsterMovement.Right: // Вправо
                    newX++;
                    break;
                default:
                    break;
            }

            if (IsActualMove(newX, newY, trees, stones))
            {
                X = newX;
                Y = newY;
            }
        }
        /// <summary>
        /// Проверка является ли позиция доступной для перемещения монстра.
        /// </summary>
        /// <param name="x">Координата X для проверки.</param>
        /// <param name="y">Координата Y для проверки.</param>
        /// <param name="trees">Массив деревьев на игровом поле.</param>
        /// <param name="stones">Массив камней на игровом поле.</param>
        /// <returns>Возвращает true, если перемещение допустимо, и false в противном случае.</returns>
        private bool IsActualMove(int x, int y, Tree[] trees, Stone[] stones)
        {
            if (x < 0 || x >= 10 || y < 0 || y >= 10)
            {
                return false;
            }

            foreach (Tree tree in trees)
            {
                if (x == tree.X && y == tree.Y)
                {
                    return false;
                }
            }

            foreach (Stone stone in stones)
            {
                if (x == stone.X && y == stone.Y)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
