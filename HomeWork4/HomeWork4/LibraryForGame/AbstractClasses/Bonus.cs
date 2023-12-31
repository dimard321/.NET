﻿using LibraryForGame.Interfaces;

namespace LibraryForGame.AbstractClasses
{
    /// <summary>
    /// Абстрактный класс представляющий бонус.
    /// </summary>
    public abstract class Bonus : IBonus, IGameElement
    {
        /// <inheritdoc/>
        public int X { get; set; }
        /// <inheritdoc/>
        public int Y { get; set; }
        /// <inheritdoc/>
        public int BonusValue { get; set; }

        /// <summary>
        /// Инициализирует новый экземпляр бонуса с указанными координатами и значением бонуса.
        /// </summary>
        /// <param name="x">Координата X бонуса.</param>
        /// <param name="y">Координата Y бонуса.</param>
        /// <param name="bonusValue">Значение бонуса.</param>
        public Bonus(int x, int y, int bonusValue)
        {
            X = x;
            Y = y;
            BonusValue = bonusValue;
        }

        /// <summary>
        /// Применить бонус к персонажу.
        /// </summary>
        /// <param name="character">Персонаж, к которому применяется бонус.</param>
        public abstract void ApplyBonus(Character character);

        /// <summary>
        /// Получить имя характеристики, которую бонус затрагивает.
        /// </summary>
        /// <returns>Имя характеристики.</returns>
        public abstract string GetStat();
    }
}
