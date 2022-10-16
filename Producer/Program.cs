using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json.Serialization;

namespace RabbitMQ.Producer
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write -1 To Exit\n");

            while (true)
            {

                string message = Console.ReadLine();
                var factory = new ConnectionFactory() { HostName = "172.17.0.2", Port = 5672 };
                factory.UserName = "guest";
                factory.Password = "guest";

                using var connection = factory.CreateConnection();
                using var channel = connection.CreateModel();
                channel.QueueDeclare("demo-queue",
                    durable: true,
                    exclusive: false,
                    autoDelete: false,
                    arguments: null);
                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(message));

                channel.BasicPublish("", "demo-queue", null, body);

                if (message == "-1")
                {
                    break;
                }
            }
        }
    }
}
