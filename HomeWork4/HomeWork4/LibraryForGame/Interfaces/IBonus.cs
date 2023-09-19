namespace LibraryForGame.Interfaces
{
    public interface IBonus
    {
        /// <summary>
        /// Координата X препятствия.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y препятствия.
        /// </summary>
        public int Y { get; set; }
        /// <summary>
        /// Значение бонуса
        /// </summary>
        public int BonusValue { get; set; }
    }
}
