using EShift.Business.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;
using Microsoft.Extensions.Configuration;

namespace EShift.Business.Service
{
    public class EmailService : IEmailService
    {
        private readonly IConfiguration _configuration;

        private readonly string smtpHost = "sandbox.smtp.mailtrap.io"; 
        private readonly int smtpPort = 2525;
        private readonly string smtpUsername = "a4e9b0481f007a";
        private readonly string smtpPassword = "a5777d4c31c008";
        private readonly string senderEmail = "no-reply@eshift.com";
        private readonly string senderName = "EShift Transport";

        public EmailService()
        {
        }

        public EmailService(IConfiguration configuration)
        {
            _configuration = configuration;

            // Optional: You can still add a basic check for missing settings if desired
            if (string.IsNullOrEmpty(_configuration["EmailSettings:SmtpHost"]) ||
                string.IsNullOrEmpty(_configuration["EmailSettings:SmtpUsername"]) ||
                string.IsNullOrEmpty(_configuration["EmailSettings:SmtpPassword"]) ||
                string.IsNullOrEmpty(_configuration["EmailSettings:SenderEmail"]))
            {
                throw new ArgumentNullException("Email settings are incomplete in appsettings.json. Check EmailSettings section.");
            }
        }

        public async Task SendEmailAsync(string toEmail, string subject, string body, string toName = null)
        {
            // Read settings directly from IConfiguration
            //string smtpHost = _configuration["EmailSettings:SmtpHost"];
            //int smtpPort = 2525;
            //string smtpUsername = _configuration["EmailSettings:SmtpUsername"];
            //string smtpPassword = _configuration["EmailSettings:SmtpPassword"];
            //string senderEmail = _configuration["EmailSettings:SenderEmail"];
            //string senderName = _configuration["EmailSettings:SenderName"];

            using (var message = new MailMessage())
            {
                message.From = new MailAddress(senderEmail, senderName);
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

                using (var smtpClient = new SmtpClient(smtpHost, smtpPort))
                {
                    //smtpClient.EnableSsl = smtpEnableSsl;
                    smtpClient.Credentials = new NetworkCredential(smtpUsername, smtpPassword);
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;

                    try
                    {
                        await smtpClient.SendMailAsync(message);
                        Console.WriteLine($"Email sent to {toEmail} successfully via Mailtrap.");
                    }
                    catch (SmtpException smtpEx)
                    {
                        Console.WriteLine($"SMTP Error sending email to {toEmail}: {smtpEx.StatusCode} - {smtpEx.Message}");
                        throw new ApplicationException($"SMTP Error sending email to {toEmail}: {smtpEx.StatusCode} - {smtpEx.Message}", smtpEx);
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"General Error sending email to {toEmail}: {ex.Message}");
                        throw new ApplicationException($"General Error sending email to {toEmail}: {ex.Message}", ex);
                    }
                }
            }
        }
    }
}
