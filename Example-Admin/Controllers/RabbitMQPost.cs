using Example_Admin.Models;
using System.Text;
using Newtonsoft.Json;
using RabbitMQ.Client;

namespace Example_Admin.Controllers
{
    public class RabbitMQPost
    {
        public Product data;

        public RabbitMQPost(Product _data)
        {
            this.data = _data;
        }

        public string Post()
        {
            var factory = new ConnectionFactory() { HostName = "localhost" };
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare(queue: data.Name,
                                     durable: false,
                                     exclusive: false,
                                     autoDelete: false,
                                     arguments: null);

                var productData = JsonConvert.SerializeObject(data);
                var body = Encoding.UTF8.GetBytes(productData);

                channel.BasicPublish(exchange: "",
                                     routingKey: data.Name,
                                     basicProperties: null,
                                     body: body);
                return $"[x] Sent {data.Name}";
            }
        }
    }
}