using FacturacionApi.Common.Dto;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FacturacionApi.Common.Helper
{
    public class TemplateHelper
    {
        public string GetTemplate(string webRoot, string templateName)
        {
            var template = File.ReadAllText(webRoot +"\\Template\\"+ templateName);
            return template;
        }

        public string SetTemplate(string template, Dictionary<string, string> templateInfo)
        {
            string templateResult = string.Empty;                       
            try
            {
                foreach (KeyValuePair<string, string> item in templateInfo)
                {
                    template = template.Replace(item.Key, item.Value);
                }

                templateResult = template;                             
            }
            catch (Exception ex)
            {
                ex.ToString();
            }

            return templateResult;
        }
    }
}
