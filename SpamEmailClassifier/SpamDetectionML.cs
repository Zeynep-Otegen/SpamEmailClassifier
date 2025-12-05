using Microsoft.ML;
using Microsoft.ML.Data;
using System;
using System.IO;
using System.Linq;

namespace SpamEmailClassifier
{
    public class SpamDetectionML
    {
        private MLContext _mlContext;
        private ITransformer _model;
        private string _modelPath = "spamham-model.zip";

        public SpamDetectionML()
        {
            _mlContext = new MLContext();

            // Model dosyası varsa yükle, yoksa eğit ve kaydet
            if (File.Exists(_modelPath))
            {
                LoadModel();
            }
            else
            {
                TrainAndSaveModel();
            }
        }

        private void TrainAndSaveModel()
        {
            try
            {
                // Örnek veri ile eğitim
                var trainingData = EmailData.GetSampleData();
                var dataView = _mlContext.Data.LoadFromEnumerable(trainingData);

                // Veri işleme pipeline'ı
                var dataProcessPipeline = _mlContext.Transforms.Text.FeaturizeText(
                    outputColumnName: "Features",
                    inputColumnName: nameof(EmailData.Text));

                // Eğitim algoritması
                var trainer = _mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(
                    labelColumnName: nameof(EmailData.IsSpam),
                    featureColumnName: "Features");

                var trainingPipeline = dataProcessPipeline.Append(trainer);

                // Modeli eğit
                _model = trainingPipeline.Fit(dataView);

                // Modeli kaydet
                _mlContext.Model.Save(_model, dataView.Schema, _modelPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Model eğitme hatası: {ex.Message}");
                // Basit bir model oluştur
                CreateSimpleModel();
            }
        }

        private void CreateSimpleModel()
        {
            // Basit bir model oluştur (gerçek uygulamada daha kapsamlı olmalı)
            var trainingData = EmailData.GetSampleData();
            var dataView = _mlContext.Data.LoadFromEnumerable(trainingData);

            var pipeline = _mlContext.Transforms.Text.FeaturizeText("Features", nameof(EmailData.Text))
                .Append(_mlContext.BinaryClassification.Trainers.SdcaLogisticRegression(
                    labelColumnName: nameof(EmailData.IsSpam)));

            _model = pipeline.Fit(dataView);
        }

        private void LoadModel()
        {
            try
            {
                DataViewSchema modelSchema;
                _model = _mlContext.Model.Load(_modelPath, out modelSchema);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Model yükleme hatası: {ex.Message}");
                TrainAndSaveModel();
            }
        }

        public ModelOutput Predict(string emailText)
        {
            try
            {
                // Tahmin motoru oluştur
                var predictionEngine = _mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(_model);

                // Tahmin yap
                var input = new ModelInput { Text = emailText };
                var prediction = predictionEngine.Predict(input);

                return prediction;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Tahmin hatası: {ex.Message}");
                return new ModelOutput { IsSpam = false, Probability = 0.5f };
            }
        }

        public void RetrainModel()
        {
            TrainAndSaveModel();
        }
    }
}