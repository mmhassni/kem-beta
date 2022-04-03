#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["KEM.EventManager.API/KEM.EventManager.API.csproj", "src/KEM.EventManager.API/KEM.EventManager.API.csproj"]
RUN dotnet restore "src/KEM.EventManager.API/KEM.EventManager.API.csproj"
COPY . .
WORKDIR /src/KEM.EventManager.API
RUN dotnet build "KEM.EventManager.API.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "KEM.EventManager.API.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "KEM.EventManager.API.dll","-v","diag"]