namespace EcpiWebAPI.Services
{
    public static class ValuesService
    {
        private static readonly List<string> Summaries = new List<string>
        {
            "value1", "value2", "Bob"
        };

        public static string[] GetValues()
        {
            // Return a copy to prevent direct modification of the list.
            lock (Summaries)
            {
                return Summaries.ToArray();
            }
        }

        public static void AddValues(string value)
        {
            if (!string.IsNullOrEmpty(value))
            {
                lock (Summaries) // Ensure thread safety.
                {
                    Summaries.Add(value);
                }
            }
        }
    }
}