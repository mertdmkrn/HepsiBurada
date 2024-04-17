namespace WebApi2
{
    public class CustomFileLogger : ICustomLogger
    {
        public void Log(string message)
        {
            var fileName = $"log-{DateTime.Today.ToString("dd-MM-yyyy")}.txt";
            var filePath = Path.Combine(AppContext.BaseDirectory, fileName);

            message = $"{DateTime.Now.ToString("hh:mm:ss")} => {message}";

            if(File.Exists(filePath))
            {
                File.AppendAllText(filePath, Environment.NewLine + message);
            }
            else
            {
                File.WriteAllText(filePath, message);
            }
        }
    }
}
