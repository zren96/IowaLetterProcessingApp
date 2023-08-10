 namespace IowaLetterProcessingApp
 {   
    public class Logger
    {  
        public string LogFilePath {get; set;}

        public void WriteLine(string message)
        {
            Console.WriteLine(message);
            System.IO.File.AppendAllText(LogFilePath, message + "\n");
        }
    }
}