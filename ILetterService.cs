namespace IowaLetterProcessingApp
{
    public interface ILetterService
    {
        void FileGenerator(string sourceDirectory);
        void ArchiveFiles(string sourceDirectory, string archiveDirectory);
    }
}