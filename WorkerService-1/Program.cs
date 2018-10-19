using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.SignalR.Client;
using WorkerService_1.Models;

namespace WorkerService_1
{
    class Program
    {
        public static HubConnection hubconnection;
        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                //Trigger The SignalR
                Connect().Wait();

                channel.QueueDeclare(queue: "Computer",
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

                    hubconnection.InvokeAsync("PushNotify", product);

                };
                channel.BasicConsume(queue: "Computer",
                                     autoAck: true,
                                     consumer: consumer);

                Console.WriteLine(" Press [enter] to exit.");
                Console.ReadLine();
            }
        }

        public static async Task Connect()
        {
            var credential = Convert.ToBase64String(System.Text.Encoding.GetEncoding("ISO-8859-1").GetBytes("SomeUserName" + ":" + "SomePassword"));

            hubconnection = new HubConnectionBuilder()
            .WithUrl("http://localhost:4000/producthub")
            .Build();

            // hubconnection.Closed += async (error) =>
            // {
            //     await Task.Delay(new Random().Next(0,5) * 1000);
            //     await hubconnection.StartAsync();
            // };

            await hubconnection.StartAsync();
        }
    }
}

#region SignalR Props

  // var handler = new HttpClientHandler
            // {
            //     ClientCertificateOptions = ClientCertificateOption.Manual,
            //     ServerCertificateCustomValidationCallback = (httpRequestMessage, cert, cetChain, policyErrors) => { return true; }
            // };

            //    .WithUrl("http://localhost:4000/producthub", options =>
            //     {
            //         options.Headers.Add("Authorization", $"Basic {credential}");
            //     })
            //     connectionSignalR = new HubConnectionBuilder()

            //     .WithUrl("http://localhost:4000/producthub")
            //     //.WithTransport(Microsoft.AspNetCore.Sockets.TransportType.WebSockets)
            //    //.WithConsoleLogger()
            //    //.WithMessageHandler(handler)
            //    .Build();
            // await connectionSignalR.StartAsync();

#endregion

