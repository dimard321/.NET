using System.ComponentModel;

namespace ArrayHelper
{
    /// <summary>
    /// Представляет тип сортировки массива.
    /// </summary>
    public enum SortType
    {
        [Description("Сортировка по возрастанию")]
        ASC = 1,
        [Description("Сортировка по убыванию")]
        DESC
    }
    /// <summary>
    /// Представляет основное меню выбора действий.
    /// </summary>
    public enum MainMenuChoice
    {
        [Description("Сортировка пузырьком")]
        BubbleSort = 1,
        [Description("Сумма положительных членов двумерного масиива")]
        SumOfPositiveTerms,
        [Description("Работа с прямоугльником")]
        Rectangle,
        [Description("Выход")]
        Exit
    }
    /// <summary>
    /// Представляет действия для выбора сортировки пузырьком.
    /// </summary>
    public enum BubbleSortType
    {
        [Description("Выбор действия сортировки по возрастанию")]
        ASC = 1,
        [Description("Выбор действия сортировки по убыванию")]
        DESC,
        [Description("Вернуться назад")]
        Back
    }
}
