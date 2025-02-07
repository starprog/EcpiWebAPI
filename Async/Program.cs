using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Async
{
    internal class Program
    {
        private static async Task Main()
        {
            Task<int> task1 = ComputeAsync(5);
            Task<int> task2 = ComputeAsync(10);

            int[] results = await Task.WhenAll(task1, task2);

            Console.WriteLine($"Results: {results[0]}, {results[1]}");
        }

        private static async Task<int> ComputeAsync(int value)
        {
            await Task.Delay(1000); // Simulating computation
            return value * value;
        }
    }
}

//Basic Async Method
//internal class Program
//{
//    private static async Task Main()
//    {
//        Console.WriteLine("Start");
//        await DoWorkAsync();
//        Console.WriteLine("End");
//    }

//    private static async Task DoWorkAsync()
//    {
//        await Task.Delay(2000); // Simulating async work
//        Console.WriteLine("Work Completed");
//    }
//}

//Async in Real-World Scenarios
//private static async Task Main()
//{
//    Console.WriteLine("Fetching data...");
//    string data = await FetchDataAsync();
//    Console.WriteLine("Data Received: " + data.Substring(0, 50) + "...");
//}

//private static async Task<string> FetchDataAsync()
//{
//    HttpClient client = new HttpClient();
//    return await client.GetStringAsync("https://jsonplaceholder.typicode.com/posts/1");
//}