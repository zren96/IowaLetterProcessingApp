namespace IowaLetterProcessingApp
{
    public interface ILetterService
    {
        void FileGenerator(string sourceDirectory);
        void ArchiveFiles(string sourceDirectory, string archiveDirectory);
        List<string> CombineLetters(string sourceDirectory, string outputDirectory);
    }
}