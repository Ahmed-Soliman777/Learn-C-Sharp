namespace TextDataAnalyer
{
    public class FileAnalyzer
    {
        private AnalysisResults _results;

        public AnalysisResults GetResults()
        {
            return _results;
        }

        public void SetResults(AnalysisResults results)
        {
            _results = results;
        }
    }
}