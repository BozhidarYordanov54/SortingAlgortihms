using SortingAlgortihms.Sorting.Interfaces;
using System.Diagnostics;

namespace SortingAlgortihms.Sorting
{
    public class Sort : ISort
    {
        Stopwatch sw = new Stopwatch();

        public void BubbleSortAscending(int[] array)
        {
            sw.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            sw.Stop();

            PrintTime(sw);
        }

        public void BubbleSortDescending(int[] array)
        {
            sw.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }

            sw.Stop();

            PrintTime(sw);
        }

        public void InsetionSort(int[] array)
        {
            sw.Start();

            for (int i = 1; i < array.Length; i++)
            {
                int temp = array[i];
                int j = i - 1;

                while (j >= 0 && array[j] > temp)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = temp;
            }

            sw.Stop();

            PrintTime(sw);
        }

        public void SelectionSortAscending(int[] array)
        {
            sw.Start();

            for(int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++) 
                {
                    if (array[min] > array[j])
                    {
                        min = j;
                    }
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            sw.Stop();

            PrintTime(sw);
        }

        public void SelectionSortDescending(int[] array)
        {
            sw.Start();

            for (int i = 0; i < array.Length - 1; i++)
            {
                int min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[min] < array[j])
                    {
                        min = j;
                    }
                }

                int temp = array[i];
                array[i] = array[min];
                array[min] = temp;
            }

            sw.Stop();

            PrintTime(sw);
        }

        private void PrintTime(Stopwatch sw)
        {
            Console.WriteLine($"{sw.ElapsedTicks} ticks");
        }

        public void PrintArray(int[] array)
        {
            Console.WriteLine(string.Join(", ", array));
        }
    }
}

