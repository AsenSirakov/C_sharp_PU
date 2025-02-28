internal class Program
{
    static int Count = 0;
    static void Main(string[] args)
    {
        Task task1 = Task.Run(() =>
        {
           
            PrintCounter();
        });
     

        Task task2 = Task.Run(() =>
        {
            
            PrintCounter();
        });
        task2.Wait();

        Task task3 = Task.Run(() =>
        {
            PrintCounter();
        });
        
        Task.WaitAll(task1, task2, task3);
    }

    static void PrintCounter()
    {
        int count = 0;

        for (int i = 0; i < 10000; i++)
        {
            Count++;
        }
        Console.WriteLine(Count);
    }

}