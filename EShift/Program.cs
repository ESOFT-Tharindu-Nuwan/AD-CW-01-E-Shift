using EShift.Business.Interface;
using EShift.Business.Service;
using EShift.Forms;
using Microsoft.Extensions.Configuration;

namespace EShift
{
    internal static class Program
    {
        public static IConfiguration? Configuration { get; private set; }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            Configuration = builder.Build();
            ApplicationConfiguration.Initialize();

            IEmailService emailService = new EmailService(Configuration);

            //using (SplashScreen splashForm = new SplashScreen())
            //{
            //    splashForm.ShowDialog();
            //}

            Application.Run(new AdminDashboardForm(3, emailService));
        }
    }
}