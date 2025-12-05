using SpamEmailClassifier;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SpamEmailClassifier
{
    public partial class MainForm : Form
    {
        private SpamDetectionML _spamDetector;

        public MainForm()
        {
            InitializeComponent();
            _spamDetector = new SpamDetectionML();
            UpdateResultDisplay("Sonuç bekleniyor...", Color.Gray, "%0.00");
        }

        private void btnClassify_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmailContent.Text))
            {
                MessageBox.Show("Lütfen e-posta metnini girin.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Tahmin yap
                var prediction = _spamDetector.Predict(txtEmailContent.Text);

                // Sonucu ekranda göster
                string resultText = prediction.IsSpam ? "SPAM E-POSTA" : "NORMAL E-POSTA";
                Color resultColor = prediction.IsSpam ? Color.Red : Color.Green;
                string probability = $"{(prediction.Probability * 100):F2}";

                UpdateResultDisplay(resultText, resultColor, probability);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateResultDisplay(string text, Color color, string probability)
        {
            lblResultText.Text = text;
            lblResultText.ForeColor = color;
            lblProbability.Text = $"Tahmin Olasılığı: %{probability}";

            // Panel arkaplan rengini de güncelle
            panelResult.BackColor = color == Color.Red ?
                Color.FromArgb(255, 240, 240) :
                Color.FromArgb(240, 255, 240);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtEmailContent.Clear();
            UpdateResultDisplay("Sonuç bekleniyor...", Color.Gray, "0.00");
            txtEmailContent.Focus();
        }

        private void btnRetrain_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;

                // Modeli yeniden eğit
                _spamDetector.RetrainModel();

                Cursor = Cursors.Default;
                MessageBox.Show("Model başarıyla yeniden eğitildi.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show($"Model eğitme hatası: {ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtEmailContent_KeyDown(object sender, KeyEventArgs e)
        {
            // Ctrl+Enter ile sınıflandırma yapma kısayolu
            if (e.Control && e.KeyCode == Keys.Enter)
            {
                btnClassify_Click(sender, e);
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}