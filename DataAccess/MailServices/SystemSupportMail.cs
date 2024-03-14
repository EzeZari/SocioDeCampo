using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.MailServices
{
    class SystemSupportMail : MasterMailServer //Agregamos como herencia la clase MasterMail...
    {
        public SystemSupportMail() {
            senderMail = "Sociodecampo@hotmail.com";
            password = "SDCampo2125";
            host = "smtp-mail.outlook.com";
            port = 587; //465
            ssl = true;
            initializeSmtpClient();
        
        }

    }
}
