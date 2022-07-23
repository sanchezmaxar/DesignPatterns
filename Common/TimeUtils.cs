namespace Common
{
    public static class TimeUtils
    {
        public static async Task Wait(int seconds, string? message = null)
        {
            while (seconds != 0)
            {
                if (message != null)
                    Console.Write(string.Format(message, seconds--));
                else
                    Console.Write($"Remaining {seconds--} seconds. \r");
                await Task.Delay(TimeSpan.FromSeconds(1));
            }
            Console.WriteLine();
        }


    }
}