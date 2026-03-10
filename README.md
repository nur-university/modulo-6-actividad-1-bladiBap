[![Review Assignment Due Date](https://classroom.github.com/assets/deadline-readme-button-22041afd0340ce965d47ae6ef1cefeee28c7c493a6346c4f15d667ab976d596c.svg)](https://classroom.github.com/a/NkrcaSS8)


## Ejecución 

Abrir una terminal en la *raíz del repositorio* y ejecuta los siguientes comandos en orden:

Navega al directorio del api-auth y construye la imagen:
```bash
cd api-auth/api-auth/
docker build -t mi-api-auth .
cd ../..
```

Navega al directorio del api-gateway y construye la imagen:

```bash
cd api-gateway/api-gateway/
docker build -t mi-api-gateway .
cd ../..
```

Una vez creadas las imágenes, levanta la orquestación con Docker Compose:

```bash
docker-compose up -d
```

### Coleccion

Importar la coleccion de postman ubicada en la raiz del repositorio

Algunos usuario para obtener tokens son:

```bash
{ userName = "sergio", password = "12345678" },
{ userName = "maria", password = "87654321" },
{ userName = "juan", password = "123" }
```
