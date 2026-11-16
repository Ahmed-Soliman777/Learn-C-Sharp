namespace TextDataAnalyer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("***************************");
            Console.WriteLine("Welcome to File analyzer");
            Console.WriteLine("Please enter folder path to analyze");
            Console.WriteLine("***************************");

            string inputFolder = Console.ReadLine()!;

            DirectoryInfo directoryInfo = new DirectoryInfo(inputFolder);

            if (directoryInfo.Exists == false)
            {
                Console.WriteLine("Folder doesn\'t exist");
                return;
            }

            var fileNames = directoryInfo.GetFiles();

            IFileAnalysis fileAnalysis = null;

            foreach (var file in fileNames)
            {
                if (file.IsTextFile())
                {
                    fileAnalysis = new TextFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalysis).GetResults();

                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Word count : {results.WordCount}");
                    Console.WriteLine($"Character count : {results.CharacterCount}");
                    Console.WriteLine($"Line count : {results.LineCount}");
                }
                else if (file.IsCSVFile())
                {
                    fileAnalysis = new CSVFileAnalyzer();
                    fileAnalysis.AnalyzeFile(file);

                    var results = ((FileAnalyzer)fileAnalysis).GetResults();

                    Console.WriteLine($"File name : {file.Name}");
                    Console.WriteLine($"Field count : {results.FieldCount}");
                }
            }
        }
    }
}