**Admission and scholarship letters processing**

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

Scheduling related issues:
1. The current letter combination logics is to combine the letters for all dates. We can change this configuration to only check and combine letters on the current date. So if a person accidentally runs the app before or after the scheduled time, the results won't change. However, if the app is configured to only check and combine letters on the current date, running the app before or after today will lose today's combined letters. But since we do have archived files, it is safe to do a backfill later.
2. Same as above, if the app is configured to only check and combine letters on the current date, and if the app wasn't run previous day but runs today, the the combined letter will only come from today.


Hours worked:

Estimated time were 2 hours. Completing the main functionalities takes 1.5 hours and minor improvements take another 1 hour.

Assumptions:
1. There's no permission issue on the related folders and files.
2. All files are in `.txt` format.
3. The size of a letter file is within a reasonable range. No large files.
4. A student that has been admitted or offered scholarship won't be addmitted or offered scholarship again.








