using System;
namespace Application.Contracts
{
	public interface IMailServices
    {
        public void SendMail(object mail);
    }
}

