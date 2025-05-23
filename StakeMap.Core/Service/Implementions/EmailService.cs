using System.Net;
using System.Net.Mail;
using StakeMap.Core.Service.Abstracts;
using StakeMap.Infrastructure.Helper;
using SmtpClient = System.Net.Mail.SmtpClient;

namespace StakeMap.Core.Service.Implementions
{
    public class EmailService : IEmailService
    {
        #region Fields
        private readonly EmailSettings _emailSettings;
        #endregion

        #region Constructure
        public EmailService(EmailSettings emailSettings)
        {
            _emailSettings = emailSettings;
        }

        #endregion

        #region Handle Function

        public async Task SendEmail(string receptor, string subject, string body)
        {


            var smtpClient = new SmtpClient(_emailSettings.Host, _emailSettings.Port);
            smtpClient.EnableSsl = true;
            smtpClient.UseDefaultCredentials = false;
            smtpClient.Credentials = new NetworkCredential(_emailSettings.Email, _emailSettings.Password);

            var message = new MailMessage(_emailSettings.Email, receptor, subject, body);
            await smtpClient.SendMailAsync(message);
        }

        #endregion
    }
}
