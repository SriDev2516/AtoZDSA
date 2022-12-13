namespace Sorting
{
    public class QuickSort
    {
        public static void Sort(int[] arr, int s, int e)
        {
           if(s >= e){
            return;
           }

           int p = Partition(arr, s, e);
           Sort(arr, s, p-1);
           Sort(arr, p+1, e);
        }

        private static int Partition(int[] arr, int s, int e)
        {
            int pivot = arr[s];

            int count = 0;
            for(int i = s+1; i<=e; i++){
                if(arr[i] <= pivot){
                count++;

                }
            }

            int pivotIndex = s+count;

            int temp = arr[pivotIndex];
            arr[pivotIndex] = arr[s];
            arr[s] = temp;

            int l = s; int r = e;

            while(l < pivotIndex && r > pivotIndex){
                while(arr[l] <= pivot){
                    l++;
                }
                while(arr[r] > pivot){
                    r--;
                }
                if(l < pivotIndex && r > pivotIndex){
                    int tempI = arr[l];
                    arr[l] = arr[r];
                    arr[r] = tempI;
                    l++;
                    r--;
                }
            }

            return pivotIndex;
        }
    }
}