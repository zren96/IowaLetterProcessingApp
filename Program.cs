namespace IowaLetterProcessingApp
{
    class Program
    {   
        static void Main(string[] args)
        {
            string baseDirectory;
            bool needGenerate = true;
            Console.WriteLine("Service running...");
            if(args.Length == 0) {
                baseDirectory = "../CombinedLetters/";
            } else {
                baseDirectory = args[0];
                needGenerate = false;
            }
            string sourceDirectory = baseDirectory + "Input/";
            string archiveDirectory = baseDirectory + "Archive/"; 
            string outputDirectory = baseDirectory + "Output/"; 
            LetterService myService = new LetterService();
            if (needGenerate) {
                myService.FileGenerator(sourceDirectory);
            }           
            myService.ArchiveFiles(sourceDirectory, archiveDirectory);
            List<string> studentIDs = myService.CombineLetters(sourceDirectory, outputDirectory);
            myService.CreateReport(studentIDs, outputDirectory);
            Console.WriteLine("Done.");
        } 
    }
}