using LibraryForGame.AbstractClasses;

namespace LibraryForGame.GameElements
{
    /// <summary>
    /// Класс представляющий бонус "Банан".
    /// </summary>
    public class Banana : Bonus
    {
        /// <summary>
        /// Инициализирует новый экземпляр банана с указанными координатами и значением бонуса.
        /// </summary>
        /// <param name="x">Координата X банана.</param>
        /// <param name="y">Координата Y банана.</param>
        /// <param name="bonusValue">Значение бонуса, которое увеличит скорость персонажа.</param>
        public Banana(int x, int y, int bonusValue) : base(x, y, bonusValue)
        {
        }

        /// <summary>
        /// Применяет бонус к персонажу увеличивая его скорость.
        /// </summary>
        /// <param name="character">Целевой персонаж, к которому применяется бонус.</param>
        public override void ApplyBonus(Character character)
        {
            character.Speed += BonusValue;
        }

        /// <summary>
        /// Получает имя характеристики к которой применяется бонус.
        /// </summary>
        /// <returns>Имя характеристики - "Speed".</returns>
        public override string GetStat()
        {
            return "Speed";
        }
    }
}
