# 📞 TPI Diseño de Sistemas - Gestión de Respuesta de Operador

## 📝 Descripción
Este proyecto es la implementación práctica (Realización de Caso de Uso) de un sistema de gestión de llamadas, desarrollado bajo los lineamientos del Proceso Unificado de Desarrollo (PUD). 

El objetivo principal del proyecto fue aplicar sólidos conceptos de Ingeniería de Software, transformando requerimientos de negocio en un modelo de análisis estructurado mediante Lenguaje Unificado de Modelado (UML), para luego construir una solución funcional utilizando patrones de diseño orientados a objetos.

## 🚀 Tecnologías y Herramientas
* **Lenguaje:** C#
* **Framework:** .NET Framework (Windows Forms)
* **Modelado y Diseño:** Lucidchart (UML)
* **Metodología:** Proceso Unificado de Desarrollo (PUD)
* **Arquitectura:** Diseño basado en Patrones (Controlador / Experto / Creador)

## 📐 Modelado Arquitectónico (UML)
El proyecto cuenta con una exhaustiva documentación visual de la arquitectura del software, incluyendo:
* **Diagrama de Clases:** Estructuración de las entidades del dominio (Llamada, Cliente, Categorías) y clases de soporte (Gestor, Pantalla, Estados).
* **Diagramas de Secuencia:** Modelado dinámico del flujo de mensajes para la validación de clientes y el registro de la respuesta del operador.
* **Diagrama de Máquina de Estados:** Trazabilidad del ciclo de vida del objeto principal (`Llamada`), controlando transiciones estrictas (Iniciada -> En Curso -> Finalizada/Cancelada).

## ✨ Funcionalidades Clave del Caso de Uso
* **Gestión de Interfaz y Control:** Implementación del patrón *Boundary-Control-Entity* separando la lógica de la interfaz (`PantallaRespuestaOperador`) de la lógica de negocio (`GestorRespuestaOperador`).
* **Seguimiento de Estados:** Lógica de transición de estados de las comunicaciones y registro de hitos temporales.
* **Cálculo de Métricas:** Determinación algorítmica de la duración de las llamadas en base a los cambios de estado.
* **Validación de Datos:** Flujo integrado para consultar y validar opciones, subopciones y categorías asociadas a la comunicación del cliente.

## ⚙️ Instalación
1. Clonar el repositorio.
2. Abrir la solución `.sln` en Visual Studio.
3. Compilar el proyecto para restaurar dependencias.
4. Ejecutar la aplicación de Windows Forms para visualizar la interfaz del operador.

-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

# 🎬 CineLife - Sistema de Gestión de Cines

## 📝 Descripción
CineLife es una aplicación de escritorio desarrollada para gestionar de manera integral las operaciones de un complejo de cines. El sistema soporta la venta de entradas con tarifas dinámicas, administración de combos de alimentos, gestión de funciones y salas, y un módulo analítico para la toma de decisiones comerciales. 

Este proyecto fue desarrollado como Trabajo Práctico Integrador, enfocándose en traducir requerimientos de negocio reales en soluciones técnicas escalables.

## 🚀 Tecnologías y Herramientas
* **Lenguaje:** C#
* **Framework:** .NET Framework 4.8
* **Interfaz Gráfica:** Windows Forms
* **Base de Datos:** Microsoft SQL Server (Express)
* **Reportes:** Microsoft Report Viewer
* **Control de Versiones:** Git & GitHub

## ✨ Funcionalidades Principales
* **Gestión Comercial:** Proceso completo de venta de entradas y combos, aplicando restricciones de edad (Calificación INCAA) y cálculo de precios con promociones dinámicas.
* **Administración (ABM):** Gestión completa de Películas, Funciones, Salas, Clientes, Empleados y Productos.
* **Control de Ocupación:** Mapeo de asientos en tiempo real según la capacidad de cada sala.
* **Analítica de Negocio (BI):** * Gráficos estadísticos de ventas por empleado.
  * Porcentaje de ocupación de funciones filtrado por género y sala.
  * Análisis de impacto de descuentos en el precio final.
* **Seguridad:** Autenticación de usuarios y perfiles de empleados.

## ⚙️ Instalación y Configuración
1. Clonar el repositorio:
   ```bash
   git clone [https://github.com/TuUsuario/CineLife.git](https://github.com/TuUsuario/CineLife.git)
