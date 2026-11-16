namespace TextDataAnalyer
{
    internal class CSVFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string[] fileString = File.ReadAllLines(fileInfo.FullName);

            var rowElement = fileString[0].Split(',');

            AnalysisResults results = new AnalysisResults();

            results.FieldCount = rowElement.Length;

            SetResults(results);
        }
    }
}