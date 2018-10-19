# MicroServicesExpWith-RabbitMq-RedisCache-SignalR
Basic microservice exp with distributed arch. It includes Queuing mechanism with RabbitMq, Caching mechanism with RedisCache and web socketing via SignalR in .Net Core environment

1- For each part of solution hit "dotnet restore"
2- Then for each part of solution hit "dotnet watch run"

Admin project is host in localhost:5000
Client prject is host in localhost:4000

Worker services is pushing notification to localhost:4000 via signalR

Before you try it bu sure your RabbitMQ service is running by checking Task Manager.

To build RabbitMq just check this url => https://www.rabbitmq.com/tutorials/tutorial-one-dotnet.html
