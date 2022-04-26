using FacturacionApi.Common.Helper;
using FacturacionApi.Common.Setting;
using FacturacionApi.Interface.Helper;
using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json;
using System.Text;
using System.Net.Security;
using System.Net.Http;
using System.Linq;
using NLog;
using System.Collections.Generic;

namespace FacturacionApi.Utility.Helper
{
    public class EmailSender : IEmailSender
    {
        private readonly EmailSettings emailSettings;
        private readonly Logger logger = LogManager.GetCurrentClassLogger();
        public EmailSender(EmailSettings emailSettings)
        {
            this.emailSettings = emailSettings;
        }

        public void SendEmail(MessageDto message)
        {
            var jsonData = this.CreateEmailMessage(message);
            _ = this.SendAsync(jsonData);
        }

        private string CreateEmailMessage(MessageDto message)
        {
            var jsonData = JsonSerializer.Serialize(new
            {
                From = emailSettings.From,
                To = string.Join(';', message.To.Select(s => s.Key).ToList()),
                Subject = message.Subject,
                Body = message.Content,
                Attachments = new List<object>()
            }); 

            return jsonData;
        }

        private async System.Threading.Tasks.Task SendAsync(string jsonData)
        {
            try
            {
                var client = new HttpClient();
                HttpResponseMessage result = await client.PostAsync(emailSettings.LogicAppURL, new StringContent(jsonData, Encoding.UTF8, "application/json"));
                var statusCode = result.StatusCode.ToString();
            }
            catch (Exception ex)
            {
                logger.Error(ex.ToString());
            }
        }
        
    }
}
