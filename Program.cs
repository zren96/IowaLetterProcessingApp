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
            myService.CombineLetters(sourceDirectory, outputDirectory);
            Console.WriteLine("Done.");
        } 
    }
}