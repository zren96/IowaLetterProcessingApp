namespace IowaLetterProcessingApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            Logger log = new Logger();
            log.LogFilePath = DateTime.Now.ToString("yyyyMMdd") + ".log";
            string baseDirectory;
            bool needGenerate = true;
            log.WriteLine("Service running...");
            if(args.Length == 0) {
                baseDirectory = "../CombinedLetters/";
            } else {
                baseDirectory = args[0];
                needGenerate = false;
            }
            string sourceDirectory = baseDirectory + "Input/";
            string archiveDirectory = baseDirectory + "Archive/"; 
            string outputDirectory = baseDirectory + "Output/"; 
            LetterService myService = new LetterService(log);
            if (needGenerate) {
                myService.FileGenerator(sourceDirectory);
            }           
            myService.ArchiveFiles(sourceDirectory, archiveDirectory);
            List<string> studentIDs = myService.CombineLetters(sourceDirectory, outputDirectory);
            myService.CreateReport(studentIDs, outputDirectory);
            log.WriteLine("Done.");
        }
    }
}