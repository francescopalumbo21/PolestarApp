# PolestarApp

Prototipo de aplicación de escritorio para Windows realizado con **WPF** en **Microsoft Blend for Visual Studio**.
Práctica 1 de la asignatura **Interfaces de Usuario** – Universidad Miguel Hernández de Elche (curso 2026/2027).

Autor: Francesco Palumbo

## Contenido del repositorio (entrega)

| Elemento | Ubicación |
|---|---|
| Documentación técnica | [`Documentacion/Documentacion_P1_PolestarApp.pdf`](Documentacion/Documentacion_P1_PolestarApp.pdf) |
| Anexo sobre el uso de la IA | [`Documentacion/Anexo_uso_IA.pdf`](Documentacion/Anexo_uso_IA.pdf) |
| Prototipo compilado (Windows) | [`Prototipo/PolestarApp_prototipo.zip`](Prototipo/PolestarApp_prototipo.zip) |
| Código fuente (proyecto de Blend / Visual Studio) | [`PolestarApp/`](PolestarApp/) y `PolestarApp.slnx` |

## Descripción

La aplicación simula la interfaz de un concesionario de Polestar, la marca sueca de coches eléctricos, y tiene tres pantallas:

| Pantalla | Ventana | Contenido |
|---|---|---|
| Inicio | `MainWindow.xaml` | Imagen principal, botón "Ver catálogo" y ofertas de otoño |
| Iniciar sesión | `LoginWindow.xaml` | Formulario con contraseña oculta y gestión de errores |
| Catálogo | `CatalogoWindow.xaml` | Galería con los cinco modelos de la gama |

Todas las pantallas comparten el logo (arriba a la izquierda) y el botón **Menú** (arriba a la derecha), que abre un menú desplegable animado para navegar entre ellas.

## Requisitos

- Windows 10 u 11
- .NET Framework 4.7.2
- Visual Studio 2022 o posterior, o Microsoft Blend for Visual Studio (solo para abrir y compilar el código)

## Cómo ejecutarla

**Prototipo compilado:** descargar [`Prototipo/PolestarApp_prototipo.zip`](Prototipo/PolestarApp_prototipo.zip), descomprimirlo y ejecutar `PolestarApp.exe`. Si Windows muestra el aviso de SmartScreen, pulsar *Más información* → *Ejecutar de todas formas* (la aplicación no está firmada digitalmente).

**Desde el código:** abrir `PolestarApp.slnx` con Visual Studio o Blend y pulsar *Iniciar* (F5).

### Cuenta de prueba

El prototipo no usa base de datos; el único acceso válido es:

- Correo: `cliente@polestar.es`
- Contraseña: `Polestar2026`

## Estructura del proyecto

```
Documentacion/                Documentación técnica y anexo sobre el uso de la IA (PDF)
Prototipo/                    Aplicación compilada (.zip)
PolestarApp.slnx              Solución
PolestarApp/
  Application.xaml            Recursos comunes: animaciones del menú y estilos de los botones
  MainWindow.xaml(.vb)        Pantalla de inicio
  LoginWindow.xaml(.vb)       Pantalla de inicio de sesión
  CatalogoWindow.xaml(.vb)    Pantalla del catálogo
  Assets/                     Logo y fotografías
  My Project/                 Archivos generados por Visual Studio
```

Interfaz en XAML; código (code-behind) en Visual Basic.

## Recursos utilizados

| Recurso | Fuente | Licencia |
|---|---|---|
| Logo Polestar (`polestarlogo.png`) | https://seeklogo.com/vector-logo/488075/polestar | Marca registrada de Polestar; uso exclusivamente didáctico |
| Foto principal (`hero.jpg`) | Benjamin Brunner – https://unsplash.com/photos/60nrfvSQuWQ | Unsplash License |
| Ofertas y catálogo (`oferta_*`, `catalogo_*`) | Sitio de prensa oficial de Polestar – https://media.polestar.com | Imágenes de prensa de Polestar; uso exclusivamente didáctico |
| Fondo del login (`login_fondo.jpg`) | https://media.polestar.com/models/polestar-3/photos?page=18 | Imagen de prensa de Polestar; uso exclusivamente didáctico |

Las fotografías se han recortado y redimensionado. Los precios y textos de los modelos son ficticios, creados para el prototipo.

## Aviso

Proyecto académico sin relación con Polestar. Todas las marcas pertenecen a sus propietarios.
