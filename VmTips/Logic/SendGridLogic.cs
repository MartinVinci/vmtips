using SendGrid;
using SendGrid.Helpers.Mail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace VmTips.Logic
{
    public class SendGridLogic
    {
        public static void SendEmail()
        {
            try
            {
                Execute().Wait();

                var hej = 2;
            }
            catch(Exception ex)
            {

            }
            ////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
            //string key = @"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";


            //var apiKey = Environment.GetEnvironmentVariable(key);
            //    var client = new SendGridClient(apiKey);
            //    var from = new EmailAddress("vmtips2018@gmail.com", "Kalle Svensson");
            //    var subject = "Din rad";
            //    var to = new EmailAddress("martin.nordkvist@zoho.com", "Example User");
            //    var plainTextContent = "Lite text vad det nu kan vara";
            //    var htmlContent = "<strong>and easy to do anywhere, even with C#</strong>";
            //    var msg = MailHelper.CreateSingleEmail(from, to, subject, plainTextContent, htmlContent);
            //    var response = client.SendEmailAsync(msg);
            }

        static async Task Execute()
        {
            var apiKey = System.Environment.GetEnvironmentVariable("SENDGRID_APIKEY");
            var client = new SendGridClient(apiKey);
            var msg = new SendGridMessage()
            {
                From = new EmailAddress("vmtips2018@gmail.com", "Kalle Svensson"),
                Subject = "Hello World from the SendGrid CSharp SDK!",
                PlainTextContent = "Hello, Email!",
                HtmlContent = "<strong>Hello, Email!</strong>"
            };
            msg.AddTo(new EmailAddress("martin.nordvist@zoho.com", "Adam Andersson"));
            
            var response = await client.SendEmailAsync(msg);
        }
    }
}