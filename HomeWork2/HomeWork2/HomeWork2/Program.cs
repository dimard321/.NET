using HomeWork2;

namespace Stundents
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Program
    {
        /// <summary>
        /// Точка входа в программу.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            string[] subjects = { "Математика", "Физкультура", "ОБЖ", "Русский язык", "Физика", "Чтение", "Музыка", "Рисование", "История" };

            var student1c1 = new Student("vasya.pupkin@mail.ru");
            var student2c1 = new Student("ivan.ivanov@mail.ru");
            var student3c1 = new Student("sasha.gorniy@mail.ru");
            var student1c2 = new Student("Vasya", "Pupkin");
            var student2c2 = new Student("Ivan", "Ivanov");
            var student3c2 = new Student("Sasha", "Gorniy");

            Dictionary<Student, HashSet<string>> studentSubjectDict = new Dictionary<Student, HashSet<string>>() // Создание словаря 

            {
                [student1c1] = FillStudentSubjectDict(subjects),
                [student2c1] = FillStudentSubjectDict(subjects),
                [student3c1] = FillStudentSubjectDict(subjects),
                [student1c2] = FillStudentSubjectDict(subjects),
                [student2c2] = FillStudentSubjectDict(subjects),
                [student3c2] = FillStudentSubjectDict(subjects)
            };

            foreach (var keyPair in studentSubjectDict) // Вывод информации о студентах и предметах
            {
                Console.WriteLine($"{keyPair.Key.FullName}: {string.Join(", ", keyPair.Value)}");
            }
        }
        /// <summary>
        /// Получение случайных предметов.
        /// </summary>
        /// <param name="subjects">Массив предметов.</param>
        /// <param name="count">Количество предметов для выбора.</param>
        /// <returns>Список случайных предметов.</returns>
        static HashSet<string> GetRandomSubjects(string[] subjects, int count)
        {
            Random random = new Random(); //объект для генерации 
            var randomSubjects = new HashSet<string>(); //cоздаем пустой список для случайных предметов
            while (randomSubjects.Count < count)
            {
                var index = random.Next(subjects.Length);
                randomSubjects.Add(subjects[index]);
            }
            return randomSubjects; //список случайных предметов 
        }
        /// <summary>
        /// Заполнение словаря данными для студента.
        /// </summary>
        /// <param name="dict">Словарь для хранения данных.</param>
        /// <param name="subjects">Массив предметов.</param>
        /// <param name="student">Студент, для которого заполняются данные.</param>
        static HashSet<string> FillStudentSubjectDict(string[] subjects)
        {
            return GetRandomSubjects(subjects, 3);
        }
    }
}
