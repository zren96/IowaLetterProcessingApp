namespace IowaLetterProcessingApp
{
    public interface ILetterService
    {
        /// <summary>
        /// Generate admission and scholarship letters.
        /// </summary>
        /// <param name="sourceDirectory">The directory that contains these generated letters</param>
        void FileGenerator(string sourceDirectory);

        /// <summary>
        /// Copy and paste the files recursively from source directory into archive directory
        /// </summary>
        /// <param name="sourceDirectory">The directory that contains original letters</param>
        /// <param name="archiveDirectory">The directory that the archived letters will be put into</param>
        void ArchiveFiles(string sourceDirectory, string archiveDirectory);

        /// <summary>
        /// Iterate though the source directory, combine a admission letter with a scholarship letter if 
        /// they share the same student ID. 
        /// </summary>
        /// <param name="sourceDirectory">The directory that contains original letters</param>
        /// <param name="outputDirectory">The directory that the combined letters will be put into</param>
        /// <returns>A list of student IDs that have both admission and scholarship</returns>
        List<string> CombineLetters(string sourceDirectory, string outputDirectory);

        /// <summary>
        /// Create a report file that contains the processing date and a list of student IDs 
        /// with both admission and scholarship.
        /// </summary>
        /// <param name="studentIDs">A list of student IDs</param>
        /// <param name="outputDirectory">The directory that the report file will be put into</param>
        void CreateReport(List<string> studentIDs, string outputDirectory);
    }
}