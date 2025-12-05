using Microsoft.ML.Data;

namespace SpamEmailClassifier
{
    public class ModelInput
    {
        [LoadColumn(0)]
        public string Text { get; set; }

        [LoadColumn(1), ColumnName("Label")]
        public bool IsSpam { get; set; }
    }
}