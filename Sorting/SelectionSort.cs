namespace Sorting
{
    public class SelectionSort
    {
        public static void Sort(int[] arr)
        {
            for(int i=0; i<arr.Length-1;i++){
                int min = i;
                for(int j= i+1; j < arr.Length;j++){
                    if(arr[j] < arr[min]){
                        min = j;
                    }
                    int temp = arr[min];
                    arr[min] = arr[i];
                    arr[i] = temp;
                }
            }
             Print.Display(arr);
        }
    }
}