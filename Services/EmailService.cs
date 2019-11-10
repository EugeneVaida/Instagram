using MailKit.Net.Smtp;
using MimeKit;
using System.Threading.Tasks;

namespace Instagram.Services
{
    public class EmailService
    {
        public async Task SendEmailAsync(string email, string subject, string message)
        {
            // TODO: Вынести в конфиг
            var emailMessage = new MimeMessage();

            emailMessage.From.Add(new MailboxAddress("Администрация сайта", "instagram120@yandex.ru"));
            emailMessage.To.Add(new MailboxAddress("Email confirmation", email));
            emailMessage.Subject = subject;
            emailMessage.Body = new TextPart(MimeKit.Text.TextFormat.Html)
            {
                Text = message
            };
            
            using (var client = new SmtpClient())
            {
                await client.ConnectAsync("smtp.yandex.ru", 587, false).ConfigureAwait(true);
                await client.AuthenticateAsync("instagram120@yandex.ru", "WYu-dym-xd4-bYs").ConfigureAwait(true);
                await client.SendAsync(emailMessage).ConfigureAwait(true);

                await client.DisconnectAsync(true).ConfigureAwait(true);
            }
        }
    }
}
