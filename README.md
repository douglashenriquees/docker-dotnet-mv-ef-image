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
* ```docker container run -d -p 4000:80 -e DBHOST=172.17.0.2:3306 --name mvc-produtos asp-net-mvc-ef/app2:2.0```