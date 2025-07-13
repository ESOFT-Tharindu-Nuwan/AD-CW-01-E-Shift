using EShift.Business.Interface;
using EShift.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace EShift.Business.Service
{
    public class EmailService : IEmailService
    {
        private readonly EmailSettings _emailSettings;

        public EmailService()
        {
            _emailSettings = new EmailSettings();
        }

        public EmailService(IOptions<EmailSettings> emailSettings)
        {
            _emailSettings = emailSettings.Value;

            if (string.IsNullOrEmpty(_emailSettings.SmtpHost) || string.IsNullOrEmpty(_emailSettings.SmtpUsername) ||
                string.IsNullOrEmpty(_emailSettings.SmtpPassword) || string.IsNullOrEmpty(_emailSettings.SenderEmail))
            {
                throw new ArgumentNullException("Email settings are incomplete. Check appsettings.json.");
            }
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body, string toName = null)
        {
            using (var message = new MailMessage())
            {
                message.From = new MailAddress(_emailSettings.SenderEmail, _emailSettings.SenderName);
                if (string.IsNullOrEmpty(toName))
                {
                    message.To.Add(toEmail);
                }
                else
                {
                    message.To.Add(new MailAddress(toEmail, toName));
                }
                message.Subject = subject;
                message.Body = body;
                message.IsBodyHtml = true;

                using (var smtpClient = new SmtpClient(_emailSettings.SmtpHost, _emailSettings.SmtpPort))
                {
                    smtpClient.EnableSsl = _emailSettings.SmtpEnableSsl;
                    smtpClient.Credentials = new NetworkCredential(_emailSettings.SmtpUsername, _emailSettings.SmtpPassword);
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                    try
                    {
                        await smtpClient.SendMailAsync(message);
                        Console.WriteLine($"Email sent to {toEmail} successfully.");
                    }
                    catch (SmtpException smtpEx)
                    {
                        Console.WriteLine($"SMTP Error sending email to {toEmail}: {smtpEx.StatusCode} - {smtpEx.Message}");
                        throw new ApplicationException("SMTP Error sending email.", smtpEx);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"General Error sending email to {toEmail}: {ex.Message}");
                        throw new ApplicationException("Error sending email.", ex);
                    }
                }
            }
        }
    }
}
