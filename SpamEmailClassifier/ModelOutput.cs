using Microsoft.ML.Data;

namespace SpamEmailClassifier
{
    public class ModelOutput
    {
        [ColumnName("PredictedLabel")]
        public bool IsSpam { get; set; }

        [ColumnName("Probability")]
        public float Probability { get; set; }

        [ColumnName("Score")]
        public float Score { get; set; }
    }
}