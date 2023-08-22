using System.Diagnostics;

namespace Perfomance
{
    /// <summary>
    /// Главный класс программы.
    /// </summary>
    class Perfomace
    {
        /// <summary>
        /// Главный метод программы.
        /// </summary>
        /// <param name="args">Аргументы командной строки.</param>
        static void Main(string[] args)
        {
            const int Size = 100000;

            //до создания массивов классов "C"
            var privateMemoryC = GC.GetTotalMemory(true);
            Console.WriteLine($"PrivateMemorySize64 до инициализации массива classes: {privateMemoryC / 1024} KB");

            var classes = new C[Size];
            for (int i = 0; i < Size; i++)
            {
                classes[i] = new C { i = GetRandomNumber() };
            }

            //после создания массивов классов "C" 
            var ultimatePrivateMemoryC = GC.GetTotalMemory(true);
            Console.WriteLine($"PrivateMemorySize64 после инициализации массива classes: {ultimatePrivateMemoryC / 1024} KB");

            //до создания массивов структур "S"
            var privateMemoryS = GC.GetTotalMemory(true);
            Console.WriteLine($"\nPrivateMemorySize64 до инициализации массива structs: {privateMemoryS / 1024} KB");

            var structs = new S[Size];
            for (int i = 0; i < Size; i++)
            {
                structs[i] = new S { i = GetRandomNumber() };
            }

            //после создания массивов структур "S" 
            var ultimatePrivateMemoryS = GC.GetTotalMemory(true);
            Console.WriteLine($"PrivateMemorySize64 после инициализации массива structs: {ultimatePrivateMemoryS / 1024} KB");

            //Разница до и после
            Console.WriteLine($"\nПамяти использовано для массива classes : {(ultimatePrivateMemoryC - privateMemoryC) / 1024} KB");
            Console.WriteLine($"Памяти использовано для массива structs: {(ultimatePrivateMemoryS - privateMemoryS) / 1024} KB");

            Stopwatch stopwatch = new Stopwatch();

            // Сортировка массива классов "C"
            stopwatch.Start(); //секундомер
            Array.Sort(classes, (x, y) => x.i.CompareTo(y.i));   //(x,y) это это два элемента из массива, которые сравниваются, CompareTo() по сравнению с
            stopwatch.Stop();
            var elapsedMillisecondsClasses = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"\nВремя затраченое на сортировку массива classes: {stopwatch.ElapsedMilliseconds} ms");

            // Сортировка массива структур "S"
            stopwatch.Reset();
            stopwatch.Start();
            Array.Sort(structs, (x, y) => x.i.CompareTo(y.i));
            stopwatch.Stop();
            var elapsedMillisecondsStructs = stopwatch.ElapsedMilliseconds;
            Console.WriteLine($"Время затраченое на сортировку массива structs: {stopwatch.ElapsedMilliseconds} ms");

            if (elapsedMillisecondsClasses < elapsedMillisecondsStructs)
            {
                Console.WriteLine("\nСортировка classes быстрее.");
            }
            else if (elapsedMillisecondsClasses > elapsedMillisecondsStructs)
            {
                Console.WriteLine("\nСортировка structs быстрее.");
            }
            else
            {
                Console.WriteLine("\nСортировка заняла одинаковое количество времени.");
            }
        }

        /// <summary>
        /// Генерирует случайное целое число.
        /// </summary>
        /// <returns>Случайное целое число.</returns>
        static int GetRandomNumber()
        {
            Random random = new Random();
            return random.Next();
        }
    }
}
