namespace LibraryForGame.Interfaces
{
    public interface ICharacter
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
    }
}
