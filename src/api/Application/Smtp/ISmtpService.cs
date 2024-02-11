﻿using System.Net.Mail;

namespace Application.Smtp;

public interface ISmtpService
{
    Task SendEmailAsync(string toEmailAddress, string fromEmailAddress, string subject, string htmlBody, string textBody, Attachment[] attachments);
}