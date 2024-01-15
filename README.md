# PROYECTO DE PRUEBA TECNICA


## Requerimientos:
 * Guardar y leer datos con procedimientos almacenados
 * Hace uso de ADO.NET para la interacción con la base de datos
 * Desarrollado en VB 2019
 * BD SqlServer 2017

### Desarrollo
Se realizó programa para gestionar empleados y sus vacaciones.
Se creó la arquitectura en capas.
Se implementó el patrón de diseño repository para una mejora en la persistencia de datos.
Esto se hace para obtener una capa extra de abstracción en los componentes, evitando la repetición del código (principio DRY), facilitando el testeo y desacoplándolo de la lógica de negocio.
Se implementó la capa de lógica de negocio (service) que hace llamado al modelo (repository) por medio de la inyección de dependencias, lo que hace nuestro código más modular y desacoplado.
Lo que a su vez nos permite facilidad de refactorización y de pruebas. Luego en la capa de presentación solo nos centramos en hacer llamadas sencillas a nuestra lógica de negocio. Sin exponer 
nuestros datos. Estas técnicas aplicadas nos permiten una facil escalabilidad y mejora continua. 

> [!IMPORTANT]
> Dentro del proyecto, encontrará el archivo de base de datos. (test.bak)


> [!NOTE]
> Técnicas aplicadas:
> * Arquitectura en capas
> * Patrón de diseño Repository
> * Patrón de diseño Dependency Injection
