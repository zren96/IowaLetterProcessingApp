 namespace IowaLetterProcessingApp
 {   
    public class LetterService : ILetterService
    {        
        public void FileGenerator(string sourceDirectory){   
            // To generate different student IDs on different dates, use the combination of 
            // studentIDs prefix and date.
            string [] studentIDsPrefix = {"0012", "0013", "0014", "0015", "0016"};
            string [] studentIDsWithScholarshipPrefix = {"0013", "0014"};
            string [] dateStrings = {"20230809", "20230810", "20230811"};
            string currentFileName;
            string currentContent;
            string currentPath;
            string currentStudentID;
            // Iterate over dates and create corresponding folders and files.
            foreach (string dateString in dateStrings){
                foreach (string currentStudentIDPrefix in studentIDsPrefix){
                    currentStudentID = currentStudentIDPrefix + dateString.Substring(4);
                    currentFileName = "admission-" + currentStudentID + ".txt";
                    currentContent = "Congratulations you are admitted " + currentStudentID;
                    currentPath = sourceDirectory + "Admission/" + dateString + "/" + currentFileName;

                    Console.WriteLine("Generating " + currentPath + "...");

                    Directory.CreateDirectory(Path.GetDirectoryName(currentPath));
                    File.WriteAllText(currentPath, currentContent);
                }
                foreach (string currentStudentIDPrefix in studentIDsWithScholarshipPrefix){
                    currentStudentID = currentStudentIDPrefix + dateString.Substring(4);
                    currentFileName = "scholarship-" + currentStudentID + ".txt";
                    currentContent = "Congratulations you are offered scholarship " + currentStudentID;
                    currentPath = sourceDirectory + "Scholarship/"  + dateString + "/" + currentFileName;
                    Console.WriteLine("Generating " + currentPath + "...");
                    Directory.CreateDirectory(Path.GetDirectoryName(currentPath));
                    File.WriteAllText(currentPath, currentContent);
                }   
            }
        }

        public void ArchiveFiles(string sourceDirectory, string archiveDirectory){
            foreach (string dirPath in Directory.GetDirectories(sourceDirectory, "*", SearchOption.AllDirectories))
            {
                Directory.CreateDirectory(dirPath.Replace(sourceDirectory, archiveDirectory));
            }

            foreach (string filePath in Directory.GetFiles(sourceDirectory, "*.txt",SearchOption.AllDirectories))
            {
                Console.WriteLine("Copying " + filePath);
                File.Copy(filePath, filePath.Replace(sourceDirectory, archiveDirectory), true);
            }
        }           
            
    }
 }