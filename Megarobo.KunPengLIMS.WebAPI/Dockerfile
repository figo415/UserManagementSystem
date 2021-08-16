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
ENV Postgres="Host=mega-postgres.cluster-cwfyhcnvgjwi.rds.cn-northwest-1.amazonaws.com.cn;Port=5432;User ID=postgres;Password=megapostgres;Database=kunpengapidev;Pooling=true;"
ENV InventorySystem="InventoryServerUrl=https://api.lims.test.aws.megarobo.tech"
ENV AwsS3="BucketName=ls-lims-service-bucket-dev;ServiceURL=https://ls-lims-service-bucket-dev.s3.cn-northwest-1.amazonaws.com.cn;RegionEndpoint=cnnorthwest1;UseKey=false;"
ENV Keycloak="KeycloakUrl=https://keycloak.dev.aws.megarobo.tech;MasterClientId=admin-cli;MasterUsername=keycloak;MasterPassword=keycloak;KplimsRealm=kplims-dev;"
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Megarobo.KunPengLIMS.WebAPI.dll"]