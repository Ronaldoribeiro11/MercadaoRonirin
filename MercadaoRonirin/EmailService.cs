using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Mailjet.Client;
using Mailjet.Client.Resources;
using Newtonsoft.Json.Linq;

namespace MercadaoRonirin
{
    internal class EmailService
    {
        private const string ApiKey = "674db86e118bfacd49e7f5e432fd6ef6";
        private const string ApiSecret = "3af934d3e198010c35fce6210bbd27d9";
        private const string FromEmail = "ronaldoribeiru3@gmail.com";
        private const string FromName = "Ronaldo";

        public async Task SendVerificationEmail(string recipientEmail, string verificationCode)
        {
            MailjetClient client = new MailjetClient(ApiKey, ApiSecret);

            var request = new MailjetRequest
            {
                Resource = Send.Resource,
            }
            .Property(Send.Messages, new JArray {
            new JObject {
                {
                    "From",
                    new JObject {
                        {"Email", FromEmail},
                        {"Name", FromName}
                    }
                },
                {
                    "To",
                    new JArray {
                        new JObject {
                            {"Email", recipientEmail},
                            {"Name", recipientEmail}
                        }
                    }
                },
                {"Subject", "Seu código de verificação"},
                {"TextPart", $"Seu código de verificação é {verificationCode}"},
                {"HTMLPart", $"<h3>Seu código de verificação é {verificationCode}</h3>"}
            }
            });

            MailjetResponse response = await client.PostAsync(request);

            if (response.IsSuccessStatusCode)
            {
                Console.WriteLine("Email enviado com sucesso.");
            }
            else
            {
                Console.WriteLine($"Erro ao enviar email: {response.StatusCode} - {response.GetErrorMessage()}");
            }
        }
    }
}
