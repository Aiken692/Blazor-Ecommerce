#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["src/Server/BlazorEcommerce.Server.csproj", "src/Server/"]
COPY ["src/Client/BlazorEcommerce.Client.csproj", "src/Client/"]
COPY ["src/Shared/BlazorEcommerce.Shared.csproj", "src/Shared/"]
RUN dotnet restore "src/Server/BlazorEcommerce.Server.csproj"
COPY . .
WORKDIR "/src/src/Server"
RUN dotnet build "BlazorEcommerce.Server.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "BlazorEcommerce.Server.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "BlazorEcommerce.Server.dll"]