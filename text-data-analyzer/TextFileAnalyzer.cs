namespace TextDataAnalyer
{
    internal class TextFileAnalyzer : FileAnalyzer, IFileAnalysis
    {
        public void AnalyzeFile(FileInfo fileInfo)
        {
            string fileString = File.ReadAllText(fileInfo.FullName);

            AnalysisResults results = new AnalysisResults();

            var words = fileString.Split(new char[] { ' ', '\n', '\r' });

            var lines = fileString.Split(new char[] { '\n' });

            results.WordCount = words.Length;  

            results.CharacterCount = fileString.Length;

            results.LineCount = lines.Length;

            SetResults(results);
        }
    }
}