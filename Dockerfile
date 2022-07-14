FROM mcr.microsoft.com/dotnet/aspnet:6.0
LABEL version="2.0" description="Aplicacao ASP .NET MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet", "mvc1.dll"]