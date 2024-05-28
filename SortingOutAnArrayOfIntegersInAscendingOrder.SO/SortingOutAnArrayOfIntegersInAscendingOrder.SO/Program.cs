namespace SortingOutAnArrayOfIntegersInAscendingOrder.SO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 59, 30, 25, 10, 22, 11, 70 };
            int[] sortedArray = BubbleSort(array);
            Console.WriteLine(string.Join(", ", sortedArray));
        }

        public static int[] BubbleSort(int[] array)
        {
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        // Swap array[j] and array[j + 1]
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            return array;

        }
    }
}