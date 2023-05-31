namespace SortingAlgortihms.Sorting.Interfaces
{
    public interface ISort
    {
        public void BubbleSortAscending(int[] array);
        public void BubbleSortDescending(int[] array);
        public void SelectionSortAscending(int[] array);
        public void SelectionSortDescending(int[] array);
        public void InsetionSort(int[] array);
    }
}
