using System;

namespace ActionAsEvent
{
    public class Process
    {
        // Declare an event using Action
        public event Action<string> ProcessCompleted;

        public void StartProcess()
        {
            Console.WriteLine("Process started...");
            // Simulate process completion
            OnProcessCompleted("Process completed successfully!");
        }

        protected virtual void OnProcessCompleted(string message)
        {
            // Invoke the event (if any subscribers exist)
            ProcessCompleted?.Invoke(message);
        }
    }

    internal class Program
    {
        private static void Main()
        {
            Process process = new Process();

            // Subscribe to the event using an Action
            process.ProcessCompleted += message => Console.WriteLine($"Action Event Received: {message}");

            // Start the process
            process.StartProcess();

            // Adding another subscriber
            process.ProcessCompleted += AnotherHandler;

            process.StartProcess();
        }

        private static void AnotherHandler(string message)
        {
            Console.WriteLine($"Another handler received the message: {message}");
        }
    }
}