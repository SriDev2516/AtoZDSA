namespace Sorting
{
    public class MergeSort 
    {
        public static void Sort(int[] arr, int s, int e)
        {
            if(s >= e){
                return;
            }

            int mid = (s+e)/2;
            Sort(arr, s, mid);
            Sort(arr, mid+1, e);
            MergeSortedArr(arr, s, e);
        }

        private static void MergeSortedArr(int[] arr, int s, int e)
        {
            int mid = (s+e)/2;
            int len1 = mid - s +1;
            int len2 = e - mid;

            int[] first = new int[len1];
            int[] second = new int[len2];

            int mainIndex = s;
            for (int i = 0; i < len1; i++)
            {
                first[i] = arr[mainIndex++];
            }

            for (int i = 0; i < len2; i++)
            {
                second[i] = arr[mainIndex++];
            }

            mainIndex = s;
            int index1 = 0;
            int index2 =0;

            while(index1 < len1 && index2 < len2){
                if(first[index1] < second[index2]){
                    arr[mainIndex++] = first[index1++];
                }
                else{
                    arr[mainIndex++] = second[index2++];
                }
            }

            while(index1 < len1){
                arr[mainIndex++] = first[index1++];
            }

            while(index2 < len2){
                arr[mainIndex++] = second[index2++];
            }

        }
    }
}