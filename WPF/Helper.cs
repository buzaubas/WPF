using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace WPF
{
    internal class Helper
    {
        public static string SentMsg(string to, string subject, string body, out bool result)
        {
            MailMessage msg = new MailMessage();   
            msg.From = new MailAddress("beks.dimash@gmail.com", "Dimash Bexultanov");

            msg.To.Add(to);
            //msg.CC.Add(""); //copy BCC - hidden copy

            msg.Subject = subject;
            msg.Priority = MailPriority.High;
            msg.Body = body;
            //msg.IsBodyHtml = true;  if body is html

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com";
            smtp.Port = 587;
            smtp.EnableSsl = true;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("login", "password");

            try
            {
                smtp.Send(msg);
                result = true;
                return "Сообщение отправлено";
            }
            catch (Exception ex)
            {
                result = false;
                return ex.Message;
            }
        } 
    }
}
