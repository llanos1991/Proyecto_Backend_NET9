# BACKEND - CRUD DE TIENDA DE ELECTRODOMESTICOS - ARQ. HEXAGONAL

## OBJETIVOS

1. Arquitectura hexagonal (Dominio / Aplicación / Infraestructura / API)

2. PostgreSQL como base de datos

3. Entity Framework Core como ORM

## ESTRUCTURA DE DIRECTORIOS

backend/
│
├── Properties/               # Configuraciones de lanzamiento y entorno
│   └── launchSettings.json
│
├── src/                      # Código fuente del proyecto
│   ├── Core/                 # Contiene la lógica de negocio principal (Dominio)
│   │   ├── Entities/         # Clases de entidad como Product, Category
│   │   ├── Repositories/     # Interfaces de repositorios
│   │   └── Services/         # Lógica de negocio
│   │
│   ├── Application/          # Casos de uso, servicios
│   │   ├── DTOs/             # Clases de transferencia de datos (DTOs)
│   │   ├── Interfaces/       # Interfaces de servicios
│   │   └── Services/         # Lógica de la aplicación (casos de uso)
│   │
│   ├── Infrastructure/       # Implementaciones de detalles (Base de datos, etc.)
│   │   ├── Data/             # Implementación de acceso a datos (Repositorios)
│   │   └── Migrations/       # Migraciones de base de datos
│   │
│   ├── API/                  # Controladores y rutas de la API
│   │   ├── Controllers/      # Controladores de la API REST
│   │   └── Models/           # Modelos de la API (entrada y salida)
│   │
│   └── Shared/               # Utilidades, validaciones, configuraciones comunes
│       └── Helpers/          # Funciones o utilidades comunes
│
├── obj/                      # Archivos intermedios generados durante la compilación
├── bin/                      # Archivos binarios generados después de la compilación
├── appsettings.json          # Configuración de la aplicación (conexiones, etc.) con la bbdd
├── Program.cs                # Punto de entrada principal de la aplicación configuracion, bbdd, swagger, controller, puerto
├── backend.csproj            # Archivo de proyecto se encuentra las dependencias del proyecto.
└── Dockerfile                # Si decides dockerizar el proyecto en el futuro

## Comando en local en desarrollo

## compilar la aplicacion

- dotnet build

## correr la aplicacion

- dotnet run

## Comandos Docker en produccion

## Creacion de la Imagen de docker

- docker build -t tienda-backend-image .

## Creacion del Contenedor de docker

- docker run -p 7212:7212 --name tienda-backend-container tienda-backend-image
- docker run -p 7212:7212 --name tienda-backend-container -e ASPNETCORE_ENVIRONMENT=Production tienda-backend-image

- docker run -d --name tienda-backend-container -p 5232:5232  tienda-backend-image

