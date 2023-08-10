 namespace IowaLetterProcessingApp
 {   
    public class Logger
    {  
        private string LogFilePath {get; set;}

        public Logger(string logFilePath){
            LogFilePath = logFilePath;
        }

        public void WriteLine(string message)
        {
            string displayMessage = DateTime.Now.ToString() + " " + message;
            Console.WriteLine(displayMessage);
            System.IO.File.AppendAllText(LogFilePath, displayMessage + "\n");
        }
    }
}