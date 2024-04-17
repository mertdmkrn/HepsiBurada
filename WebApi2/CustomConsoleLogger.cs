namespace WebApi2
{
    public class CustomConsoleLogger : ICustomLogger
    {
        public void Log(string message)
        {
            message = $"{DateTime.Now.ToString("hh:mm:ss")} => {message}";
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }
}
