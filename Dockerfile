FROM mcr.microsoft.com/dotnet/aspnet:3.1
LABEL version="3.0" description="Aplication ASP .NET Core MVC com MYSQL"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]