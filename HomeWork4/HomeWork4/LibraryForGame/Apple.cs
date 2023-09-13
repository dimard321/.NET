namespace LibraryForGame
{
    /// <summary>
    /// Класс представляющий бонус "Яблоко".
    /// </summary>
    public class Apple : Bonus
    {
        /// <summary>
        /// Инициализирует новый экземпляр яблока с указанными координатами и значением бонуса.
        /// </summary>
        /// <param name="x">Координата X яблока.</param>
        /// <param name="y">Координата Y яблока.</param>
        /// <param name="bonusValue">Значение бонуса, которое увеличит HP персонажа.</param>
        public Apple(int x, int y, int bonusValue) : base(x, y, bonusValue)
        {
        }

        /// <summary>
        /// Применяет бонус к персонажу увеличивая его HP.
        /// </summary>
        /// <param name="character">Персонаж к которому применяется бонус.</param>
        public override void ApplyBonus(Character character)
        {
            character.HP += BonusValue;
        }

        /// <summary>
        /// Получает имя характеристики к которой применяется бонус.
        /// </summary>
        /// <returns>Имя характеристики - "HP".</returns>
        public override string GetStat()
        {
            return "HP";
        }
    }
}
