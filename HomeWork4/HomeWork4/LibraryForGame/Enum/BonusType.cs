using System.ComponentModel;

namespace LibraryForGame.Enum
{
    /// <summary>
    /// Перечисление типов бонусов.
    /// </summary>
    public enum BonusType
    {
        /// <summary>
        /// Бонус в виде банана.
        /// </summary>
        [Description("Банан")]
        Banana,
        /// <summary>
        /// Бонус в виде яблока.
        /// </summary>
        [Description("Яблоко")]
        Apple,
        /// <summary>
        /// Бонус в виде вишни.
        /// </summary>
        [Description("Вишня")]
        Cherry
    }
}
