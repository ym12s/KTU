using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;
using Khanq.Controller;
using Khanq.Model;
using System.Drawing;

namespace Khanq.View
{
    public partial class AI : Form
    {
        private static readonly string apiKey = "AIzaSyCiE2TT9z3YwaK5v5bFtsuD9Mj1hiH0n4s"; // Thay thế với API Key của bạn
        private static readonly string apiUrl = "https://generativelanguage.googleapis.com/v1beta/models/gemini-1.5-flash:generateContent"; // Thay URL API chính xác ở đây

        public AI()
        {
            InitializeComponent();
        }

        private void btnTIm_Click(object sender, EventArgs e)
        {
           
        }

        private async void khangButton1_Click(object sender, EventArgs e)
        {
            khangTextBox1.Text = "";
            string userMessage = txtNhap.Text; 

            string response = await CallGoogleAIAPI(userMessage);
            await ShowMessageWithEffect("AI: " + response, Color.Magenta);
            await ShowMessageWithEffect("Theo dõi Facebook của Khang tại: https://www.facebook.com/nilah.2004", Color.Magenta);
        }

        private async Task<string> CallGoogleAIAPI(string prompt)
        {
            using (var client = new HttpClient())
            {
                var jsonData = new
                {
                    contents = new[]
                    {
                new
                {
                    parts = new[]
                    {
                        new { text = prompt }
                    }
                }
            }
                };

                var jsonString = JsonConvert.SerializeObject(jsonData);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");

                string urlWithApiKey = $"{apiUrl}?key={apiKey}"; 

                try
                {
                    HttpResponseMessage response = await client.PostAsync(urlWithApiKey, content);

                    if (response.IsSuccessStatusCode)
                    {
                        string responseContent = await response.Content.ReadAsStringAsync();
                        var resultObj = JsonConvert.DeserializeObject<dynamic>(responseContent);

                        if (resultObj?.candidates != null && resultObj.candidates.Count > 0)
                        {
                            var textResponse = resultObj.candidates[0]?.content?.parts[0]?.text?.ToString();
                            if (!string.IsNullOrEmpty(textResponse))
                            {
                                textResponse = textResponse.Replace("Google", "Khang");

                                return textResponse;
                            }
                            else
                            {
                                return "No valid response text found.";
                            }
                        }
                        else
                        {
                            return "No valid candidates found in the response.";
                        }
                    }
                    else
                    {
                        string errorResponse = await response.Content.ReadAsStringAsync();
                        return $"API call failed. Status Code: {response.StatusCode}. Error: {errorResponse}";
                    }
                }
                catch (Exception ex)
                {
                    return $"Exception occurred: {ex.Message}";
                }
            }
        }
        private async Task ShowMessageWithEffect(string message, Color color)
        {
            foreach (char c in message)
            {
                khangTextBox1.ForeColor = color;
                khangTextBox1.AppendText(c.ToString());
                await Task.Delay(1); 
                khangTextBox1.ScrollToCaret();
            }
            khangTextBox1.AppendText(Environment.NewLine);
        }
    }
}
