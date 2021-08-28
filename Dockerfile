#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY ["FathymaPieShop/FathymaPieShop.csproj", "FathymaPieShop/"]
RUN dotnet restore "FathymaPieShop/FathymaPieShop.csproj"
COPY . .
WORKDIR "/src/FathymaPieShop"
RUN dotnet build "FathymaPieShop.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "FathymaPieShop.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=publish src/FathymaPieShop/JsonFile/product.json json/
#ENTRYPOINT ["dotnet", "FathymaPieShop.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet FathymaPieShop.dll