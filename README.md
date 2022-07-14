## MySql Container

* ```docker container run --name mysqldb -d -p 3306:3306 -v $(pwd)/volume-mysql:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=strongpass --platform linux/x86_64 mysql:5.7```
* ```docker container exec -it mysqldb /bin/bash```
* ```mysql -u root -p```

## EF Migrations

* ```dotnet add package Pomelo.EntityFrameworkCore.MySql```
* ```dotnet add package Microsoft.EntityFrameworkCore.Tools```
* ```dotnet ef migrations add initial```

## Imagem

* ```dotnet publish -c Release -o dist```
* ```docker image build -t asp-net-mvc/app:2.0 .```
* ```docker network inspect bridge```
  * verifica a rede interna definida por software do docker, para visalizar os **IPs** de cada container
* ```docker container run -d -p 4400:80 -e DBHOST=172.17.0.2 --name mvc-produtos asp-net-mvc/app:2.0```
  * cria o container e aplica a variável de ambiente **DBHOST**, equivalente ao endereço **IP** do container do **MySql** disponível na rede interna do docker

## Publicando a Imagem

* ```docker image tag asp-net-mvc/app:2.0 username/mvc-produtos:2.0```
* ```docker login -u username```
* ```docker image push username/mvc-produtos:2.0```
* ```docker container run -p 8800:80 -e DBHOST=172.17.0.2 --name mvc-produtos-from-hub username/mvc-produtos:2.0```