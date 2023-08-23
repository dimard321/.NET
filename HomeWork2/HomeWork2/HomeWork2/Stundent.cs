namespace HomeWork2
{
    /// <summary>
    /// Представляет студента с данными о полном имени и электронной почте.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Полное имя студента.
        /// </summary>
        public string FullName { get; private set; }
        /// <summary>
        /// Электронная почта студента
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Конструктор для создания объекта Student по электронной почте.
        /// </summary>
        /// <param name="email">Электронная почта студента.</param>
        public Student(string email)
        {
            Email = email;
            FullName = GetFullNameFromEmail(email); // Получаем полное имя из электронной почты
        }

        /// <summary>
        /// Конструктор для создания объекта Student по имени и фамилии.
        /// </summary>
        /// <param name="firstName">Имя студента.</param>
        /// <param name="lastName">Фамилия студента.</param>
        public Student(string firstName, string lastName)
        {
            FullName = $"{firstName} {lastName}";
            Email = GetEmailFromFullName(firstName, lastName); // Получаем электронную почту из имени и фамилии
        }

        /// <summary>
        /// Получает полное имя студента из электронной почты.
        /// </summary>
        /// <param name="email">Электронная почта студента.</param>
        /// <returns>Полное имя студента.</returns>
        private string GetFullNameFromEmail(string email)
        {
            var emailParts = email.Split('@');
            var nameParts = emailParts[0].Split('.');
            var firstName = char.ToUpper(nameParts[0][0]) + nameParts[0].Substring(1);
            var lastName = char.ToUpper(nameParts[1][0]) + nameParts[1].Substring(1);
            return $"{firstName} {lastName}";
        }

        /// <summary>
        /// Получение электронной почты из имени и фамилии
        /// </summary>
        /// <param name="firstName"></param>
        /// <param name="lastName"></param>
        /// <returns>Строка, представляющая электронную почту в формате "имя.фамилия@mail.ru".</returns>
        private string GetEmailFromFullName(string firstName, string lastName)
        {
            var lowercaseFirstName = firstName.ToLower();
            var lowercaseLastName = lastName.ToLower();
            return $"{lowercaseFirstName}.{lowercaseLastName}@mail.ru";
        }

        /// <summary>
        /// Переопределение метода Equals для сравнения студентов по электронной почте.
        /// </summary>
        /// <param name="obj">Объект для сравнения.</param>
        /// <returns>True, если студенты имеют одинаковую электронную почту, иначе False.</returns>
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType()) // Если null или типы разные
                return false;

            Student some = (Student)obj; // Преобразуем объект в тип Student для сравнения
            return Email == some.Email; // Сравниваем почты
        }

        /// <summary>
        /// Переопределение метода GetHashCode для генерации хэш-кода на основе электронной почты.
        /// </summary>
        /// <returns>Хэш-код.</returns>
        public override int GetHashCode()
        {
            return Email.GetHashCode(); // Возвращаем хэш-код на основе электронной почты
        }
    }
}
