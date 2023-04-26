using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace singleResponsibility
{
    public class EmailSender
    {
        public void SendEmail(string email, string subject, string body)
        {
            Console.WriteLine($"{email} {subject} {body}");
        }
    }
}
