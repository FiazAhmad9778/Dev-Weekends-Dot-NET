using System.Data.SqlClient;
using System.Net.Mail;

namespace SolidPrinciples_Dot_Net_Series_1.SRP
{

    public class RegisterService1
    {
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();
            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database.

            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email. 
        }
    }


    public class RegisterService
    {
        public void RegisterUser(string username)
        {
            if (username == "admin")
                throw new InvalidOperationException();
            UserRepository.RegisterUser(username);
            EmailService.SendEmail();
        }
    }

    public class UserRepository
    {
        public static void RegisterUser(string username)
        {
            SqlConnection connection = new SqlConnection();
            connection.Open();
            SqlCommand command = new SqlCommand("INSERT INTO [...]");//Insert user into database.
        }
    }

    public class EmailService
    {
        public static void SendEmail()
        {
            SmtpClient client = new SmtpClient("smtp.myhost.com");
            client.Send(new MailMessage()); //Send a welcome email. 
        }
    }

    public class DateTimeExtension
    {
        public string FormatString(DateTime date)
        {
            return date.ToString("");
        }
    }
}
