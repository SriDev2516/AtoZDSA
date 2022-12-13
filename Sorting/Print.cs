public class Print{
    public static void Display(int[] arr){
        foreach(int num in arr)
        {
            Console.Write($"{num}, ");
        }
        System.Console.WriteLine();
    }
}