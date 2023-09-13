using System.ComponentModel;

namespace LibraryForGame
{
    /// <summary>
    /// Перечисление типов бонусов.
    /// </summary>
    public enum BonusType
    {
        [Description("Банан")]
        Banana,
        [Description("Яблоко")]
        Apple,
        [Description("Вишня")]
        Cherry
    }
}
