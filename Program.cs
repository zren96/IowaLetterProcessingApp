namespace IowaLetterProcessingApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            Console.WriteLine("Service running...");
            string baseDirectory = "../CombinedLetters/";
            string sourceDirectory = baseDirectory + "Input/";
            string archiveDirectory = baseDirectory + "Archive/"; 
            string outputDirectory = baseDirectory + "Output/"; 
            LetterService myService = new LetterService();
            myService.FileGenerator(sourceDirectory);
            myService.ArchiveFiles(sourceDirectory, archiveDirectory);
            List<string> studentIDs = myService.CombineLetters(sourceDirectory, outputDirectory);
            myService.CreateReport(studentIDs, outputDirectory);
            Console.WriteLine("Done.");
        } 
    }
}