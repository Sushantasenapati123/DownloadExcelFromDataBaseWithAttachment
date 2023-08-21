using MailKit.Security;
using Microsoft.Extensions.Options;
using MimeKit;
using Exam.Domain.Email;
using System.IO;
using System.Threading.Tasks;
using Exam.IRepository.Email;
using System.Net.Mail;

namespace Exam.Repository.Email
{
    public class MailService : IMailService
    {
        private readonly MailSettings _mailSettings;
        public MailService(IOptions<MailSettings> mailSettings)
        {
            _mailSettings = mailSettings.Value;
        }
        public async Task SendEmailAsync(MailRequest mailRequest)
        {
            //mailRequest.Attachment = Microsoft.AspNetCore.Http.FormFile;
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = mailRequest.Body;

            if (mailRequest.Attachment != null && mailRequest.Attachment.Length > 0)
            {
                using (var ms = new MemoryStream())
                {
                    await mailRequest.Attachment.CopyToAsync(ms);
                    var fileBytes = ms.ToArray();
                    builder.Attachments.Add(mailRequest.Attachment.FileName, fileBytes, ContentType.Parse(mailRequest.Attachment.ContentType));
                }
            }


            email.Body = builder.ToMessageBody();
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }

        public async Task SendEmailAsyncFromAPath(MailRequest mailRequest)
        {
            var email = new MimeMessage();
            email.Sender = MailboxAddress.Parse(_mailSettings.Mail);
            email.To.Add(MailboxAddress.Parse(mailRequest.ToEmail));
            email.Subject = mailRequest.Subject;

            var builder = new BodyBuilder();
            builder.HtmlBody = mailRequest.Body;

            if (mailRequest.AttachmentBytes != null && mailRequest.AttachmentBytes.Length > 0)
            {
                using (var ms = new MemoryStream(mailRequest.AttachmentBytes))
                {
                    var fileBytes = ms.ToArray();
                    builder.Attachments.Add("pro1.jpg", fileBytes, ContentType.Parse("image/jpeg"));
                }
            }

            email.Body = builder.ToMessageBody();
            using var smtp = new MailKit.Net.Smtp.SmtpClient();
            smtp.Connect(_mailSettings.Host, _mailSettings.Port, SecureSocketOptions.StartTls);
            smtp.Authenticate(_mailSettings.Mail, _mailSettings.Password);
            await smtp.SendAsync(email);
            smtp.Disconnect(true);
        }
    }
}
