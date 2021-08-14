using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Observer
{
    public class SendMail
    {
        public static MainWindow MainWindow { get; set; }

        public static void SendMailMessage(string name)
        {
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("hhhmmmstepit@gmail.com", "0775966907m"),
                EnableSsl = true,
            };

            smtpClient.Send("hhhmmmstepit@gmail.com", name, "Information", $"Salam.Yeni {MainWindow.ProductTextBox.Text} geldi.");
        }
    }
}