using System.Collections.Generic;

namespace SpamEmailClassifier
{
    public class EmailData
    {
        public string Text { get; set; }
        public bool IsSpam { get; set; }

        // Eğitim için örnek veri oluşturma (gerçek uygulamada veritabanından gelir)
        public static List<EmailData> GetSampleData()
        {
            return new List<EmailData>
            {
                          new EmailData { Text = "Kazanmak için hemen tıklayın! Bedava iPhone kazanma şansı!", IsSpam = true },
            new EmailData { Text = "Sınırlı teklif! Kredi kartı numaranızı girin ve büyük ödülü kazanın.", IsSpam = true },
            new EmailData { Text = "Büyük ödül kazandınız! Detaylar için tıklayın ve ödülünüzü alın.", IsSpam = true },
            new EmailData { Text = "Paranızı 3 ayda katlayın! Yatırım fırsatı kaçırılmayacak.", IsSpam = true },
            new EmailData { Text = "Ücretsiz tatil kazandınız! Rezervasyon için hemen arayın.", IsSpam = true },
            new EmailData { Text = "Bankanızdan acil mesaj: Hesabınız askıya alındı. Giriş yapın.", IsSpam = true },
            new EmailData { Text = "Milyoner olmak ister misiniz? Bu sistemle herkes zengin oluyor!", IsSpam = true },
            new EmailData { Text = "İşsizlik son! Günde 2 saat çalış, ayda 20.000 TL kazan!", IsSpam = true },
            new EmailData { Text = "Banka kredisi onaylandı! %0,99 faiz ile hemen başvurun.", IsSpam = true },
            new EmailData { Text = "WhatsApp'tan mesajınız var! Okumak için tıklayın.", IsSpam = true },
            new EmailData { Text = "Facebook hesabınız hacklendi! Kurtarmak için şifrenizi girin.", IsSpam = true },
            new EmailData { Text = "Garanti Bankası müşterisi: 5.000 TL bonus kazandınız!", IsSpam = true },
            new EmailData { Text = "Netflix hesabınız askıya alındı. Bilgilerinizi güncelleyin.", IsSpam = true },
            new EmailData { Text = "Amazon'dan siparişiniz: Ödemeniz gerekiyor. Tıklayın.", IsSpam = true },
            new EmailData { Text = "Bitcoin yatırımı ile haftada %50 kazanç! Şimdi başlayın.", IsSpam = true },
            new EmailData { Text = "Üniversite diploması alın! Sınavsız, evden eğitim.", IsSpam = true },
            new EmailData { Text = "Kilo vermenin sırrı! Bu hap ile ayda 15 kg verin.", IsSpam = true },
            
            // NORMAL (HAM) Örnekleri (20 adet)
            new EmailData { Text = "Merhaba Ayşe, toplantı yarın saat 14:00'te konferans salonunda olacak.", IsSpam = false },
            new EmailData { Text = "Proje raporunu gönderdim, kontrol edebilir misin? Ekte dosya mevcut.", IsSpam = false },
            new EmailData { Text = "Hafta sonu için plan yapalım mı? Sinema veya yemeğe gidelim.", IsSpam = false },
            new EmailData { Text = "Dokümanları ekte bulabilirsiniz. İnceleyip geri bildirim verir misiniz?", IsSpam = false },
            new EmailData { Text = "Toplantı notları ektedir, bilgilerinize. Pazartesi görüşmek üzere.", IsSpam = false },
            new EmailData { Text = "Doğum günün kutlu olsun! Akşam yemeğe bekliyorum.", IsSpam = false },
            new EmailData { Text = "Fatura ödeme hatırlatması: Elektrik faturanız 15 Ocak'ta sonra eriyor.", IsSpam = false },
            new EmailData { Text = "Uçuş bilgileriniz: İstanbul-Ankara, 20 Ocak, 08:00, TK1234.", IsSpam = false },
            new EmailData { Text = "Doktor randevunuz: 22 Ocak Cuma, saat 10:30, Dr. Mehmet Yılmaz.", IsSpam = false },
            new EmailData { Text = "Okul veli toplantısı 25 Ocak'ta saat 18:00'de yapılacaktır.", IsSpam = false },
            new EmailData { Text = "CV'nizi inceledik, görüşme için sizi arayacağız.", IsSpam = false },
            new EmailData { Text = "Kargo takip numaranız: PT123456789TR. Pazartesi teslim edilecek.", IsSpam = false },
            new EmailData { Text = "Maaş bordronuz ektedir. Sorunuz olursa muhasebe ile görüşün.", IsSpam = false },
            new EmailData { Text = "Aile yemeğine bekliyoruz. Cumartesi akşam 19:00'da evdeyiz.", IsSpam = false },
            new EmailData { Text = "LinkedIn bağlantı isteğinizi kabul ettim. İyi çalışmalar.", IsSpam = false },
            new EmailData { Text = "Seminer kaydınız onaylandı. 30 Ocak'ta saat 14:00'te başlıyor.", IsSpam = false },
            new EmailData { Text = "Kütüphane kitabınızın süresi 31 Ocak'ta doluyor. İade edin.", IsSpam = false },
            new EmailData { Text = "Hava durumu: Yarın yağmurlu, şemsiyenizi almayı unutmayın.", IsSpam = false },
            new EmailData { Text = "Yeni blog yazım yayında: 'Makine Öğrenimi Nedir?'", IsSpam = false },
            new EmailData { Text = "Takım toplantısı iptal edildi. Yeni tarihi size bildireceğim.", IsSpam = false }
            };
        }
    }
}