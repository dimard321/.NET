using System.Globalization;

namespace DelegateDemo
{
    /// <summary>
    /// Класс, представляющий сообщение, которое отправляется подписчикам объекта Countdown.
    /// </summary>
    public class Message
    {
        /// <summary>
        /// Текст сообщения.
        /// </summary>
        public string MyMessage { get; set; }

        /// <summary>
        /// Конструктор класса Message, инициализирующий текст сообщения с текущей датой и временем.
        /// </summary>
        public Message()
        {
            MyMessage += DateTime.Now.ToString(CultureInfo.InvariantCulture);

            MyMessage += "Message for subscribes";
        }
    }
}
