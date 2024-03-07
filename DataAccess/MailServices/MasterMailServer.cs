using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;

namespace DataAccess.MailServices
{
    public abstract class MasterMailServer
    {
        private SmtpClient smtpClient; //La hacemos privada para que solo pueda accder la propia clase.
        protected string senderMail { get; set; } //Quien manda el mail.
        protected string password { get; set; }
        protected string host { get; set; }
        protected int port { get; set; }
        protected bool ssl { get; set; }

        protected void initializeSmtpClient()
        {
            smtpClient = new SmtpClient();
            smtpClient.Credentials = new NetworkCredential(senderMail,password);
            smtpClient.Host = host;
            smtpClient.Port = port;
            smtpClient.EnableSsl = ssl;
        }
        public void sendMail (string subject,string body, List<string> recipientMail) //Como parametros tenemos el titulo, cuerpo y receptor.
        {
            var mailMessage = new MailMessage(); //Instanciamos la clase mensaje de correo.

            try //Monitoreamos esta parte del codigo, para que si tiene errores, se ejecute el catch
            {
                mailMessage.From = new MailAddress(senderMail); //Indicamos de quien es el mensaje
                foreach(string mail in recipientMail) //Agregamos las direcciones mediante un ciclo.
                {
                    mailMessage.To.Add(mail); //Para quien sera enviado el mensaje.
                }
                mailMessage.Subject = subject; //Indicamos el titulo.
                mailMessage.Body = body; //Indicamos el cuerpo
                mailMessage.Priority = MailPriority.Normal; //Correo con prioridad normal
                smtpClient.Send(mailMessage);
            }
            catch(Exception ex) { }
            finally
            {
                mailMessage.Dispose(); //Libera los recursos q usa MailMessage.
                smtpClient.Dispose();
            }
        }

    }
}
