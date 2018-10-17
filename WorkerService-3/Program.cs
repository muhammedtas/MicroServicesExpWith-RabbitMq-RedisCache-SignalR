using System;
using System.Text;
using System.Threading.Tasks;
using WorkerService_3.Models;
using Microsoft.AspNetCore.SignalR.Client;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;

namespace WorkerService_3
{
    class Program
    {
        static HubConnection hubConnection;
        static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                Connect().Wait();

                channel.QueueDeclare(queue: "Television",
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var consumer = new EventingBasicConsumer(channel);
                consumer.Received += (model, ea) =>
                {
                    var body = ea.Body;
                    var data = Encoding.UTF8.GetString(body);
                    Product product = JsonConvert.DeserializeObject<Product>(data);
                    Console.WriteLine(" [x] Received {0}", product.Name + " : " + product.Value);

                    hubConnection.InvokeAsync("PushNotify", product);

                };
                channel.BasicConsume(queue: "Television",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }

        public static async Task Connect()
        {
            hubConnection = new HubConnectionBuilder()
               .WithUrl("http://localhost:4000/producthub")
               .Build();
            await hubConnection.StartAsync();
        }
    }
}
