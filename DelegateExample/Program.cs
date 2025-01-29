using System;

namespace DelegateExample
{
    // Declare a delegate
    public delegate void Notify(string message);

    public class Process
    {
        public event Notify ProcessCompleted; // Declare an event

        public void StartProcess()
        {
            Console.WriteLine("Process started...");
            // Simulate process completion
            OnProcessCompleted("Process completed successfully!");
        }

        protected virtual void OnProcessCompleted(string message)
        {
            ProcessCompleted?.Invoke(message); // Trigger the event
        }
    }

    internal class Program
    {
        private static void Main()
        {
            Process process = new Process();
            process.ProcessCompleted += Message => Console.WriteLine(Message); // Subscribe to event
            process.StartProcess();
        }
    }
}