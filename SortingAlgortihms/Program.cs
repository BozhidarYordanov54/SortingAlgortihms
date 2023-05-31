using SortingAlgortihms.Sorting;

int[] array = { 9, 1, 8, 2, 7, 3, 6, 5, 4 };
int[] array1 = { 9, 1, 8, 2, 7, 3, 6, 5, 4 };
int[] array2 = { 9, 1, 8, 2, 7, 3, 6, 5, 4 };

Sort sort = new Sort();

sort.PrintArray(array);
sort.InsetionSort(array);
sort.PrintArray(array);

sort.PrintArray(array1);
sort.BubbleSortAscending(array1);
sort.PrintArray(array1);

sort.PrintArray(array2);
sort.SelectionSortAscending(array2);
sort.PrintArray(array2);