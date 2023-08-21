namespace HomeWork2
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
            string[] subjects = { "Математика", "Физкультура", "ОБЖ", "Русский язык", "Физика", "Чтение", "Музыка", "Рисование" ,"История"};

            var student1c1 = new Student.Student("vasya.pupkin@mail.ru"); 
            var student2c1 = new Student.Student("ivan.ivanov@mail.ru");
            var student3c1 = new Student.Student("sasha.gorniy@mail.ru");
            var student1c3 = new Student.Student("vasya.pupkin@mail.ru");
            var student2c3 = new Student.Student("ivan.ivanov@mail.ru");
            var student3c3 = new Student.Student("vasya.Grozniy@mail.ru");
            var student1c2 = new Student.Student("Vasya", "Pupkin"); 
            var student2c2 = new Student.Student("Ivan", "Ivanov");
            var student3c2 = new Student.Student("Sasha", "Gorniy");
            var student1c4 = new Student.Student("Vasya", "Pupkin"); 
            var student2c4 = new Student.Student("Ivan", "Ivanov");
            var student3c4 = new Student.Student("Pasha", "Usenkov");

            Dictionary<Student.Student, HashSet<string>> studentSubjectDict = new Dictionary<Student.Student, HashSet<string>>(); // Создание словаря 

            // Заполнение словаря данными для каждого студента
            FillStudentSubjectDict(studentSubjectDict, subjects, student1c1); 
            FillStudentSubjectDict(studentSubjectDict, subjects, student2c1);
            FillStudentSubjectDict(studentSubjectDict, subjects, student3c1);
            FillStudentSubjectDict(studentSubjectDict, subjects, student1c2);
            FillStudentSubjectDict(studentSubjectDict, subjects, student2c2);
            FillStudentSubjectDict(studentSubjectDict, subjects, student3c2);
            FillStudentSubjectDict(studentSubjectDict, subjects, student1c3);
            FillStudentSubjectDict(studentSubjectDict, subjects, student2c3);
            FillStudentSubjectDict(studentSubjectDict, subjects, student3c3); 
            FillStudentSubjectDict(studentSubjectDict, subjects, student1c4);
            FillStudentSubjectDict(studentSubjectDict, subjects, student2c4);
            FillStudentSubjectDict(studentSubjectDict, subjects, student3c4);

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
            var randomSubjects = new HashSet<string>(); //оздаем пустой список для случайных предметов
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
        static void FillStudentSubjectDict(Dictionary<Student.Student, HashSet<string>> studentSubjectDict, string[] subjects, Student.Student student) 
        {
            HashSet<string> randomSubjects = GetRandomSubjects(subjects, 3);
            studentSubjectDict[student] = randomSubjects; // Добавление в словарь
        }
    }
}