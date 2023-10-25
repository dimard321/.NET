using System.Timers;

namespace DelegateDemo
{
    /// <summary>
    /// Класс для управления обратным отсчетом с использованием таймера.
    /// </summary>
    public class Countdown
    {
        /// <summary>
        /// Таймер, используемый для отсчета времени.
        /// </summary>
        public System.Timers.Timer Timer { get; set; }

        public delegate void Handler(object sender, Message message);

        /// <summary>
        /// Событие, которое возникает при завершении отсчета.
        /// </summary>
        public event Handler Notify;

        // <summary>
        /// Конструктор класса Countdown, инициализирующий таймер и устанавливающий обработчик события.
        /// </summary>
        /// <param name="timer">Таймер, используемый для отсчета времени.</param>
        public Countdown(System.Timers.Timer timer)
        {
            if (timer.Interval < 0)
            {
                throw new ArgumentException("Interval < 0");
            }

            Timer = timer;

            Timer.Elapsed += timer_Elapsed;
        }

        /// <summary>
        /// Обработчик события, вызываемый при завершении интервала таймера.
        /// </summary>
        /// <param name="sender">Объект-отправитель события.</param>
        /// <param name="e">Аргументы события.</param>
        public void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            Notify?.Invoke(this, new Message());

            Timer.Stop();
        }
    }
}
