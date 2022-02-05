using System.Net;
using System.Net.Mail;

namespace GestionCommndesNaza.utils
{
    class EmailSender
    {
        private static string password = "Azerty90@#";
        private static string adresseMail = "dansomon.projects@gmail.com";
        private static SmtpClient smtpServer = new SmtpClient("smtp.gmail.com");
        private static MailAddress fromAddress = new MailAddress(adresseMail, "AGOE CSHARP");
        private static string fromPassword = EmailSender.password;
        private static SmtpClient smtp = new SmtpClient
        {
            Host = "smtp.gmail.com",
            Port = 587,
            EnableSsl = true,
            DeliveryMethod = SmtpDeliveryMethod.Network,
            UseDefaultCredentials = false,
            Credentials = new NetworkCredential(fromAddress.Address, fromPassword),
            Timeout = 20000
        };


        public static void sendEmailWitFile(string sendToMail, string nom, string subject, string body, string file)
        {
            var toAddress = new MailAddress(sendToMail, nom);
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
            })
            {
                smtp.Send(message);
            }
        }

        public static void SendMail(string sendToMail, string nom, string subject, string body)
        {
            var toAddress = new MailAddress(sendToMail, nom);
            using (var message = new MailMessage(fromAddress, toAddress)
            {
                Subject = subject,
                Body = body,
            })
            {
                smtp.Send(message);
            }
        }
    }
}
