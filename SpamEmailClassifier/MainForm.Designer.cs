namespace SpamEmailClassifier
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtEmailContent = new System.Windows.Forms.TextBox();
            this.lblEmailContent = new System.Windows.Forms.Label();
            this.btnClassify = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.panelResult = new System.Windows.Forms.Panel();
            this.lblProbability = new System.Windows.Forms.Label();
            this.lblResultText = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRetrain = new System.Windows.Forms.Button();
            this.lblInstructions = new System.Windows.Forms.Label();
            this.panelResult.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(346, 30);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Spam/Ham E-posta Sınıflandırma";
            // 
            // txtEmailContent
            // 
            this.txtEmailContent.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtEmailContent.Location = new System.Drawing.Point(25, 120);
            this.txtEmailContent.Multiline = true;
            this.txtEmailContent.Name = "txtEmailContent";
            this.txtEmailContent.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtEmailContent.Size = new System.Drawing.Size(450, 150);
            this.txtEmailContent.TabIndex = 1;
            this.txtEmailContent.Text = "Merhaba, toplantı yarın saat 14:00\'te olacak.";
            // 
            // lblEmailContent
            // 
            this.lblEmailContent.AutoSize = true;
            this.lblEmailContent.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblEmailContent.Location = new System.Drawing.Point(21, 97);
            this.lblEmailContent.Name = "lblEmailContent";
            this.lblEmailContent.Size = new System.Drawing.Size(103, 19);
            this.lblEmailContent.TabIndex = 2;
            this.lblEmailContent.Text = "E-posta Metni:";
            // 
            // btnClassify
            // 
            this.btnClassify.BackColor = System.Drawing.Color.SteelBlue;
            this.btnClassify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClassify.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClassify.ForeColor = System.Drawing.Color.White;
            this.btnClassify.Location = new System.Drawing.Point(25, 285);
            this.btnClassify.Name = "btnClassify";
            this.btnClassify.Size = new System.Drawing.Size(150, 40);
            this.btnClassify.TabIndex = 3;
            this.btnClassify.Text = "Sınıflandır";
            this.btnClassify.UseVisualStyleBackColor = false;
            this.btnClassify.Click += new System.EventHandler(this.btnClassify_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblResult.Location = new System.Drawing.Point(21, 350);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(58, 19);
            this.lblResult.TabIndex = 4;
            this.lblResult.Text = "Sonuç:";
            // 
            // panelResult
            // 
            this.panelResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panelResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelResult.Controls.Add(this.lblProbability);
            this.panelResult.Controls.Add(this.lblResultText);
            this.panelResult.Location = new System.Drawing.Point(25, 375);
            this.panelResult.Name = "panelResult";
            this.panelResult.Size = new System.Drawing.Size(450, 80);
            this.panelResult.TabIndex = 5;
            // 
            // lblProbability
            // 
            this.lblProbability.AutoSize = true;
            this.lblProbability.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProbability.Location = new System.Drawing.Point(15, 40);
            this.lblProbability.Name = "lblProbability";
            this.lblProbability.Size = new System.Drawing.Size(161, 15);
            this.lblProbability.TabIndex = 1;
            this.lblProbability.Text = "Tahmin Olasılığı: %0.00";
            // 
            // lblResultText
            // 
            this.lblResultText.AutoSize = true;
            this.lblResultText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultText.Location = new System.Drawing.Point(15, 15);
            this.lblResultText.Name = "lblResultText";
            this.lblResultText.Size = new System.Drawing.Size(154, 21);
            this.lblResultText.TabIndex = 0;
            this.lblResultText.Text = "Sonuç bekleniyor...";
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClear.Location = new System.Drawing.Point(190, 285);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 40);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Temizle";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRetrain
            // 
            this.btnRetrain.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRetrain.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRetrain.Location = new System.Drawing.Point(375, 285);
            this.btnRetrain.Name = "btnRetrain";
            this.btnRetrain.Size = new System.Drawing.Size(100, 40);
            this.btnRetrain.TabIndex = 7;
            this.btnRetrain.Text = "Modeli Yeniden Eğit";
            this.btnRetrain.UseVisualStyleBackColor = true;
            this.btnRetrain.Click += new System.EventHandler(this.btnRetrain_Click);
            // 
            // lblInstructions
            // 
            this.lblInstructions.AutoSize = true;
            this.lblInstructions.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblInstructions.ForeColor = System.Drawing.Color.Gray;
            this.lblInstructions.Location = new System.Drawing.Point(22, 60);
            this.lblInstructions.Name = "lblInstructions";
            this.lblInstructions.Size = new System.Drawing.Size(430, 30);
            this.lblInstructions.TabIndex = 8;
            this.lblInstructions.Text = "E-posta metnini aşağıdaki kutuya yapıştırın ve \"Sınıflandır\" butonuna tıklayın.\r\nS" +
    "istem metnin spam veya normal (ham) olup olmadığını tahmin edecektir.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 480);
            this.Controls.Add(this.lblInstructions);
            this.Controls.Add(this.btnRetrain);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.panelResult);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClassify);
            this.Controls.Add(this.lblEmailContent);
            this.Controls.Add(this.txtEmailContent);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Spam/Ham E-posta Sınıflandırıcı";
            this.panelResult.ResumeLayout(false);
            this.panelResult.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtEmailContent;
        private System.Windows.Forms.Label lblEmailContent;
        private System.Windows.Forms.Button btnClassify;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Panel panelResult;
        private System.Windows.Forms.Label lblResultText;
        private System.Windows.Forms.Label lblProbability;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRetrain;
        private System.Windows.Forms.Label lblInstructions;
    }
}