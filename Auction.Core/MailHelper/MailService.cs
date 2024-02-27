using MailKit.Net.Smtp;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Auction.Core.MailHelper
{
    public class MailService : IMailService
    {
        public void SendMail(string subject, string body, string email)
        {
			try
			{
				var emailToSent = new MimeMessage();
				emailToSent.From.Add(MailboxAddress.Parse("YourGalaxyAuction@gmail.com"));
				emailToSent.To.Add(MailboxAddress.Parse(email));
				emailToSent.Subject = subject;
				emailToSent.Body = new TextPart(MimeKit.Text.TextFormat.Html) { Text = body };

				// send mail

				using var emailClient = new MailKit.Net.Smtp.SmtpClient();
				emailClient.Connect("smtp.gmail.com", 587, MailKit.Security.SecureSocketOptions.StartTls);
				emailClient.Authenticate("gurbuzysn@gmail.com", "qteofygtusadxzxv");
				emailClient.Send(emailToSent);
				emailClient.Disconnect(true);

			}
			catch (Exception ex)
			{

				throw ex;
			}
        }
    }
}
