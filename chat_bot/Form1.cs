using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace chat_bot
{
    public partial class Form1 : Form
    {
        private const string OpenRouterApiUrl = "https://openrouter.ai/api/v1/chat/completions";
       
        private string OpenRouterKey = "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";

        public Form1()
        {
            InitializeComponent();
            this.AcceptButton = btnGonder;
            txtKonusmaGecmisi.ReadOnly = true;

            GecmiseEkle("Chatbot", "Merhaba! İstediğin konuda konuşmaya hazırım :)");
        }

        private async void btnGonder_Click(object sender, EventArgs e)
        {
            await SendMessage();
        }

        private async Task SendMessage()
        {
            string userInput = txtKullaniciGirdisi.Text?.Trim();
            if (string.IsNullOrEmpty(userInput)) return;

            GecmiseEkle("Kullanıcı", userInput);
            txtKullaniciGirdisi.Clear();

            btnGonder.Enabled = false;
            txtKullaniciGirdisi.Enabled = false;

            try
            {
                GecmiseEkle("Chatbot", "Düşünüyorum ...");

                string response = await GetChatResponse(userInput);

                TemizleSonGecmisMesaji("Cevap arıyorum ...");

                if (!string.IsNullOrEmpty(response))
                {
                    GecmiseEkle("Chatbot", response);
                }
                else
                {
                    GecmiseEkle("Hata", "API boş cevap döndü.");
                }
            }
            catch (Exception ex)
            {
                TemizleSonGecmisMesaji("... yanıt aranıyor ...");
                GecmiseEkle("Hata", $"API hatası: {ex.Message}");
            }
            finally
            {
                btnGonder.Enabled = true;
                txtKullaniciGirdisi.Enabled = true;
                txtKullaniciGirdisi.Focus();

                txtKonusmaGecmisi.SelectionStart = txtKonusmaGecmisi.Text.Length;
                txtKonusmaGecmisi.ScrollToCaret();
            }
        }

        private async Task<string> GetChatResponse(string userMessage)
        {
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", OpenRouterKey);

                var payload = new
                {
                    model = "gpt-3.5-turbo", 
                    messages = new[]
                    {
                        new { role = "system", content = "Sen, C# ve .NET konularında kısa ve net cevap veren bir asistsansın." },
                        new { role = "user", content = userMessage }
                    },
                    max_tokens = 800,
                    temperature = 0.2
                };

                string json = JsonConvert.SerializeObject(payload);
                using (var content = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    var httpResponse = await client.PostAsync(OpenRouterApiUrl, content);
                    string respText = await httpResponse.Content.ReadAsStringAsync();

                    if (!httpResponse.IsSuccessStatusCode)
                    {
                        throw new Exception($"HTTP {(int)httpResponse.StatusCode} - {httpResponse.ReasonPhrase}: {respText}");
                    }

                    dynamic data = JsonConvert.DeserializeObject(respText);

                    try
                    {
                        var choice = data?.choices?[0];
                        var message = choice?.message;
                        var contentText = message?.content?.ToString();
                        return contentText?.Trim();
                    }
                    catch
                    {
                        return null;
                    }
                }
            }
        }

        private void GecmiseEkle(string kimden, string mesaj)
        {
            txtKonusmaGecmisi.AppendText($"\r\n[{DateTime.Now:HH:mm}] {kimden}: {mesaj}");
        }

        private void TemizleSonGecmisMesaji(string silinecekMesaj)
        {
            var lines = txtKonusmaGecmisi.Lines;
            if (lines.Length == 0) return;
            string last = lines[lines.Length - 1];
            if (last.Contains(silinecekMesaj))
            {
                Array.Resize(ref lines, lines.Length - 1);
                txtKonusmaGecmisi.Lines = lines;
            }
        }
    }
}
