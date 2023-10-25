namespace DelegateDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //PrintOf printMatrix;

            //printMatrix = MatrixHelper.PrintMatrix;

            var matrix = new int[5, 5];

            var random = new Random();

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = random.Next(0, 10);
                }
            }

            Console.WriteLine($"Начальная матрица:");

            MatrixHelper.PrintMatrix(matrix);

            /*DoSortMatrix(matrix, bubbleSort.SortSumOfMatrixRowElementsAsc);

            DoSortMatrix(matrix, bubbleSort.SortSumOfMatrixRowElementsDesc);

            DoSortMatrix(matrix, bubbleSort.SortOfMaxElementInARowOfTheMatrixAsc);

            DoSortMatrix(matrix, bubbleSort.SortOfMaxElementInARowOfTheMatrixDesc);

            DoSortMatrix(matrix, bubbleSort.SortOfMinElementInARowOfTheMatrixAsc);

            DoSortMatrix(matrix, bubbleSort.SortOfMinElementInARowOfTheMatrixDesc);

            void DoSortMatrix(int[,] matrix, SortMatrix sortMatrix)
            {
                printMatrix(sortMatrix(matrix));
            }*/

            var bubbleSortArray = new BubbleSortArray();

            var result = bubbleSortArray.BubbleSortBySumElementsInRowAsc(matrix);

            Console.WriteLine("Матрица, отсортированная по возрастанию суммы строк:");

            MatrixHelper.PrintMatrix(result);

            result = bubbleSortArray.BubbleSortBySumElementsInRowDesc(matrix);

            Console.WriteLine("Матрица, отсортированная по убыванию суммы строк:");

            MatrixHelper.PrintMatrix(result);

            result = bubbleSortArray.BubbleSortByMaxElementInRowAsc(matrix);

            Console.WriteLine("Матрица, отсортированная в порядке возрастания, по максимальному элементу в строке:");

            MatrixHelper.PrintMatrix(result);

            result = bubbleSortArray.BubbleSortByMaxElementInRowDesc(matrix);

            Console.WriteLine("Матрица, отсортированная в порядке убывания, по максимальному элементу в строке:");

            MatrixHelper.PrintMatrix(result);

            result = bubbleSortArray.BubbleSortByMinElementsInRowAsc(matrix);

            Console.WriteLine("Матрица, отсортированная в порядке возрастания, по минимальному элементу в строке:");

            MatrixHelper.PrintMatrix(result);

            result = bubbleSortArray.BubbleSortByMinElementsInRowDesc(matrix);

            Console.WriteLine("Матрица, отсортированная в порядке убывания, по минимальному элементу в строке:");

            MatrixHelper.PrintMatrix(result);

            Console.WriteLine("-------------------------------------------------------------------------------------\n");

            /*OperationWithMatrix operation = SortMatrix(OperationType.SortSumOfMatrixRowElements, SortType.ASC);

            printMatrix(operation(matrix));

            operation = SortMatrix(OperationType.SortSumOfMatrixRowElements, SortType.DESC);

            printMatrix(operation(matrix));

            operation = SortMatrix(OperationType.SortOfMaxElementInARowOfTheMatrix, SortType.ASC);

            printMatrix(operation(matrix));

            operation = SortMatrix(OperationType.SortOfMaxElementInARowOfTheMatrix, SortType.DESC);

            printMatrix(operation(matrix));

            operation = SortMatrix(OperationType.SortOfMinElementInARowOfTheMatrix, SortType.ASC);

            printMatrix(operation(matrix));

            operation = SortMatrix(OperationType.SortOfMinElementInARowOfTheMatrix, SortType.DESC);

            printMatrix(operation(matrix));
        }*/

            /* private static OperationWithMatrix SortMatrix(OperationType opType, SortType sortType)
             {
                 var bubbleSort = new BubbleSortArray();

                 switch (opType)
                 {
                     case OperationType.SortSumOfMatrixRowElements:
                         switch (sortType)
                         {
                             case SortType.ASC:
                                 return bubbleSort.SortSumOfMatrixRowElementsAsc;

                             case SortType.DESC:
                                 return bubbleSort.SortSumOfMatrixRowElementsDesc;
                             default:
                                 break;
                         }
                         break;
                     case OperationType.SortOfMaxElementInARowOfTheMatrix:
                         switch (sortType)
                         {
                             case SortType.ASC:
                                 return bubbleSort.SortOfMaxElementInARowOfTheMatrixAsc;

                             case SortType.DESC:
                                 return bubbleSort.SortOfMaxElementInARowOfTheMatrixDesc;
                             default:
                                 break;
                         }
                         break;
                     case OperationType.SortOfMinElementInARowOfTheMatrix:
                         switch (sortType)
                         {
                             case SortType.ASC:
                                 return bubbleSort.SortOfMinElementInARowOfTheMatrixAsc;

                             case SortType.DESC:
                                 return bubbleSort.SortOfMinElementInARowOfTheMatrixDesc;
                             default:
                                 break;
                         }
                         break;
                     default:
                         break;
                 }
                 return null;
             }*/

            Countdown cd = new Countdown(new System.Timers.Timer { Interval = 2000d });

            var firstSub = new FirstSubscriber(cd);

            var secondSub = new SecondSubscriber(cd);

            cd.Timer.Start();

            Console.ReadKey();

            //delegate void PrintOf(int[,] matrix);

            //delegate int[,] OperationWithMatrix(int[,] matrix);
        }
    }
}
