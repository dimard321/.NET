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
        /// <summary>
        /// Координата X препятствия.
        /// </summary>
        public int X { get; set; }
        /// <summary>
        /// Координата Y препятствия.
        /// </summary>
        public int Y { get; set; }

    }
}
