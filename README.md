# <div align="center">Chroniq</div>

<div align="center">

![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.7.2-512BD4?style=flat-square&logo=.net)
![C#](https://img.shields.io/badge/C%23-9.0-239120?style=flat-square&logo=csharp)
![WinForms](https://img.shields.io/badge/UI-WinForms-512BD4?style=flat-square)
![MongoDB](https://img.shields.io/badge/Database-MongoDB%203.8-13AA52?style=flat-square&logo=mongodb)
![License](https://img.shields.io/badge/License-MIT-green.svg?style=flat-square)
![Status](https://img.shields.io/badge/Status-Active%20Development-blue?style=flat-square)

**Aplicación de Gestión de Eventos con Arquitectura Escalable**

[Características](#características) • [Requisitos](#requisitos) • [Instalación](#instalación) • [Arquitectura](#arquitectura) • [Contribuir](#contribuir)

</div>

---

## 📋 Descripción

**Chroniq** es una aplicación de escritorio robusta para la gestión integral de eventos. Desarrollada con **.NET Framework 4.7.2** y **MongoDB**, proporciona una interfaz intuitiva basada en WinForms que permite crear, consultar, actualizar y gestionar eventos de forma eficiente.

La aplicación implementa un sistema de roles (líder e invitado) para controlar el acceso y los permisos, asegurando que cada usuario tenga las funcionalidades apropiadas para su rol.

---

## ✨ Características

- 🔐 **Sistema de Autenticación** - Login seguro con roles de usuario (Líder, Invitado)
- 📅 **Gestión de Eventos** - Crear, consultar y actualizar eventos en tiempo real
- 👥 **Gestión de Invitados** - Administrar participantes en cada evento
- 🎨 **Interfaz Moderna** - Diseño visual mejorado con MaterialSkin
- 💾 **Persistencia en MongoDB** - Base de datos NoSQL escalable
- 🏗️ **Arquitectura Limpia** - Separación clara de responsabilidades (MVC)
- 🔍 **Filtrado Avanzado** - Búsqueda y filtrado de eventos

---

## 🛠️ Stack Tecnológico

| Componente | Versión | Descripción |
|-----------|---------|------------|
| **.NET Framework** | 4.7.2 | Plataforma base |
| **C#** | 9.0 | Lenguaje de programación |
| **WinForms** | Nativa | Framework para UI de escritorio |
| **MongoDB** | 3.8.0 | Base de datos NoSQL |
| **MaterialSkin** | 2.2.3.1 | Tema visual Material Design |
| **DnsClient** | 1.8.0 | Resolución de DNS |

---

## 📊 Requisitos

### Mínimos
- **Sistema Operativo:** Windows 7 SP1 o superior
- **.NET Framework:** 4.7.2 o superior
- **RAM:** 2 GB mínimo
- **Espacio en Disco:** 100 MB

### Desarrollo
- **Visual Studio:** 2019 o superior (con soporte para .NET Framework)
- **MongoDB:** 4.0 o superior (servidor local o remoto)
- **.NET SDK:** Para compilación desde línea de comandos

---

## 🚀 Instalación

### 1. Clonar el Repositorio
```bash
git clone https://github.com/Louis-Du/Chroniq.git
cd Chroniq
```

### 2. Restaurar Dependencias
```bash
nuget restore src/src.sln
```

### 3. Configurar MongoDB
Asegurate de que MongoDB esté ejecutándose en tu máquina:
```bash
# En Windows (si está instalado como servicio)
net start MongoDB

# O ejecutar manualmente
mongod --dbpath "C:\ruta\a\datos"
```

### 4. Compilar la Solución
```bash
# Con Visual Studio
# Abre src/src.sln y presiona Ctrl+Shift+B

# O desde la línea de comandos
cd src
msbuild src.csproj /p:Configuration=Release
```

### 5. Ejecutar la Aplicación
```bash
.\src\bin\Release\src.exe
```

---

## 🏗️ Arquitectura

### Patrón: MVC (Model-View-Controller)

La aplicación sigue el patrón **MVC** para garantizar una arquitectura limpia y mantenible:

```
┌─────────────────────────────────────┐
│         VISTA (WinForms)            │
│  • Formularios de login             │
│  • Panel de líder                   │
│  • Panel de invitado                │
│  • Gestión de eventos               │
└──────────────┬──────────────────────┘
               │ (Acciones)
               ▼
┌─────────────────────────────────────┐
│       CONTROLADOR (Orquestación)    │
│  • Validaciones                     │
│  • Lógica de flujo                  │
│  • Decisiones de negocio            │
└──────────────┬──────────────────────┘
               │ (Coordina)
               ▼
┌─────────────────────────────────────┐
│     MODELO (Entidades de Dominio)   │
│  • Usuario                          │
│  • Evento                           │
│  • Invitado                         │
│  • Propiedades de negocio           │
└──────────────┬──────────────────────┘
               │ (Persiste)
               ▼
┌─────────────────────────────────────┐
│        MONGODB (Persistencia)       │
│  • Colecciones BSON                 │
│  • Índices optimizados              │
└─────────────────────────────────────┘
```

### Principios de Diseño

- **Separación de Responsabilidades:** Cada capa tiene un propósito específico
- **Vista:** Muestra datos y captura acciones del usuario
- **Modelo:** Define estructuras de datos y propiedades de negocio
- **Controlador:** Coordina la interacción entre Vista y Modelo

---

## 📁 Estructura del Proyecto

```
Chroniq/
├── src/
│   ├── src/
│   │   ├── Vista/
│   │   │   ├── FormLogin.cs              # Formulario de autenticación
│   │   │   ├── PanelLider.cs             # Panel de administración
│   │   │   ├── PanelInvitado.cs          # Panel de invitado
│   │   │   └── [Otros formularios...]
│   │   │
│   │   ├── Modelo/
│   │   │   ├── Usuario.cs                # Entidad de usuario
│   │   │   ├── Evento.cs                 # Entidad de evento
│   │   │   ├── Invitado.cs               # Entidad de invitado
│   │   │   └── [Otras entidades...]
│   │   │
│   │   ├── Controlador/
│   │   │   ├── ControladorUsuario.cs     # Lógica de usuarios
│   │   │   ├── ControladorEvento.cs      # Lógica de eventos
│   │   │   ├── ControladorInvitado.cs    # Lógica de invitados
│   │   │   └── [Otros controladores...]
│   │   │
│   │   ├── Properties/
│   │   ├── bin/                          # Binarios compilados
│   │   ├── obj/                          # Archivos de compilación
│   │   ├── App.config                    # Configuración de aplicación
│   │   ├── packages.config               # Dependencias NuGet
│   │   ├── Program.cs                    # Punto de entrada
│   │   └── src.csproj                    # Archivo del proyecto
│   │
│   ├── packages/                         # Paquetes NuGet descargados
│   ├── .vs/                              # Caché de Visual Studio
│   └── src.sln                           # Solución Visual Studio
│
├── LICENSE                               # Licencia del proyecto
└── README.md                             # Este archivo
```

---

## 📝 Convenciones de Código

### Nomenclatura
- **Clases:** `PascalCase` (ej: `FormLogin`, `ControladorEvento`)
- **Métodos:** `PascalCase` (ej: `ObtenerEventos()`, `CrearUsuario()`)
- **Variables Locales:** `camelCase` (ej: `nombreUsuario`, `fechaEvento`)
- **Constantes:** `UPPER_SNAKE_CASE` (ej: `CONEXION_TIMEOUT`)

---

## 💾 Configuración de Base de Datos

La aplicación utiliza MongoDB para persistencia de datos. Las colecciones principales son:

| Colección | Descripción |
|-----------|------------|
| `usuarios` | Registros de usuarios del sistema |
| `eventos` | Información de eventos |
| `invitados` | Participantes en eventos |

---

## 🔧 Compilación y Distribución

### Compilar en Modo Debug
```bash
cd src
msbuild src.csproj /p:Configuration=Debug
```

### Compilar en Modo Release
```bash
cd src
msbuild src.csproj /p:Configuration=Release
```
---

## 🐛 Solución de Problemas

| Problema | Solución |
|----------|----------|
| **No conecta a MongoDB** | Verifica que el servicio MongoDB esté ejecutándose |
| **Error de dependencias NuGet** | Ejecuta `nuget restore` en la carpeta `src/` |
| **Interfaz sin estilos** | Asegúrate de que MaterialSkin esté correctamente instalado |
| **Error de .NET Framework** | Instala .NET Framework 4.7.2 desde Microsoft |

---

## 📚 Desarrollo

### Agregar Nueva Funcionalidad

1. **Crear entidad en Modelo/** si es necesario
2. **Implementar lógica en Controlador/**
3. **Crear formulario en Vista/** para la interfaz
4. **Conectar Vista → Controlador → Modelo**
5. **Probar y validar**
---

## 📋 Estado del Proyecto

- ✅ **Autenticación de usuarios**
- ✅ **CRUD de eventos**
- ✅ **Sistema de roles**
- 🟡 **Reportes y estadísticas** (En desarrollo)
- 🟡 **Exportación de datos** (En desarrollo)

---

## 🤝 Contribuir

Las contribuciones son bienvenidas. Por favor:

1. Fork el proyecto
2. Crea una rama para tu feature (`git checkout -b feature/AmazingFeature`)
3. Commit tus cambios (`git commit -m 'Add some AmazingFeature'`)
4. Push a la rama (`git push origin feature/AmazingFeature`)
5. Abre un Pull Request

### Directrices de Contribución
- Sigue las [convenciones de código](#convenciones-de-código)
- Comenta código complejo
- Añade pruebas unitarias cuando sea posible
- Actualiza la documentación

---
## 👥 Colaboradores
<div align="center">
<table>
  <tr>
    <td align="center">
      <a href="https://github.com/eljavi0">
        <img src="https://github.com/eljavi0.png" width="100" style="border-radius: 50%" /><br />
        <sub><b>eljavi0</b></sub>
      </a><br />
      <sub>Desarrollador</sub>
    </td>
    <td align="center">
      <a href="https://github.com/Louis-Du">
        <img src="https://github.com/Louis-Du.png" width="100" style="border-radius:50%" /><br />
        <sub><b>Louis-Du</b></sub>
      </a><br />
      <sub>Desarrollador</sub>
    </td>
    <td align="center">
      <a href="https://github.com/lukasa133">
        <img src="https://github.com/lukasa133.png" width="100" style="border-radius:50%" /><br />
        <sub><b>lukasa133</b></sub>
      </a><br />
      <sub>Desarrollador</sub>
    </td>
  </tr>
</table>


⭐ Si este proyecto te fue útil, considera darle una estrella en GitHub

</div>
