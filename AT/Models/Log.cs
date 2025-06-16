namespace AT.Models
{
    public class Log
    {
        public static void LogToConsole(string mensagem)
        {
            Console.WriteLine("Mensagem: " + mensagem);
        }
        public static void LogToFile(string mensagem)
        {
            File.AppendAllText("logs.txt", mensagem);
        }
        public static List<string> LogsMemoria = new();
        public static void LogToMemory(string mensagem)
        {
            LogsMemoria.Add(mensagem);

        }
        public static Action<string> Logs;
        public void AdicionarLogs()
        {
            Logs += LogToConsole;
            Logs += LogToFile;
            Logs += LogToMemory;
        }
        public void ChamarLogs(string mensagem)
        {
            Logs?.Invoke(mensagem);
        }
    }
}
