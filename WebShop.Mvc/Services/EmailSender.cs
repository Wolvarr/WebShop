using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Options;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace WebShop.Mvc.Services
{
    public class EmailSender : IEmailSender
    {
        private readonly IOptions<EmailSettings> appSetting;

        public EmailSender(IOptions<EmailSettings> app)
        {
            this.appSetting = app;
        }

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            //saját használatban lévő emailcímemmel teszteltem, így a feltöltéshez ezt ki kellett vennnem
            var fromAddress = new MailAddress(appSetting.Value.FromAddres, "QuickShopWebáruház");
            var toAddress = new MailAddress(email);

            var smtp = new SmtpClient
            {
                Host = appSetting.Value.Server,
                Port = Int32.Parse(appSetting.Value.Port),
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(appSetting.Value.FromAddres, appSetting.Value.Password)
            };
       
            using (var mmessage = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = message
            })
            {
                try
                {
                    smtp.Send(mmessage);
                }
                catch (Exception e)
                {
                    System.Console.WriteLine(e);
                }
            }
        }
    }
}