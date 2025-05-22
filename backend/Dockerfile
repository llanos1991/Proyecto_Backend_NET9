# Etapa 1: Build
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore

COPY . ./

RUN dotnet publish -c Release -o /app/publish

# Etapa 2: Runtime
FROM mcr.microsoft.com/dotnet/aspnet:9.0 AS runtime
WORKDIR /app

COPY --from=build /app/publish .

# Expone el puerto que usará tu aplicación (ej. 5232)
EXPOSE 5232

# Establecer el entorno como Production
ENV ASPNETCORE_ENVIRONMENT=Production

# Establecer la URL donde la app escuchará
ENV ASPNETCORE_URLS=http://+:5232

ENTRYPOINT ["dotnet", "backend.dll"]

