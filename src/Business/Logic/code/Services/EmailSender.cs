﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;

namespace RestFull.Business.Logic.Services
{
    public class EmailSender : IEmailSender
    {
        // Our private configuration variables
        private string host;
        private int port;
        private bool enableSSL;
        private string userName;
        private string password;

        // Get our parameterized configuration
        public EmailSender(string host, int port, bool enableSSL, string userName, string password)
        {
            this.host = host;
            this.port = port;
            this.enableSSL = enableSSL;
            this.userName = userName;
            this.password = password;
        }

        // Use our configuration to send the email by using SmtpClient
        public async Task SendEmailAsync(string email, string subject, string htmlMessage)
        {
            //var client = new SmtpClient(host, port)
            //{
            //    Credentials = new NetworkCredential(userName, password),
            //    EnableSsl = enableSSL
            //};
            //return client.SendMailAsync(
            //    new MailMessage(userName, email, subject, htmlMessage) { IsBodyHtml = true }
            //);

            return  ;
        }
    }
}
