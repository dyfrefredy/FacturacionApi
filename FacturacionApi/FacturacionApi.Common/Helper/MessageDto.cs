using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace FacturacionApi.Common.Helper
{
    public class MessageDto
    {
        public Dictionary<string, string> To { get; set; }
        public string Subject { get; set; }

        public string Content { get; set; }

        public MessageDto(Dictionary<string, string> to, string subject, string content)
        {
            this.To = to;
            this.Subject = subject;
            this.Content = content;
        }
    }
}
