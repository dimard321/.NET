namespace DelegateDemo
{
    class FirstSubscriber
    {
        /// <summary>
        /// Конструктор класса FirstSubscriber, принимающий объект Countdown для подписки на его события.
        /// </summary>
        /// <param name="cd">Объект Countdown, на события которого будет подписан FirstSubscriber.</param>
        public FirstSubscriber(Countdown cd)
        {
            cd.Notify += GetMessage;
        }

        /// <summary>
        /// Метод, вызываемый при получении сообщения от Countdown.
        /// </summary>
        /// <param name="sender">Объект-отправитель сообщения.</param>
        /// <param name="message">Сообщение, полученное от Countdown.</param>
        public void GetMessage(object sender, Message message)
        {
            Console.WriteLine("First subscribe get message");

            Console.WriteLine("Class sender: {0}; Message: {1}", sender.GetType().Name, message.MyMessage);
        }
    }
}
