using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Email");
            string address = Console.ReadLine();
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            MailAddress from = new MailAddress(address, name);

            Console.WriteLine("Введите Email получателя");
            string addressPoluch = Console.ReadLine();
            MailMessage objectMail = new MailMessage(address, addressPoluch);

            Console.WriteLine("Введите тему сообщения");
            string tema = Console.ReadLine();
            objectMail.Subject = tema;

            Console.WriteLine("Ввдедите текст сообщения:");
            string text = Console.ReadLine();
            objectMail.Body = text;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            Console.WriteLine("Введите gmail");
            string gmail = Console.ReadLine();
            Console.WriteLine("Введите пароль");
            string password = Console.ReadLine();

            smtp.Credentials = new NetworkCredential(gmail, password);
            smtp.EnableSsl = true;
            smtp.Send(objectMail);
            Console.Read();
        }
    }
}
