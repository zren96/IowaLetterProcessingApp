Admission and scholarship letters processing

This application mainly provides the functionalities of processing and merging university admission letters with scholarship letters to save mailing cost.

Basic Functions:

- Archive: make a full deep copy of the input folders which contain the letters grouped by their date.
- Merge the same student's admission letter with scholarship letter.
- Create a service report with the student IDs from the previous step.

Basic Usage:

1. Clone this repository to your local machine.
2. Make sure that `.NET 7.0` is correctly installed. If not, run `dotnet new console --framework net7.0` in the terminal.
3. To start the application, run `dotnet run` in the terminal with the same path as `IowaLetterProcessingApp`. The application will generate test files in the default folder named `CombinedLetters`. 
4. You can also explicitly pass customized folder (full path or relative path to the repository) as parameter. For example, `dotnet run "../MyTestFolder/"`. Make sure that your folder contains letter files because the application won't generate dummy letter files in this case.
5. After running the application, you will be able to find log files named `${CURRENT_DATE}.log`.




