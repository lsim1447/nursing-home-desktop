using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Net.Mail;

namespace VersenyekSQL
{
    class CheckClass
    {
        private DoseClass m_adag = new DoseClass();
        private static Random random = new Random();
        public Boolean CnpCheckAssay(string readAddMeeting)
        {
            var dateFormats = new[] { "dd.MM.yyyy", "dd-MM-yyyy", "dd/MM/yyyy" };
            DateTime scheduleDate;
            bool validDate = DateTime.TryParseExact(
                readAddMeeting,
                dateFormats,
                DateTimeFormatInfo.InvariantInfo,
                DateTimeStyles.None,
                out scheduleDate);
            if (validDate) return true;
            else return false;
        }
        public string PriceWithTwoPrecision(string str)
        {
            int index = str.IndexOf(",");
            if (index == -1) return str;
            string temp;
            try
            {
                temp = str.Substring(0, index + 3);
            }
            catch (Exception)
            {
                str = str + "  ";
                temp = str.Substring(0, index + 3);
            }
            return temp;
        }

        public string CheckAcces(string user)
        {
            string temp = "";
            temp = m_adag.taroltEljaras("select FelhasznaloTipusok.Tipus from FelhasznaloTipusok, Felhasznalok where Felhasznalok.FelhasznaloTipusID = FelhasznaloTipusok.FelhasznaloTipusID and FelhasznaloNev = '" + user + "'");
            return temp;
        }

        public void sendPasswordToEmail(string sender,string receiver, string body)
        {
            int port = 587;
            string username = "lazar.szilard1995@gmail.com";
            string password = "Szilardka1";
            string smtpServer = "smtp.gmail.com";

            MailMessage mail = new MailMessage(sender, receiver, "OldHouseProject:password", body);
            SmtpClient client = new SmtpClient(smtpServer);
            client.Port = port;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(username, password);
            client.EnableSsl = true;
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            try
            {
                client.Send(mail);
            }
            catch (SmtpException e)
            {
                string err = e.Message.ToString();
            }
        }
        public string generatePassword(int lenght)
        {
            const string chars = "abcdefghijklmnopqrstuwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, lenght).Select(s => s[random.Next(s.Length)]).ToArray());
        }
    }
}
