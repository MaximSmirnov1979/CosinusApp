using System.Data;

namespace CosinusApp.Messages
{
    public class Message
    {
        // класс сообщения статуса сервера
        public class ServerStatus
        {
            public string Status { get; set; }
            public DateTime DateTime { get; set; }
            public string HostName { get; set; }
            public ServerStatus(string status, DateTime dateTime, string hostName)
            {
                Status = status;
                DateTime = dateTime;
                HostName = hostName;
            }
        }
        //класс сообщения доступных методов
        public class Methods
        {
            public string methodName { get; set; }
            public string methodDescription { get; set; }
            public Methods(string methodName, string methodDescription)
            {
                this.methodName = methodName;
                this.methodDescription = methodDescription;
            }
        }
        //класс сообщения решения теоремы косинусов
        public class CalcMessage
        {
            public record CalcInput(double a, double b, double angleC);
            public record CalcOutput(double c);
        }
    }
}
