﻿using System;
using Application.Contracts;
using static System.Net.Mime.MediaTypeNames;

namespace Infrastructure.Mail
{
	public class MailServices : IMailServices
    {

        public void sendMail(object mail)
        {
            Console.WriteLine("sending mail ...");
        }
    }
}

