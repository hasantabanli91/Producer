>> This is a Producer Console Application to send messages to Consumer Console Application written in .Net Core.

>> It uses Rabbitmq to communicate

>> It has Dockerfile to dockorize in Docker Desktop

>> To work in this application 
	1 - first of all you should download and install Docker Desktop
	2 - Than you should install rabbitmq in Docker with this command "docker run -d --hostname my-rabbit --name some-rabbit -p 15672:15672 -p 5672:5672  rabbitmq:3.6-management-alpine"

>> Than you can build and run interactive mode the application with this commands
	1 - docker build -t producer -f producer/Dockerfile .
	2 - docker run -i producer

>> You can access to rabbitmq host in docker that do click view in browser in docker container

>> In rabbitmq container host name is 172.17.0.2. So I use this hostname to communicate. If you have different hostname you should use it. You can learn it your container logs and details.

>> Now The Producer Application can send messages in the queue