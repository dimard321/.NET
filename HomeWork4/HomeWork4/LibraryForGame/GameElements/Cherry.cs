using LibraryForGame.AbstractClasses;

namespace LibraryForGame.GameElements
{
    /// <summary>
    /// Класс представляющий бонус "Вишня".
    /// </summary>
    public class Cherry : Bonus
    {
        /// <summary>
        /// Инициализирует новый экземпляр вишни с указанными параметрами.
        /// </summary>
        /// <param name="x">Координата X вишни.</param>
        /// <param name="y">Координата Y вишни.</param>
        /// <param name="bonusValue">Значение бонуса.</param>
        public Cherry(int x, int y, int bonusValue) : base(x, y, bonusValue)
        {
        }
        /// <summary>
        /// Применить бонус к персонажу.
        /// </summary>
        /// <param name="character">Персонаж, к которому применяется бонус.</param>
        public override void ApplyBonus(Character character)
        {
            character.Attack += BonusValue;
        }

        /// <summary>
        /// Получает имя характеристики к которой применяется бонус.
        /// </summary>
        /// <returns>Имя характеристики - "Attack".</returns>
        public override string GetStat()
        {
            return "Attack";
        }
    }
}
