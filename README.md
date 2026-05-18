<div align="center">

<img src="https://img.shields.io/badge/Chroniq-Gestor%20de%20Eventos-1a1a2e?style=for-the-badge&logoColor=white" alt="Chroniq"/>

<br/>
<br/>

![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)
![.NET](https://img.shields.io/badge/.NET%20Framework-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)
![Windows Forms](https://img.shields.io/badge/Windows%20Forms-0078D6?style=for-the-badge&logo=windows&logoColor=white)
![MongoDB](https://img.shields.io/badge/MongoDB-47A248?style=for-the-badge&logo=mongodb&logoColor=white)
![MaterialSkin](https://img.shields.io/badge/MaterialSkin-757575?style=for-the-badge&logo=materialdesign&logoColor=white)

<br/>

![Estado](https://img.shields.io/badge/Estado-En%20desarrollo-yellow?style=flat-square)
![Arquitectura](https://img.shields.io/badge/Arquitectura-MVC-blue?style=flat-square)
![NuGet](https://img.shields.io/badge/NuGet-MongoDB.Driver-004880?style=flat-square&logo=nuget)

---

## Tabla de contenidos
[Descripción](#descripción)
[Arquitectura MVC](#arquitectura-mvc)
[Estructura del proyecto](#estructura-del-proyecto)
[Base de datos](#base-de-datos)
[Historias de usuario](#historias-de-usuario)
[Instalación](#instalación)
[Convenciones del equipo](#convenciones-del-equipo)
</div>

## Descripción

**Chroniq** es un gestor de eventos de escritorio desarrollado en C# con Windows Forms. Permite a un **Líder** crear, consultar, actualizar y deshabilitar eventos, asignar invitados y validar conflictos de horario. Los **Invitados** pueden visualizar los eventos a los que fueron asignados.

El sistema no maneja registro de usuarios: los usuarios se establecen directamente en la base de datos MongoDB.

---

## Arquitectura MVC

El proyecto aplica el patrón **Modelo–Vista–Controlador** con separación estricta de responsabilidades:

```
src/
├── Modelo/        → Conexión a BD, entidades y acceso a datos
├── Controlador/   → Lógica del negocio y validaciones
└── Vista/         → Formularios Windows Forms (solo UI)
```

<table>
<thead>
<tr>
<th>Capa</th>
<th>Responsabilidad</th>
<th>Puede llamar a</th>
<th>NO puede llamar a</th>
</tr>
</thead>
<tbody>
<tr>
<td><strong>Modelo</strong></td>
<td>Conexión a MongoDB, entidades y consultas</td>
<td>Solo clases del Modelo</td>
<td>Controlador, Vista</td>
</tr>
<tr>
<td><strong>Controlador</strong></td>
<td>Validaciones y lógica del negocio</td>
<td>Modelo</td>
<td>Vista directamente</td>
</tr>
<tr>
<td><strong>Vista</strong></td>
<td>Formularios y eventos de UI</td>
<td>Controlador</td>
<td>Modelo directamente</td>
</tr>
</tbody>
</table>

> **Regla de oro:** Si hay un `if` de negocio en la Vista, debe moverse al Controlador. La Vista solo lee controles y delega.

---

## Estructura del proyecto

```
src/
│
├── Modelo/
│   ├── Conexion.cs          # Singleton de conexión a MongoDB
│   ├── Usuario.cs           # Entidad: colección Usuarios
│   ├── UsuarioModelo.cs     # Acceso a datos: colección Usuarios
│   ├── Evento.cs            # Entidad: colección Eventos
│   └── EventoModelo.cs      # Acceso a datos: colección Eventos
│
├── Controlador/
│   ├── LoginControlador.cs  # HU-01, HU-08
│   └── EventoControlador.cs # HU-02, HU-03, HU-04, HU-05, HU-06
│
└── Vista/
    ├── BaseMaterialForm.cs  # Clase base con tema MaterialSkin
    ├── FormLogin.cs/.Designer.cs
    ├── FormLider.cs/.Designer.cs
    └── FormInvitado.cs/.Designer.cs
```

### Flujo de llamadas

```
Vista
  └──► Controlador
           └──► Modelo (Conexion → BD)
           ◄──── datos (entidad o lista)
  ◄──── resultado (muestra en UI)
```

---

## Base de datos

**Motor:** MongoDB  
**Base de datos:** `BDgestorEventos`

### Colección `Usuarios`

| Campo | Tipo | Descripción |
|---|---|---|
| `_id` | ObjectId | Identificador único |
| `nombreUser` | string | Nombre del usuario |
| `passwordUser` | string | Contraseña |
| `tipoUser` | string | `"Lider"` o `"Invitado"` |
| `generoUser` | string | Género |
| `emailUser` | string | Correo electrónico |
| `telefonoUser` | string | Teléfono |
| `edadUser` | string | Edad |
| `numeroCedula` | string | Número de cédula |

### Colección `Eventos`

| Campo | Tipo | Descripción |
|---|---|---|
| `_id` | ObjectId | Identificador único |
| `codigoEvent` | int | Código numérico del evento |
| `nombreEvent` | string | Nombre del evento |
| `creadoPor` | ObjectId | `_id` del líder que lo creó |
| `tipoevent` | string | Tipo de evento (Cultural, Deportivo, etc.) |
| `fechahoraIniEvent` | string | Fecha y hora de inicio `"yyyy-MM-dd HH:mm:ss"` |
| `fechahoraFinEvent` | string | Fecha y hora de fin `"yyyy-MM-dd HH:mm:ss"` |
| `invitados` | array | Lista de `ObjectId` de invitados asignados |

> ⚠️ Las fechas se almacenan como `string` en formato `"yyyy-MM-dd HH:mm:ss"`. Este formato es ordenable alfabéticamente, lo que permite comparar fechas con filtros de MongoDB directamente sobre el string.

---

## Historias de usuario

<table>
<thead>
<tr>
<th>ID</th>
<th>Historia</th>
<th>Rol</th>
<th>Controlador</th>
<th>Estado</th>
</tr>
</thead>
<tbody>
<tr>
<td><strong>HU-01</strong></td>
<td>Iniciar sesión según rol</td>
<td>Líder / Invitado</td>
<td><code>LoginControlador.IniciarSesion()</code></td>
<td>✅ Implementada</td>
</tr>
<tr>
<td><strong>HU-02</strong></td>
<td>Registrar eventos</td>
<td>Líder</td>
<td><code>EventoControlador.RegistrarEvento()</code></td>
<td>🔴 Fase Red (falta Modelo)</td>
</tr>
<tr>
<td><strong>HU-03</strong></td>
<td>Consultar eventos</td>
<td>Líder</td>
<td><code>EventoControlador.ConsultarEventos()</code></td>
<td>🔴 Fase Red (falta Modelo)</td>
</tr>
<tr>
<td><strong>HU-04</strong></td>
<td>Actualizar eventos</td>
<td>Líder</td>
<td><code>EventoControlador.ActualizarEvento()</code></td>
<td>⏳ Pendiente</td>
</tr>
<tr>
<td><strong>HU-05</strong></td>
<td>Agregar invitados a un evento</td>
<td>Líder</td>
<td><code>EventoControlador.AgregarInvitado()</code></td>
<td>⏳ Pendiente</td>
</tr>
<tr>
<td><strong>HU-06</strong></td>
<td>Deshabilitar eventos</td>
<td>Líder</td>
<td><code>EventoControlador.DeshabilitarEvento()</code></td>
<td>⏳ Pendiente</td>
</tr>
<tr>
<td><strong>HU-07</strong></td>
<td>Visualizar eventos asignados</td>
<td>Invitado</td>
<td>Por definir</td>
<td>⏳ Pendiente</td>
</tr>
<tr>
<td><strong>HU-08</strong></td>
<td>Cerrar sesión</td>
<td>Líder / Invitado</td>
<td><code>LoginControlador</code> (parcial)</td>
<td>⏳ Pendiente</td>
</tr>
</tbody>
</table>

---

## Instalación

### Requisitos previos

- Visual Studio 2019 o superior
- .NET Framework 4.7.2 o superior
- MongoDB corriendo en `localhost:27017`

### Paquetes NuGet requeridos

```
MongoDB.Driver
```

> Instalar desde: clic derecho en el proyecto → **Administrar paquetes NuGet** → Examinar → `MongoDB.Driver`  
> Esto instala automáticamente `MongoDB.Bson` y `MongoDB.Driver.Core`.

### Configuración de la conexión

La cadena de conexión se encuentra en `Modelo/Conexion.cs`:

```csharp
private const string CADENA_CONEXION   = "mongodb://localhost:27017";
private const string NOMBRE_BASE_DATOS = "BDgestorEventos";
```

Modificar estos valores según el entorno local o servidor del equipo.

### Restaurar la base de datos

Los archivos de respaldo BSON se encuentran en `Modelo/respaldo/BDgestorEventos/`.  
Restaurar con `mongorestore`:

```bash
mongorestore --db BDgestorEventos ./Modelo/respaldo/BDgestorEventos/
```

---

## Convenciones del equipo

### Nombres de campos en MongoDB

Los nombres de los campos en los documentos de MongoDB deben coincidir **exactamente** con los `[BsonElement]` definidos en las entidades (`Evento.cs`, `Usuario.cs`). Un nombre incorrecto en el `BsonDocument` al insertar crea documentos con estructura diferente a la esperada.

### Prefijo `_` en campos privados

```csharp
private readonly EventoModelo _eventoModelo; // campo privado de la clase
```

El prefijo `_` indica que es un campo privado de la instancia. Los parámetros y variables locales no lo llevan.

### La Vista usa `var` al recibir datos del Controlador

```csharp
// ✅ Correcto: la Vista no depende del tipo Evento (src.Modelo)
var eventos = _eventoControlador.ConsultarEventos();
dgvEventos.DataSource = eventos;
```

### Los `if` de negocio van en el Controlador

```csharp
// ❌ Nunca en la Vista
if (usuario.TipoUser == "Lider") { ... }

// ✅ Siempre en el Controlador
public void IniciarSesion(...) {
    if (usuario.TipoUser == "Lider") { ... }
}
```

### Contrato pendiente del Modelo (fase Red activa)

Para salir de la fase Red, `EventoModelo.cs` debe implementar:

```csharp
// HU-02
public bool GuardarEvento(
    string nombreEvent, string tipoEvent,
    string fechahoraIniEvent, string fechahoraFinEvent,
    string idLider)

// HU-03
public List<Evento> ObtenerEventos(string fechaHoraActual)
// → Filtra donde fechahoraIniEvent > fechaHoraActual
// → Nunca retorna null, retorna lista vacía si no hay resultados
```

---

<div align="center">

Proyecto académico · Arquitectura MVC · C# Windows Forms + MongoDB

</div>
