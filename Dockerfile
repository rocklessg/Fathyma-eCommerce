#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.
FROM mcr.microsoft.com/dotnet/aspnet:3.1 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
FROM mcr.microsoft.com/dotnet/sdk:3.1 AS build
WORKDIR /src
COPY *.sln .
#COPY ["FathymaPieShop/FathymaPieShop.csproj", "FathymaPieShop/"]
COPY FathymaPieShop/*.csproj FathymaPieShop/
COPY FathymaPieShop/DatabaseAccess/*.csproj DatabaseAccess/
COPY FathymaPieShop/Core/*.csproj Core/
RUN dotnet restore FathymaPieShop/*.csproj
COPY . .


WORKDIR /src/FathymaPieShop
RUN dotnet build


FROM build AS publish
WORKDIR /src/FathymaPieShop
RUN dotnet publish -c Release -o /app/publish
 
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
COPY --from=publish src/FathymaPieShop/JsonFile/product.json json/
#ENTRYPOINT ["dotnet", "FathymaPieShop.dll"]
CMD ASPNETCORE_URLS=http://*:$PORT dotnet FathymaPieShop.dll