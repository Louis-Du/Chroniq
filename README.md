# Creacion-de-eventos

Proyecto base de agenda de eventos con WinForms (.NET Framework) y MongoDB.

## Estructura actual

### src/
Contiene la solucion y el codigo de la aplicacion de escritorio.

### src/src/Vista/
Contiene la capa Vista (formularios WinForms).

Que va aqui:
- Formularios de login, panel de lider, panel de invitado.
- Formularios para crear, consultar y actualizar eventos.
- Controles visuales y eventos de UI.

Responsabilidad:
- Mostrar datos al usuario.
- Capturar acciones (clicks, seleccion de fechas, filtros).

### src/src/Modelo/
Contiene la capa Modelo (entidades del dominio).

Que va aqui:
- Clases como Usuario, Evento e Invitado.
- Propiedades de negocio (nombre, fecha/hora, estado, rol, etc.).

Responsabilidad:
- Representar la estructura de datos de la aplicacion.
- No contiene formularios ni logica de interfaz.

### src/src/Controlador/
Contiene la capa Controlador.

Que va aqui:
- Clases que reciben acciones de la Vista y coordinan el flujo.
- Validaciones y decisiones previas a guardar/mostrar datos.

Responsabilidad:
- Conectar Vista y Modelo.
- Aplicar reglas del flujo (crear, consultar, actualizar, deshabilitar).

### BDgestorEventos/
Contiene archivos de datos/export de MongoDB (colecciones y metadatos).

Que va aqui:
- Archivos .bson y .metadata.json para carga o respaldo de datos.

Responsabilidad:
- Fuente inicial de datos para pruebas o restauracion.
- No contiene codigo de interfaz.

## Regla de arquitectura usada

- Vista: muestra y captura.
- Modelo: define datos.
- Controlador: decide y coordina.

Con esto el proyecto queda simple, pero ordenado para crecer sin mezclar responsabilidades.