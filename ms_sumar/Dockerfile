#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build

#ENV ASPNETCORE_ENVIRONMENT Development
#ENV ASPNETCORE_ENVIRONMENT: "Development"
COPY ["./appsettings.json", "."]
WORKDIR /src
COPY ["./BaseAPI/PapAPI.Rest.csproj", "."]
COPY ["./BaseAbstraccion/PapAPI.Abstraction.csproj", "../BaseAbstraccion/"]
COPY ["./BaseServicios/PapAPI.Services.csproj", "../BaseServicios/"]
COPY ["./BaseCore/PapAPI.BAL.csproj", "../BaseCore/"]
COPY ["./BaseRepositorio/PapAPI.Repository.csproj", "../BaseRepositorio/"]
COPY ["./BaseEntidades/PapAPI.Entity.csproj", "../BaseEntidades/"]
COPY ["./BaseAccesoDatos/PapAPI.DataAccess.csproj", "../BaseAccesoDatos/"]
RUN apt-get update \
    && apt-get install -y --no-install-recommends libgdiplus libc6-dev \
    && apt-get clean \
    && rm -rf /var/lib/apt/lists/*
RUN dotnet restore "./PapAPI.Rest.csproj"
COPY . .
RUN mkdir -p /home/bv
#RUN mkdir -p /home/bv/upload/PAPImages
#RUN mkdir -p /home/bv/upload/KLMFiles
#RUN mkdir -p /home/bv/upload/CIFSFiles
WORKDIR "/src/."
RUN dotnet build "PapAPI.Rest.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "PapAPI.Rest.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "PapAPI.Rest.dll"]