# Sweet Manager Web Service

API REST para la gestión de hoteles y servicios relacionados, desarrollada con .NET 8 y arquitectura de Bounded Contexts.

## 🏗️ Arquitectura

El proyecto está organizado en los siguientes Bounded Contexts:

- **IAM (Identity & Access Management)**: Gestión de usuarios, autenticación y autorización
- **Commerce**: Gestión de transacciones comerciales y pagos
- **Communication**: Gestión de comunicaciones y envío de correos
- **Inventory**: Gestión de inventario de productos y suministros
- **Monitoring**: Monitoreo de actividades y auditoría
- **OrganizationalManagement**: Gestión organizacional y roles

## 🐳 Docker

### Imagen en Docker Hub

La aplicación está disponible en Docker Hub:

```bash
docker pull nelsonupc/sweetmanager-backend:latest
```

**Link de la imagen:** [https://hub.docker.com/r/nelsonupc/sweetmanager-backend](https://hub.docker.com/r/nelsonupc/sweetmanager-backend)

### Ejecutar con Docker

```bash
# Descargar y ejecutar la imagen
docker run -d -p 8080:8080 -p 8081:8081 \
  --name sweetmanager-api \
  nelsonupc/sweetmanager-backend:latest
```

### Usar una versión específica

```bash
docker pull nelsonupc/sweetmanager-backend:v1.0.0
docker run -d -p 8080:8080 -p 8081:8081 \
  --name sweetmanager-api \
  nelsonupc/sweetmanager-backend:v1.0.0
```

### Ejecutar con Docker Compose

```bash
# Desarrollo 
docker-compose -f docker-compose.yml up -d

```

## 🗄️ Base de Datos

La aplicación utiliza MySQL como base de datos. La configuración de conexión está en `appsettings.json`:

- **Host:** [Configurado en el codigo]
- **Puerto:** [Configurado en el codigo]
- **Base de datos:** [Configurado en el codigo]
- **Usuario:** [Configurado en el codigo]
- **Password:** [Configurado en el codigo]


### Configuración

1. Clonar el repositorio:
```bash
git clone <repository-url>
cd web-servicesspicy
```

2. Configurar la base de datos en `appsettings.Development.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Port=3306;Database=sweetmanager;Uid=root;Pwd=rootpassword;"
  }
}
```

3. Restaurar dependencias:
```bash
dotnet restore
```

4. Ejecutar migraciones (si aplica):
```bash
dotnet ef database update
```

5. Ejecutar la aplicación:
```bash
cd SweetManagerWebService
dotnet run
```

La API estará disponible en:
- HTTP: `http://localhost:5000`
- HTTPS: `https://localhost:5001`
- Swagger: `http://localhost:5000/swagger`





## 🔧 Tecnologías

- **.NET 8.0**: Framework principal
- **Entity Framework Core**: ORM para acceso a datos
- **MySQL**: Base de datos
- **JWT**: Autenticación y autorización
- **Swagger/OpenAPI**: Documentación de API
- **Docker**: Contenedorización
- **BCrypt**: Hash de contraseñas

## 📚 Endpoints Principales

### IAM
- `POST /api/v1/authentication/sign-in` - Iniciar sesión
- `POST /api/v1/authentication/sign-up` - Registrar usuario
- `GET /api/v1/users` - Obtener usuarios

### Commerce
- Endpoints para gestión de transacciones comerciales

### Communication
- Endpoints para envío de correos y comunicaciones

### Inventory
- Endpoints para gestión de inventario

### Monitoring
- Endpoints para monitoreo y auditoría

### OrganizationalManagement
- Endpoints para gestión organizacional

