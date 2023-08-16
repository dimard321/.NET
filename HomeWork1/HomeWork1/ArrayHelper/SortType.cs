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
        bubbleSort = 1,
        [Description("Сумма положительных членов двумерного масиива")]
        sumOfPositiveTerms,
        [Description("Работа с прямоугльником")]
        rectangle,
        [Description("Выход")]
        exit
    }
    /// <summary>
    /// Представляет действия для выбора сортировки пузырьком.
    /// </summary>
    public enum ChoiceForBubble
    {
        [Description("Выбор действия сортировки по возрастанию")]
        ascending = 1,
        [Description("Выбор действия сортировки по убыванию")]
        descending,
        [Description("Вернуться назад")]
        back
    }
}
