FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS runtime
LABEL version="2.0" description="Aplicacao ASP .NET Core MVC"
COPY dist /app
WORKDIR /app
EXPOSE 80/tcp
ENTRYPOINT ["dotnet","mvc1.dll"]
