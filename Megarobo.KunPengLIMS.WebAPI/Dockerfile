#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["Megarobo.KunPengLIMS.WebAPI/Megarobo.KunPengLIMS.WebAPI.csproj", "Megarobo.KunPengLIMS.WebAPI/"]
RUN dotnet restore "Megarobo.KunPengLIMS.WebAPI/Megarobo.KunPengLIMS.WebAPI.csproj"
COPY . .
WORKDIR "/src/Megarobo.KunPengLIMS.WebAPI"
RUN dotnet build "Megarobo.KunPengLIMS.WebAPI.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Megarobo.KunPengLIMS.WebAPI.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
ENV DB_HOSTNAME="localhost"
ENV DB_PORT="5432"
ENV DB_USERNAME="postgres"
ENV DB_PASSWORD="megarobo"
ENV DB_NAME="limsdb"
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Megarobo.KunPengLIMS.WebAPI.dll"]