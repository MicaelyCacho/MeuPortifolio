# Dockerfile para ASP.NET Core no Fly.io
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /src

# Copia o arquivo do projeto e restaura dependências
COPY ["MeuPortifolio/MeuPortifolio.csproj", "MeuPortifolio/"]
RUN dotnet restore "MeuPortifolio/MeuPortifolio.csproj"

# Copia todo o código
COPY . .

# Publica a aplicação
WORKDIR "/src/MeuPortifolio"
RUN dotnet publish "MeuPortifolio.csproj" -c Release -o /app/publish

# Imagem final de runtime
FROM mcr.microsoft.com/dotnet/aspnet:8.0
WORKDIR /app

# Configura variáveis para produção
ENV ASPNETCORE_URLS=http://0.0.0.0:8080
ENV ASPNETCORE_ENVIRONMENT=Production
EXPOSE 8080

# Copia os arquivos publicados
COPY --from=build /app/publish .

# Inicia a aplicação
ENTRYPOINT ["dotnet", "MeuPortifolio.dll"]