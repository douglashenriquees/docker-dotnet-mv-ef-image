## MySql Container

* ```docker volume create volumedb```
* ```docker container run -d --name mysqldb -p 3306:3306 -v volumedb:/var/lib/mysql -e MYSQL_ROOT_PASSWORD=strongpass --platform linux/x86_64 mysql:5.7```

## EF Migrations

* ```dotnet add package Pomelo.EntityFrameworkCore.MySql```
* ```dotnet add package Microsoft.EntityFrameworkCore.Tools```
* ```dotnet ef migrations add initial```